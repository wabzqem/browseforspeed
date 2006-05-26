﻿/*
 * Created by SharpDevelop.
 * User: Ben
 * Date: 20/05/2006
 * Time: 7:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LFS_ServerBrowser
{
	partial class MainForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textFindUser = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.findUserbutton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbRAC = new System.Windows.Forms.CheckBox();
			this.cbFZR = new System.Windows.Forms.CheckBox();
			this.cbXRR = new System.Windows.Forms.CheckBox();
			this.cbFXR = new System.Windows.Forms.CheckBox();
			this.cbBF1 = new System.Windows.Forms.CheckBox();
			this.cbFO8 = new System.Windows.Forms.CheckBox();
			this.cbFOX = new System.Windows.Forms.CheckBox();
			this.cbMRT = new System.Windows.Forms.CheckBox();
			this.cbXFR = new System.Windows.Forms.CheckBox();
			this.cbUFR = new System.Windows.Forms.CheckBox();
			this.allCarsButton = new System.Windows.Forms.Button();
			this.cbFZ5 = new System.Windows.Forms.CheckBox();
			this.cbLX6 = new System.Windows.Forms.CheckBox();
			this.cbXRT = new System.Windows.Forms.CheckBox();
			this.cbFXO = new System.Windows.Forms.CheckBox();
			this.cbRB4 = new System.Windows.Forms.CheckBox();
			this.cbLX4 = new System.Windows.Forms.CheckBox();
			this.cbXRG = new System.Windows.Forms.CheckBox();
			this.cbXFG = new System.Windows.Forms.CheckBox();
			this.cbUF1 = new System.Windows.Forms.CheckBox();
			this.comboBoxTracks = new System.Windows.Forms.ComboBox();
			this.ssCarsbutton = new System.Windows.Forms.Button();
			this.gtrCarsButton = new System.Windows.Forms.Button();
			this.fwdCarsButton = new System.Windows.Forms.Button();
			this.lrfCarsButton = new System.Windows.Forms.Button();
			this.tboCarsButton = new System.Windows.Forms.Button();
			this.stdCarsButton = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeaderName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderPing = new System.Windows.Forms.ColumnHeader();
			this.columnPrivate = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderConnections = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderInfo = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderTrack = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderCars = new System.Windows.Forms.ColumnHeader();
			this.contextMenuBrowser = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.joinServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewServerInformationMain = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshButton = new System.Windows.Forms.Button();
			this.joinButton = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.buttonAddFav = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonRefreshFav = new System.Windows.Forms.Button();
			this.buttonJoinFav = new System.Windows.Forms.Button();
			this.listViewFav = new System.Windows.Forms.ListView();
			this.columnHeaderFavServerName = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderFavPing = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderFavPrivate = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderFavSlots = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderFavInfo = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderFavTrack = new System.Windows.Forms.ColumnHeader();
			this.columnHeaderFavCars = new System.Windows.Forms.ColumnHeader();
			this.contextMenuFav = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.joinServerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.viewServerInformationFav = new System.Windows.Forms.ToolStripMenuItem();
			this.removeFromFavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonCheckNewVersion = new System.Windows.Forms.Button();
			this.cbNewVersion = new System.Windows.Forms.CheckBox();
			this.cbQueryWait = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pathList = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.browseForButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.timerThread = new System.Windows.Forms.Timer(this.components);
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusTotal = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusRefused = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusNoReply = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.contextMenuBrowser.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.contextMenuFav.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(792, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.aboutToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
			this.aboutToolStripMenuItem1.Text = "&About...";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1Click);
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
			this.tabControl.Location = new System.Drawing.Point(0, 24);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(792, 527);
			this.tabControl.TabIndex = 1;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControlSelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textFindUser);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.passwordText);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.findUserbutton);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Controls.Add(this.refreshButton);
			this.tabPage1.Controls.Add(this.joinButton);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(784, 501);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Server Browser";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// textFindUser
			// 
			this.textFindUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textFindUser.Location = new System.Drawing.Point(497, 472);
			this.textFindUser.Name = "textFindUser";
			this.textFindUser.Size = new System.Drawing.Size(158, 21);
			this.textFindUser.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(441, 477);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 21);
			this.label1.TabIndex = 8;
			this.label1.Text = "Find User:";
			// 
			// passwordText
			// 
			this.passwordText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.passwordText.Location = new System.Drawing.Point(262, 474);
			this.passwordText.Name = "passwordText";
			this.passwordText.PasswordChar = '*';
			this.passwordText.Size = new System.Drawing.Size(173, 21);
			this.passwordText.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.Location = new System.Drawing.Point(170, 477);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 16);
			this.label6.TabIndex = 6;
			this.label6.Text = "Server Password:";
			// 
			// findUserbutton
			// 
			this.findUserbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.findUserbutton.Location = new System.Drawing.Point(661, 472);
			this.findUserbutton.Name = "findUserbutton";
			this.findUserbutton.Size = new System.Drawing.Size(115, 23);
			this.findUserbutton.TabIndex = 5;
			this.findUserbutton.Text = "&Find User Online";
			this.findUserbutton.UseVisualStyleBackColor = true;
			this.findUserbutton.Click += new System.EventHandler(this.FindUserbuttonClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.cbRAC);
			this.groupBox2.Controls.Add(this.cbFZR);
			this.groupBox2.Controls.Add(this.cbXRR);
			this.groupBox2.Controls.Add(this.cbFXR);
			this.groupBox2.Controls.Add(this.cbBF1);
			this.groupBox2.Controls.Add(this.cbFO8);
			this.groupBox2.Controls.Add(this.cbFOX);
			this.groupBox2.Controls.Add(this.cbMRT);
			this.groupBox2.Controls.Add(this.cbXFR);
			this.groupBox2.Controls.Add(this.cbUFR);
			this.groupBox2.Controls.Add(this.allCarsButton);
			this.groupBox2.Controls.Add(this.cbFZ5);
			this.groupBox2.Controls.Add(this.cbLX6);
			this.groupBox2.Controls.Add(this.cbXRT);
			this.groupBox2.Controls.Add(this.cbFXO);
			this.groupBox2.Controls.Add(this.cbRB4);
			this.groupBox2.Controls.Add(this.cbLX4);
			this.groupBox2.Controls.Add(this.cbXRG);
			this.groupBox2.Controls.Add(this.cbXFG);
			this.groupBox2.Controls.Add(this.cbUF1);
			this.groupBox2.Controls.Add(this.comboBoxTracks);
			this.groupBox2.Controls.Add(this.ssCarsbutton);
			this.groupBox2.Controls.Add(this.gtrCarsButton);
			this.groupBox2.Controls.Add(this.fwdCarsButton);
			this.groupBox2.Controls.Add(this.lrfCarsButton);
			this.groupBox2.Controls.Add(this.tboCarsButton);
			this.groupBox2.Controls.Add(this.stdCarsButton);
			this.groupBox2.Location = new System.Drawing.Point(661, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(115, 458);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filters";
			// 
			// cbRAC
			// 
			this.cbRAC.Checked = true;
			this.cbRAC.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbRAC.Location = new System.Drawing.Point(6, 175);
			this.cbRAC.Name = "cbRAC";
			this.cbRAC.Size = new System.Drawing.Size(50, 22);
			this.cbRAC.TabIndex = 18;
			this.cbRAC.Text = "RAC";
			this.cbRAC.ThreeState = true;
			this.cbRAC.UseVisualStyleBackColor = true;
			// 
			// cbFZR
			// 
			this.cbFZR.Checked = true;
			this.cbFZR.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbFZR.Location = new System.Drawing.Point(59, 175);
			this.cbFZR.Name = "cbFZR";
			this.cbFZR.Size = new System.Drawing.Size(50, 22);
			this.cbFZR.TabIndex = 28;
			this.cbFZR.Text = "FZR";
			this.cbFZR.ThreeState = true;
			this.cbFZR.UseVisualStyleBackColor = true;
			// 
			// cbXRR
			// 
			this.cbXRR.Checked = true;
			this.cbXRR.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbXRR.Location = new System.Drawing.Point(59, 156);
			this.cbXRR.Name = "cbXRR";
			this.cbXRR.Size = new System.Drawing.Size(50, 22);
			this.cbXRR.TabIndex = 27;
			this.cbXRR.Text = "XRR";
			this.cbXRR.ThreeState = true;
			this.cbXRR.UseVisualStyleBackColor = true;
			// 
			// cbFXR
			// 
			this.cbFXR.Checked = true;
			this.cbFXR.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbFXR.Location = new System.Drawing.Point(59, 138);
			this.cbFXR.Name = "cbFXR";
			this.cbFXR.Size = new System.Drawing.Size(50, 22);
			this.cbFXR.TabIndex = 26;
			this.cbFXR.Text = "FXR";
			this.cbFXR.ThreeState = true;
			this.cbFXR.UseVisualStyleBackColor = true;
			// 
			// cbBF1
			// 
			this.cbBF1.Checked = true;
			this.cbBF1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbBF1.Location = new System.Drawing.Point(59, 118);
			this.cbBF1.Name = "cbBF1";
			this.cbBF1.Size = new System.Drawing.Size(50, 22);
			this.cbBF1.TabIndex = 25;
			this.cbBF1.Text = "BF1";
			this.cbBF1.ThreeState = true;
			this.cbBF1.UseVisualStyleBackColor = true;
			// 
			// cbFO8
			// 
			this.cbFO8.Checked = true;
			this.cbFO8.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbFO8.Location = new System.Drawing.Point(59, 100);
			this.cbFO8.Name = "cbFO8";
			this.cbFO8.Size = new System.Drawing.Size(50, 22);
			this.cbFO8.TabIndex = 24;
			this.cbFO8.Text = "FO8";
			this.cbFO8.ThreeState = true;
			this.cbFO8.UseVisualStyleBackColor = true;
			// 
			// cbFOX
			// 
			this.cbFOX.Checked = true;
			this.cbFOX.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbFOX.Location = new System.Drawing.Point(59, 81);
			this.cbFOX.Name = "cbFOX";
			this.cbFOX.Size = new System.Drawing.Size(50, 22);
			this.cbFOX.TabIndex = 23;
			this.cbFOX.Text = "FOX";
			this.cbFOX.ThreeState = true;
			this.cbFOX.UseVisualStyleBackColor = true;
			// 
			// cbMRT
			// 
			this.cbMRT.Checked = true;
			this.cbMRT.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbMRT.Location = new System.Drawing.Point(59, 61);
			this.cbMRT.Name = "cbMRT";
			this.cbMRT.Size = new System.Drawing.Size(50, 22);
			this.cbMRT.TabIndex = 22;
			this.cbMRT.Text = "MRT";
			this.cbMRT.ThreeState = true;
			this.cbMRT.UseVisualStyleBackColor = true;
			// 
			// cbXFR
			// 
			this.cbXFR.Checked = true;
			this.cbXFR.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbXFR.Location = new System.Drawing.Point(59, 42);
			this.cbXFR.Name = "cbXFR";
			this.cbXFR.Size = new System.Drawing.Size(50, 22);
			this.cbXFR.TabIndex = 21;
			this.cbXFR.Text = "XFR";
			this.cbXFR.ThreeState = true;
			this.cbXFR.UseVisualStyleBackColor = true;
			// 
			// cbUFR
			// 
			this.cbUFR.Checked = true;
			this.cbUFR.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbUFR.Location = new System.Drawing.Point(59, 22);
			this.cbUFR.Name = "cbUFR";
			this.cbUFR.Size = new System.Drawing.Size(50, 22);
			this.cbUFR.TabIndex = 20;
			this.cbUFR.Text = "UFR";
			this.cbUFR.ThreeState = true;
			this.cbUFR.UseVisualStyleBackColor = true;
			// 
			// allCarsButton
			// 
			this.allCarsButton.Location = new System.Drawing.Point(6, 238);
			this.allCarsButton.Name = "allCarsButton";
			this.allCarsButton.Size = new System.Drawing.Size(42, 23);
			this.allCarsButton.TabIndex = 0;
			this.allCarsButton.Text = "ALL";
			this.allCarsButton.UseVisualStyleBackColor = true;
			this.allCarsButton.Click += new System.EventHandler(this.AllCarsButtonClick);
			// 
			// cbFZ5
			// 
			this.cbFZ5.Checked = true;
			this.cbFZ5.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbFZ5.Location = new System.Drawing.Point(6, 194);
			this.cbFZ5.Name = "cbFZ5";
			this.cbFZ5.Size = new System.Drawing.Size(50, 22);
			this.cbFZ5.TabIndex = 19;
			this.cbFZ5.Text = "FZ5";
			this.cbFZ5.ThreeState = true;
			this.cbFZ5.UseVisualStyleBackColor = true;
			// 
			// cbLX6
			// 
			this.cbLX6.Checked = true;
			this.cbLX6.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbLX6.Location = new System.Drawing.Point(6, 157);
			this.cbLX6.Name = "cbLX6";
			this.cbLX6.Size = new System.Drawing.Size(50, 22);
			this.cbLX6.TabIndex = 17;
			this.cbLX6.Text = "LX6";
			this.cbLX6.ThreeState = true;
			this.cbLX6.UseVisualStyleBackColor = true;
			// 
			// cbXRT
			// 
			this.cbXRT.Checked = true;
			this.cbXRT.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbXRT.Location = new System.Drawing.Point(6, 136);
			this.cbXRT.Name = "cbXRT";
			this.cbXRT.Size = new System.Drawing.Size(50, 24);
			this.cbXRT.TabIndex = 16;
			this.cbXRT.Text = "XRT";
			this.cbXRT.ThreeState = true;
			this.cbXRT.UseVisualStyleBackColor = true;
			// 
			// cbFXO
			// 
			this.cbFXO.Checked = true;
			this.cbFXO.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbFXO.Location = new System.Drawing.Point(6, 118);
			this.cbFXO.Name = "cbFXO";
			this.cbFXO.Size = new System.Drawing.Size(50, 24);
			this.cbFXO.TabIndex = 15;
			this.cbFXO.Text = "FXO";
			this.cbFXO.ThreeState = true;
			this.cbFXO.UseVisualStyleBackColor = true;
			// 
			// cbRB4
			// 
			this.cbRB4.Checked = true;
			this.cbRB4.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbRB4.Location = new System.Drawing.Point(6, 99);
			this.cbRB4.Name = "cbRB4";
			this.cbRB4.Size = new System.Drawing.Size(50, 24);
			this.cbRB4.TabIndex = 14;
			this.cbRB4.Text = "RB4";
			this.cbRB4.ThreeState = true;
			this.cbRB4.UseVisualStyleBackColor = true;
			// 
			// cbLX4
			// 
			this.cbLX4.Checked = true;
			this.cbLX4.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbLX4.Location = new System.Drawing.Point(6, 79);
			this.cbLX4.Name = "cbLX4";
			this.cbLX4.Size = new System.Drawing.Size(50, 24);
			this.cbLX4.TabIndex = 13;
			this.cbLX4.Text = "LX4";
			this.cbLX4.ThreeState = true;
			this.cbLX4.UseVisualStyleBackColor = true;
			// 
			// cbXRG
			// 
			this.cbXRG.Checked = true;
			this.cbXRG.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbXRG.Location = new System.Drawing.Point(6, 60);
			this.cbXRG.Name = "cbXRG";
			this.cbXRG.Size = new System.Drawing.Size(50, 24);
			this.cbXRG.TabIndex = 12;
			this.cbXRG.Text = "XRG";
			this.cbXRG.ThreeState = true;
			this.cbXRG.UseVisualStyleBackColor = true;
			// 
			// cbXFG
			// 
			this.cbXFG.Checked = true;
			this.cbXFG.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbXFG.Location = new System.Drawing.Point(6, 41);
			this.cbXFG.Name = "cbXFG";
			this.cbXFG.Size = new System.Drawing.Size(50, 24);
			this.cbXFG.TabIndex = 11;
			this.cbXFG.Text = "XFG";
			this.cbXFG.ThreeState = true;
			this.cbXFG.UseVisualStyleBackColor = true;
			// 
			// cbUF1
			// 
			this.cbUF1.Checked = true;
			this.cbUF1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
			this.cbUF1.Location = new System.Drawing.Point(6, 21);
			this.cbUF1.Name = "cbUF1";
			this.cbUF1.Size = new System.Drawing.Size(50, 24);
			this.cbUF1.TabIndex = 8;
			this.cbUF1.Text = "UF1";
			this.cbUF1.ThreeState = true;
			this.cbUF1.UseVisualStyleBackColor = true;
			// 
			// comboBoxTracks
			// 
			this.comboBoxTracks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTracks.FormattingEnabled = true;
			this.comboBoxTracks.Items.AddRange(new object[] {
									"All Tracks",
									"Blackwood",
									"South City",
									"Fern Bay",
									"Autocross",
									"Kyoto Ring",
									"Westhill",
									"Aston"});
			this.comboBoxTracks.Location = new System.Drawing.Point(6, 369);
			this.comboBoxTracks.Name = "comboBoxTracks";
			this.comboBoxTracks.Size = new System.Drawing.Size(103, 21);
			this.comboBoxTracks.TabIndex = 10;
			this.comboBoxTracks.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTracksSelectedIndexChanged);
			// 
			// ssCarsbutton
			// 
			this.ssCarsbutton.Location = new System.Drawing.Point(6, 325);
			this.ssCarsbutton.Name = "ssCarsbutton";
			this.ssCarsbutton.Size = new System.Drawing.Size(42, 23);
			this.ssCarsbutton.TabIndex = 6;
			this.ssCarsbutton.Text = "S-S";
			this.ssCarsbutton.UseVisualStyleBackColor = true;
			this.ssCarsbutton.Click += new System.EventHandler(this.SsCarsbuttonClick);
			// 
			// gtrCarsButton
			// 
			this.gtrCarsButton.Location = new System.Drawing.Point(59, 296);
			this.gtrCarsButton.Name = "gtrCarsButton";
			this.gtrCarsButton.Size = new System.Drawing.Size(42, 23);
			this.gtrCarsButton.TabIndex = 5;
			this.gtrCarsButton.Text = "GTR";
			this.gtrCarsButton.UseVisualStyleBackColor = true;
			this.gtrCarsButton.Click += new System.EventHandler(this.GtrCarsButtonClick);
			// 
			// fwdCarsButton
			// 
			this.fwdCarsButton.Location = new System.Drawing.Point(6, 296);
			this.fwdCarsButton.Name = "fwdCarsButton";
			this.fwdCarsButton.Size = new System.Drawing.Size(42, 23);
			this.fwdCarsButton.TabIndex = 4;
			this.fwdCarsButton.Text = "FWD";
			this.fwdCarsButton.UseVisualStyleBackColor = true;
			this.fwdCarsButton.Click += new System.EventHandler(this.FwdCarsButtonClick);
			// 
			// lrfCarsButton
			// 
			this.lrfCarsButton.Location = new System.Drawing.Point(59, 267);
			this.lrfCarsButton.Name = "lrfCarsButton";
			this.lrfCarsButton.Size = new System.Drawing.Size(42, 23);
			this.lrfCarsButton.TabIndex = 3;
			this.lrfCarsButton.Text = "LRF";
			this.lrfCarsButton.UseVisualStyleBackColor = true;
			this.lrfCarsButton.Click += new System.EventHandler(this.LrfCarsButtonClick);
			// 
			// tboCarsButton
			// 
			this.tboCarsButton.Location = new System.Drawing.Point(6, 267);
			this.tboCarsButton.Name = "tboCarsButton";
			this.tboCarsButton.Size = new System.Drawing.Size(42, 23);
			this.tboCarsButton.TabIndex = 2;
			this.tboCarsButton.Text = "TBO";
			this.tboCarsButton.UseVisualStyleBackColor = true;
			this.tboCarsButton.Click += new System.EventHandler(this.TboCarsButtonClick);
			// 
			// stdCarsButton
			// 
			this.stdCarsButton.Location = new System.Drawing.Point(59, 238);
			this.stdCarsButton.Name = "stdCarsButton";
			this.stdCarsButton.Size = new System.Drawing.Size(42, 23);
			this.stdCarsButton.TabIndex = 1;
			this.stdCarsButton.Text = "STD";
			this.stdCarsButton.UseVisualStyleBackColor = true;
			this.stdCarsButton.Click += new System.EventHandler(this.StdCarsButtonClick);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.AutoArrange = false;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeaderName,
									this.columnHeaderPing,
									this.columnPrivate,
									this.columnHeaderConnections,
									this.columnHeaderInfo,
									this.columnHeaderTrack,
									this.columnHeaderCars});
			this.listView1.ContextMenuStrip = this.contextMenuBrowser;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(8, 6);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(647, 460);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.DoubleClick += new System.EventHandler(this.JoinButtonClick);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView1KeyDown);
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView1ColumnClick);
			this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListView1KeyPress);
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "Server Name";
			this.columnHeaderName.Width = 200;
			// 
			// columnHeaderPing
			// 
			this.columnHeaderPing.Text = "Ping";
			this.columnHeaderPing.Width = 50;
			// 
			// columnPrivate
			// 
			this.columnPrivate.Text = "Private";
			this.columnPrivate.Width = 50;
			// 
			// columnHeaderConnections
			// 
			this.columnHeaderConnections.Text = "Connections";
			this.columnHeaderConnections.Width = 80;
			// 
			// columnHeaderInfo
			// 
			this.columnHeaderInfo.Text = "Info";
			// 
			// columnHeaderTrack
			// 
			this.columnHeaderTrack.Text = "Track";
			// 
			// columnHeaderCars
			// 
			this.columnHeaderCars.Text = "Cars";
			this.columnHeaderCars.Width = 180;
			// 
			// contextMenuBrowser
			// 
			this.contextMenuBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.joinServerToolStripMenuItem,
									this.viewServerInformationMain,
									this.toolStripMenuItem1});
			this.contextMenuBrowser.Name = "contextMenuBrowser";
			this.contextMenuBrowser.Size = new System.Drawing.Size(214, 70);
			this.contextMenuBrowser.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuBrowserOpening);
			// 
			// joinServerToolStripMenuItem
			// 
			this.joinServerToolStripMenuItem.Name = "joinServerToolStripMenuItem";
			this.joinServerToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.joinServerToolStripMenuItem.Text = "&Join Server";
			this.joinServerToolStripMenuItem.Click += new System.EventHandler(this.JoinButtonClick);
			// 
			// viewServerInformationMain
			// 
			this.viewServerInformationMain.Name = "viewServerInformationMain";
			this.viewServerInformationMain.Size = new System.Drawing.Size(213, 22);
			this.viewServerInformationMain.Text = "&View Server Information...";
			this.viewServerInformationMain.Click += new System.EventHandler(this.ViewServerInformationToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItem1.Text = "&Add to Favourites";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// refreshButton
			// 
			this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.refreshButton.Location = new System.Drawing.Point(89, 472);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(75, 23);
			this.refreshButton.TabIndex = 2;
			this.refreshButton.Text = "&Refresh";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
			// 
			// joinButton
			// 
			this.joinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.joinButton.Enabled = false;
			this.joinButton.Location = new System.Drawing.Point(8, 472);
			this.joinButton.Name = "joinButton";
			this.joinButton.Size = new System.Drawing.Size(75, 23);
			this.joinButton.TabIndex = 1;
			this.joinButton.Text = "&Join";
			this.joinButton.UseVisualStyleBackColor = true;
			this.joinButton.Click += new System.EventHandler(this.JoinButtonClick);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.buttonAddFav);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.textBox1);
			this.tabPage3.Controls.Add(this.buttonRefreshFav);
			this.tabPage3.Controls.Add(this.buttonJoinFav);
			this.tabPage3.Controls.Add(this.listViewFav);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(784, 501);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Favourites";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// buttonAddFav
			// 
			this.buttonAddFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAddFav.Location = new System.Drawing.Point(661, 473);
			this.buttonAddFav.Name = "buttonAddFav";
			this.buttonAddFav.Size = new System.Drawing.Size(115, 23);
			this.buttonAddFav.TabIndex = 9;
			this.buttonAddFav.Text = "&Add to Favourites";
			this.buttonAddFav.UseVisualStyleBackColor = true;
			this.buttonAddFav.Click += new System.EventHandler(this.ButtonAddFavClick);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Location = new System.Drawing.Point(379, 478);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(98, 23);
			this.label7.TabIndex = 8;
			this.label7.Text = "Server IP Address:";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(483, 475);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(172, 21);
			this.textBox1.TabIndex = 7;
			// 
			// buttonRefreshFav
			// 
			this.buttonRefreshFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRefreshFav.Location = new System.Drawing.Point(89, 475);
			this.buttonRefreshFav.Name = "buttonRefreshFav";
			this.buttonRefreshFav.Size = new System.Drawing.Size(75, 23);
			this.buttonRefreshFav.TabIndex = 6;
			this.buttonRefreshFav.Text = "&Refresh All";
			this.buttonRefreshFav.UseVisualStyleBackColor = true;
			this.buttonRefreshFav.Click += new System.EventHandler(this.ButtonRefreshFavClick);
			// 
			// buttonJoinFav
			// 
			this.buttonJoinFav.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonJoinFav.Enabled = false;
			this.buttonJoinFav.Location = new System.Drawing.Point(8, 475);
			this.buttonJoinFav.Name = "buttonJoinFav";
			this.buttonJoinFav.Size = new System.Drawing.Size(75, 23);
			this.buttonJoinFav.TabIndex = 5;
			this.buttonJoinFav.Text = "&Join";
			this.buttonJoinFav.UseVisualStyleBackColor = true;
			this.buttonJoinFav.Click += new System.EventHandler(this.ButtonJoinFavClick);
			// 
			// listViewFav
			// 
			this.listViewFav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewFav.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeaderFavServerName,
									this.columnHeaderFavPing,
									this.columnHeaderFavPrivate,
									this.columnHeaderFavSlots,
									this.columnHeaderFavInfo,
									this.columnHeaderFavTrack,
									this.columnHeaderFavCars});
			this.listViewFav.ContextMenuStrip = this.contextMenuFav;
			this.listViewFav.FullRowSelect = true;
			this.listViewFav.GridLines = true;
			this.listViewFav.Location = new System.Drawing.Point(8, 6);
			this.listViewFav.MultiSelect = false;
			this.listViewFav.Name = "listViewFav";
			this.listViewFav.Size = new System.Drawing.Size(768, 461);
			this.listViewFav.TabIndex = 4;
			this.listViewFav.UseCompatibleStateImageBehavior = false;
			this.listViewFav.View = System.Windows.Forms.View.Details;
			this.listViewFav.DoubleClick += new System.EventHandler(this.ButtonJoinFavClick);
			this.listViewFav.SelectedIndexChanged += new System.EventHandler(this.ListViewFavSelectedIndexChanged);
			this.listViewFav.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView1ColumnClick);
			// 
			// columnHeaderFavServerName
			// 
			this.columnHeaderFavServerName.Text = "Server Name";
			this.columnHeaderFavServerName.Width = 200;
			// 
			// columnHeaderFavPing
			// 
			this.columnHeaderFavPing.Text = "Ping";
			this.columnHeaderFavPing.Width = 50;
			// 
			// columnHeaderFavPrivate
			// 
			this.columnHeaderFavPrivate.Text = "Private";
			// 
			// columnHeaderFavSlots
			// 
			this.columnHeaderFavSlots.Text = "Connections";
			this.columnHeaderFavSlots.Width = 80;
			// 
			// columnHeaderFavInfo
			// 
			this.columnHeaderFavInfo.Text = "Info";
			// 
			// columnHeaderFavTrack
			// 
			this.columnHeaderFavTrack.Text = "Track";
			// 
			// columnHeaderFavCars
			// 
			this.columnHeaderFavCars.Text = "Cars";
			this.columnHeaderFavCars.Width = 200;
			// 
			// contextMenuFav
			// 
			this.contextMenuFav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.joinServerToolStripMenuItem1,
									this.viewServerInformationFav,
									this.removeFromFavouritesToolStripMenuItem});
			this.contextMenuFav.Name = "contextMenuFav";
			this.contextMenuFav.Size = new System.Drawing.Size(214, 70);
			this.contextMenuFav.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuFavOpening);
			// 
			// joinServerToolStripMenuItem1
			// 
			this.joinServerToolStripMenuItem1.Name = "joinServerToolStripMenuItem1";
			this.joinServerToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
			this.joinServerToolStripMenuItem1.Text = "&Join Server";
			this.joinServerToolStripMenuItem1.Click += new System.EventHandler(this.ButtonJoinFavClick);
			// 
			// viewServerInformationFav
			// 
			this.viewServerInformationFav.Name = "viewServerInformationFav";
			this.viewServerInformationFav.Size = new System.Drawing.Size(213, 22);
			this.viewServerInformationFav.Text = "&View Server Information...";
			this.viewServerInformationFav.Click += new System.EventHandler(this.ViewServerInformationFavClick);
			// 
			// removeFromFavouritesToolStripMenuItem
			// 
			this.removeFromFavouritesToolStripMenuItem.Name = "removeFromFavouritesToolStripMenuItem";
			this.removeFromFavouritesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.removeFromFavouritesToolStripMenuItem.Text = "&Remove From Favourites";
			this.removeFromFavouritesToolStripMenuItem.Click += new System.EventHandler(this.RemoveFromFavouritesToolStripMenuItemClick);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(784, 501);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Configuration";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonCheckNewVersion);
			this.groupBox1.Controls.Add(this.cbNewVersion);
			this.groupBox1.Controls.Add(this.cbQueryWait);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.pathList);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.browseForButton);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(778, 495);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Configuration";
			// 
			// buttonCheckNewVersion
			// 
			this.buttonCheckNewVersion.Location = new System.Drawing.Point(455, 183);
			this.buttonCheckNewVersion.Name = "buttonCheckNewVersion";
			this.buttonCheckNewVersion.Size = new System.Drawing.Size(75, 23);
			this.buttonCheckNewVersion.TabIndex = 13;
			this.buttonCheckNewVersion.Text = "&Check Now";
			this.buttonCheckNewVersion.UseVisualStyleBackColor = true;
			this.buttonCheckNewVersion.Click += new System.EventHandler(this.ButtonCheckNewVersionClick);
			// 
			// cbNewVersion
			// 
			this.cbNewVersion.Location = new System.Drawing.Point(127, 182);
			this.cbNewVersion.Name = "cbNewVersion";
			this.cbNewVersion.Size = new System.Drawing.Size(322, 24);
			this.cbNewVersion.TabIndex = 12;
			this.cbNewVersion.Text = "Check for a new version of Browse For Speed on start up";
			this.cbNewVersion.UseVisualStyleBackColor = true;
			// 
			// cbQueryWait
			// 
			this.cbQueryWait.Location = new System.Drawing.Point(127, 240);
			this.cbQueryWait.Name = "cbQueryWait";
			this.cbQueryWait.Size = new System.Drawing.Size(139, 24);
			this.cbQueryWait.TabIndex = 11;
			this.cbQueryWait.Text = "Disable Query Wait";
			this.cbQueryWait.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(127, 263);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(403, 48);
			this.label4.TabIndex = 10;
			this.label4.Text = "Check this box if you are NOT using Windows XP SP2 or you are certain you have di" +
			"sabled the 10 connection limit in SP2. Read the FAQ for more information. If in " +
			"doubt, leave this option off.";
			// 
			// pathList
			// 
			this.pathList.FormattingEnabled = true;
			this.pathList.Location = new System.Drawing.Point(127, 40);
			this.pathList.Name = "pathList";
			this.pathList.Size = new System.Drawing.Size(322, 56);
			this.pathList.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(127, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(403, 44);
			this.label5.TabIndex = 7;
			this.label5.Text = "If there is more than one entry in the box above, please select which one is the " +
			"correct path for your LFS.exe. If there are no entries, please click the Browse " +
			"button to manually locate it.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "LFS Executable Path:";
			// 
			// browseForButton
			// 
			this.browseForButton.Location = new System.Drawing.Point(455, 40);
			this.browseForButton.Name = "browseForButton";
			this.browseForButton.Size = new System.Drawing.Size(75, 23);
			this.browseForButton.TabIndex = 4;
			this.browseForButton.Text = "&Browse...";
			this.browseForButton.UseVisualStyleBackColor = true;
			this.browseForButton.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "LFS.exe";
			this.openFileDialog1.Filter = "LFS Executable|LFS.exe";
			this.openFileDialog1.SupportMultiDottedExtensions = true;
			// 
			// timerThread
			// 
			this.timerThread.Tick += new System.EventHandler(this.TimerThreadTick);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.statusTotal,
									this.statusRefused,
									this.statusNoReply});
			this.statusStrip.Location = new System.Drawing.Point(0, 551);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(792, 22);
			this.statusStrip.SizingGrip = false;
			this.statusStrip.TabIndex = 2;
			// 
			// statusTotal
			// 
			this.statusTotal.Name = "statusTotal";
			this.statusTotal.Size = new System.Drawing.Size(0, 17);
			// 
			// statusRefused
			// 
			this.statusRefused.Name = "statusRefused";
			this.statusRefused.Size = new System.Drawing.Size(0, 17);
			// 
			// statusNoReply
			// 
			this.statusNoReply.Name = "statusNoReply";
			this.statusNoReply.Size = new System.Drawing.Size(0, 17);
			this.statusNoReply.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.statusStrip);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "Browse For Speed";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.contextMenuBrowser.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.contextMenuFav.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ColumnHeader columnHeaderFavPrivate;
		private System.Windows.Forms.ColumnHeader columnPrivate;
		private System.Windows.Forms.Button buttonCheckNewVersion;
		private System.Windows.Forms.CheckBox cbNewVersion;
		private System.Windows.Forms.CheckBox cbQueryWait;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripMenuItem viewServerInformationFav;
		private System.Windows.Forms.ToolStripMenuItem viewServerInformationMain;
		private System.Windows.Forms.ColumnHeader columnHeaderFavCars;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textFindUser;
		private System.Windows.Forms.CheckBox cbFO8;
		private System.Windows.Forms.CheckBox cbFZ5;
		private System.Windows.Forms.CheckBox cbUFR;
		private System.Windows.Forms.CheckBox cbXFR;
		private System.Windows.Forms.CheckBox cbFXR;
		private System.Windows.Forms.CheckBox cbFZR;
		private System.Windows.Forms.CheckBox cbLX6;
		private System.Windows.Forms.CheckBox cbRAC;
		private System.Windows.Forms.CheckBox cbXRG;
		private System.Windows.Forms.CheckBox cbLX4;
		private System.Windows.Forms.CheckBox cbRB4;
		private System.Windows.Forms.CheckBox cbFXO;
		private System.Windows.Forms.CheckBox cbXRT;
		private System.Windows.Forms.CheckBox cbXRR;
		private System.Windows.Forms.CheckBox cbMRT;
		private System.Windows.Forms.CheckBox cbFOX;
		private System.Windows.Forms.CheckBox cbBF1;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel statusNoReply;
		private System.Windows.Forms.ToolStripStatusLabel statusRefused;
		private System.Windows.Forms.ToolStripStatusLabel statusTotal;
		private System.Windows.Forms.CheckBox cbUF1;
		private System.Windows.Forms.CheckBox cbXFG;
		private System.Windows.Forms.ColumnHeader columnHeaderCars;
		private System.Windows.Forms.ColumnHeader columnHeaderFavTrack;
		private System.Windows.Forms.ColumnHeader columnHeaderTrack;
		private System.Windows.Forms.ColumnHeader columnHeaderFavInfo;
		private System.Windows.Forms.Timer timerThread;
		private System.Windows.Forms.ColumnHeader columnHeaderInfo;
		private System.Windows.Forms.ComboBox comboBoxTracks;
		private System.Windows.Forms.ColumnHeader columnHeaderFavServerName;
		private System.Windows.Forms.ColumnHeader columnHeaderFavPing;
		private System.Windows.Forms.ColumnHeader columnHeaderFavSlots;
		private System.Windows.Forms.ListView listViewFav;
		private System.Windows.Forms.ToolStripMenuItem removeFromFavouritesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem joinServerToolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip contextMenuFav;
		private System.Windows.Forms.ToolStripMenuItem joinServerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip contextMenuBrowser;
		private System.Windows.Forms.Button buttonJoinFav;
		private System.Windows.Forms.Button buttonRefreshFav;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonAddFav;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox passwordText;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ListBox pathList;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button ssCarsbutton;
		private System.Windows.Forms.Button gtrCarsButton;
		private System.Windows.Forms.Button fwdCarsButton;
		private System.Windows.Forms.Button lrfCarsButton;
		private System.Windows.Forms.Button tboCarsButton;
		private System.Windows.Forms.Button stdCarsButton;
		private System.Windows.Forms.Button allCarsButton;
		private System.Windows.Forms.Button browseForButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button findUserbutton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ColumnHeader columnHeaderConnections;
		private System.Windows.Forms.ColumnHeader columnHeaderPing;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button joinButton;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
	}
}