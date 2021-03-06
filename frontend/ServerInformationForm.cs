// Copyright (C) 2006 Richard Nelson, Ben Kenny, Philip Nelson
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Net;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using libbrowseforspeed;

namespace BrowseForSpeed.Frontend
{
	public partial class ServerInformationForm
	{
		private ServerInformation info;
		private bool exiting;
		private bool refreshing = false;
		
		delegate void DelegateMethod();
		
		public void RefreshPlayerList()
		{
			if (this.exiting) return;
			if (this.InvokeRequired == false) {
				SetControlProperty(buttonInfoJoin, "Enabled", false);
				SetControlProperty(buttonInfoRefresh, "Enabled", false);
				try {
				refreshing = true;
				listPlayers.Items.Clear();
				int i = LFSQuery.getPubStatInfo(ref info);
				if (i == 1) { //LFSQuery.getPubStatInfo(ref info)) {
					labelPrivate.Text = info.passworded ? MainForm.languages.GetString("Global.Yes") : MainForm.languages.GetString("Global.No");
					if (info.players > 0) {
						foreach (string player in info.racerNames) {
							listPlayers.Items.Add(player);
						}
					} else {
						listPlayers.Items.Add(MainForm.languages.GetString("ServerInformationForm.EmptyServer"));
					}
					labelServerName.Text = LFSQuery.removeColourCodes(info.hostname);
					//MainForm.DrawColouredHostname(labelServerName.CreateGraphics(), info.rawHostname, labelServerName.Font, labelServerName.ClientRectangle);
					labelCars.Text = MainForm.CarsToString(LFSQuery.getCarNames(info.cars));
					labelInfo.Text = MainForm.RulesToString(info.rules);
					labelPing.Text = info.ping.ToString();
					labelTrack.Text = info.track;
				} else {
					if (i == 0) {
						listPlayers.Items.Add(MainForm.languages.GetString("ServerInformationForm.NoServer"));
					} else if (i == -1) {
						listPlayers.Items.Add(MainForm.languages.GetString("ServerInformationForm.PubstatError"));
					}
					labelPrivate.Text = "N/A";				
				}
				refreshing = false;
				SetControlProperty(buttonInfoRefresh, "Enabled", true);
				SetControlProperty(buttonInfoJoin, "Enabled", true);
				SetControlProperty(buttonInfoRefresh, "Text", MainForm.languages.GetString("ServerInformationForm.buttonInfoRefresh"));
				} catch (NullReferenceException ex) {
					MessageBox.Show(ex.Message);
				}
			} else {
				this.Invoke(new DelegateMethod(RefreshPlayerList), new Object[]{});
			}
		}
		
		public void SetInfo(ServerInformation info) {
			if (info == null) return;
			this.info = info;
		}
		
		public ServerInformation GetInfo() {
			return info;
		}
		private MainForm main;
		
		public ServerInformationForm(MainForm m) {
			this.main = m;
			this.exiting = false;
			InitializeComponent();
		}		
		
		void ButtonInfoCloseClick(object sender, System.EventArgs e) {
			this.exiting = true;
			LFSQuery.queried -= new ServerQueried(queryCallback);
			labelPrivate.Text = "N/A";
			labelInfo.Text = "N/A";
			labelPing.Text = "N/A";
			buttonInfoRefresh.Enabled = true;
			buttonInfoJoin.Enabled = true;
			listPlayers.Items.Clear();
			this.Close();
		}
		
		void ServerInformationFormLoad(object sender, System.EventArgs e) {
			buttonInfoJoin.Text = MainForm.languages.GetString("ServerInformationForm.buttonInfoJoin");
			buttonInfoClose.Text = MainForm.languages.GetString("ServerInformationForm.buttonInfoClose");
			buttonInfoRefresh.Text = MainForm.languages.GetString("ServerInformationForm.buttonInfoRefresh");
			lblServerName.Text = MainForm.languages.GetString("ServerInformationForm.lblServerName");
			labe3.Text = MainForm.languages.GetString("ServerInformationForm.labe3");
			label1.Text = MainForm.languages.GetString("ServerInformationForm.label1");
			lblInformation.Text = MainForm.languages.GetString("ServerInformationForm.lblInformation");
			groupBox1.Text = MainForm.languages.GetString("ServerInformationForm.groupBox1");
			btnAddFriend.Text = MainForm.languages.GetString("ServerInformationForm.btnAddFriend");
			lblCars.Text = MainForm.languages.GetString("ServerInformationForm.lblCars");
			lblPrivate.Text = MainForm.languages.GetString("ServerInformationForm.lblPrivate");
			this.Text = MainForm.languages.GetString("ServerInformationForm.this");
			this.CenterToParent();
			this.exiting = false;
			RefreshButtonClick(sender, e);
			labelServerName.Text = "";
			labelInfo.Text = "";
			labelPrivate.Text = "";
			labelPing.Text = "";
			labelCars.Text = "";
			labelTrack.Text = "";
			listPlayers.Items.Clear();
		}
		
		delegate void SetValueDelegate(Object obj, Object val, Object[] index);
		
		public void SetControlProperty(Control ctrl, String propName, Object val) {
			System.Reflection.PropertyInfo propInfo = ctrl.GetType().GetProperty(propName);
			Delegate dgtSetValue = new SetValueDelegate(propInfo.SetValue);
      		ctrl.Invoke(dgtSetValue, new Object[3] { ctrl, val, /*index*/null });
		}
				
		void MakeMainQuery() {
			LFSQuery q;
			SetControlProperty(buttonInfoRefresh, "Text", MainForm.languages.GetString("ServerInformationForm.buttonInfoStop"));
			SetControlProperty(buttonInfoJoin, "Enabled", false);
			try {
				if (this.exiting) return;
				if (this.info.host != null) {
					q = new LFSQuery();
					ServerInformation[] server = new ServerInformation[1];
					server[0] = this.info;
					q.query(0, 0, "browseforspeed", server, 3);
				}
				Thread t = new Thread(new ThreadStart(RefreshPlayerList));
				t.Start();
			} catch(Exception e) {
				MessageBox.Show(e.Message + " - " + e.StackTrace, "", MessageBoxButtons.OK);
			}
		}
		
		public void queryCallback(object o, ServerInformation info, Object cbObj) {
			if (this.exiting) return;
			if ((int)cbObj != 3) return;
			if (info != null) {	
				refreshServer(info);
			}
		}
		
		void RefreshButtonClick(object sender, System.EventArgs e) {
			Thread t;
			if (!refreshing) {
				LFSQuery.queried += new ServerQueried(queryCallback);
				t = new Thread(new ThreadStart(MakeMainQuery));
	  			t.Start();
			} else {
				LFSQuery.stopQuerying();
			}
		}
		
		delegate void RefreshServerDelegate(ServerInformation info);

		public void refreshServer(ServerInformation info)
		{
			if (this.exiting) return;
			try{
			if (info.success){
				this.info = info;
				labelServerName.Text = LFSQuery.removeColourCodes(info.hostname);
				//MainForm.DrawColouredHostname(labelServerName.CreateGraphics(), info., labelServerName.Font, labelServerName.ClientRectangle);
				labelCars.Text = MainForm.CarsToString(LFSQuery.getCarNames(info.cars));
				labelInfo.Text = MainForm.RulesToString(info.rules);
				labelPing.Text = info.ping.ToString();
				labelTrack.Text = info.track;
			} else {				
				labelServerName.Text = MainForm.languages.GetString("ServerInformationForm.QueryTimeOut");
				labelPing.Text = "N/A";
				labelCars.Text = "N/A";
				labelTrack.Text = "N/A";				
			} 
			} catch(Exception e){}
  		}
		
		void ContextMenuOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			btnAddFriend.Enabled = ((listPlayers.SelectedIndex != -1) && (listPlayers.Items[listPlayers.SelectedIndex].ToString() != MainForm.languages.GetString("ServerInformationForm.EmptyServer")));
		}
		
		void BtnAddFriendClick(object sender, System.EventArgs e)
		{
			if (listPlayers.SelectedIndex == -1)
				return;
			main.lvFriends.AddFriend(listPlayers.Items[listPlayers.SelectedIndex].ToString());
		}
		
		void TextInfoPasswordTextChanged(object sender, System.EventArgs e) {
			//info.password = textInfoPassword.Text;
		}
		
		void LabelInvalidated(object o, InvalidateEventArgs e)
		{
		//	MainForm.DrawColouredHostname(labelServerName.CreateGraphics(), info.rawHostname, labelServerName.Font, labelServerName.ClientRectangle);
		}
		
		
		void CbWaitCheckedChanged(object sender, EventArgs e)
		{
			CheckBox cb = sender as CheckBox;
			if (cb.Checked) {
				
			}
		}
}
}
