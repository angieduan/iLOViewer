﻿namespace iLOViewer
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.timer_ShowServerInfo = new System.Windows.Forms.Timer(this.components);
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_ServerIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_ServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_ServerPower = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_LastRefresh = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_ConnStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_Fan = new System.Windows.Forms.GroupBox();
            this.listView_Fan = new Control.ListViewNF();
            this.columnHeader_Fan_Fan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Fan_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Fan_Speed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_Temp = new System.Windows.Forms.GroupBox();
            this.listView_Temp = new Control.ListViewNF();
            this.columnHeader_Temp_Sensor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Temp_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Temp_Temp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Temp_Caution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Temp_Critical = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Action = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Action_Power = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Action_Power_MomentaryPress = new System.Windows.Forms.ToolStripMenuItem();
            this.pressAndHoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coldbootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Action_RemoteConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Action_RemoteConsole_DotNet = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_iLOList = new System.Windows.Forms.GroupBox();
            this.listBox_iLOList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_listBox_iLOList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_listBox_iLOList_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_listBox_iLOList_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_listBox_iLOList_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_NotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_NotifyIcon_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer_UpdateServerInfo = new System.Windows.Forms.Timer(this.components);
            this.statusStrip_Main.SuspendLayout();
            this.groupBox_Fan.SuspendLayout();
            this.groupBox_Temp.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_iLOList.SuspendLayout();
            this.contextMenuStrip_listBox_iLOList.SuspendLayout();
            this.contextMenuStrip_NotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_ShowServerInfo
            // 
            this.timer_ShowServerInfo.Interval = 3000;
            this.timer_ShowServerInfo.Tick += new System.EventHandler(this.timer_ShowServerInfo_Tick);
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_ServerIP,
            this.toolStripStatusLabel_ServerStatus,
            this.toolStripStatusLabel_ServerPower,
            this.toolStripStatusLabel_LastRefresh,
            this.toolStripStatusLabel_ConnStatus});
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 435);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(600, 22);
            this.statusStrip_Main.TabIndex = 2;
            this.statusStrip_Main.Text = "statusStrip";
            // 
            // toolStripStatusLabel_ServerIP
            // 
            this.toolStripStatusLabel_ServerIP.Name = "toolStripStatusLabel_ServerIP";
            this.toolStripStatusLabel_ServerIP.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel_ServerIP.Text = "<Server>";
            // 
            // toolStripStatusLabel_ServerStatus
            // 
            this.toolStripStatusLabel_ServerStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel_ServerStatus.Name = "toolStripStatusLabel_ServerStatus";
            this.toolStripStatusLabel_ServerStatus.Size = new System.Drawing.Size(112, 17);
            this.toolStripStatusLabel_ServerStatus.Text = "<Server Status>";
            // 
            // toolStripStatusLabel_ServerPower
            // 
            this.toolStripStatusLabel_ServerPower.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel_ServerPower.Name = "toolStripStatusLabel_ServerPower";
            this.toolStripStatusLabel_ServerPower.Size = new System.Drawing.Size(105, 17);
            this.toolStripStatusLabel_ServerPower.Text = "<Server Power>";
            // 
            // toolStripStatusLabel_LastRefresh
            // 
            this.toolStripStatusLabel_LastRefresh.Name = "toolStripStatusLabel_LastRefresh";
            this.toolStripStatusLabel_LastRefresh.Size = new System.Drawing.Size(105, 17);
            this.toolStripStatusLabel_LastRefresh.Text = "<Last Refresh>";
            // 
            // toolStripStatusLabel_ConnStatus
            // 
            this.toolStripStatusLabel_ConnStatus.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel_ConnStatus.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_ConnStatus.Name = "toolStripStatusLabel_ConnStatus";
            this.toolStripStatusLabel_ConnStatus.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel_ConnStatus.Text = "<Status>";
            // 
            // groupBox_Fan
            // 
            this.groupBox_Fan.Controls.Add(this.listView_Fan);
            this.groupBox_Fan.Location = new System.Drawing.Point(168, 27);
            this.groupBox_Fan.Name = "groupBox_Fan";
            this.groupBox_Fan.Size = new System.Drawing.Size(420, 90);
            this.groupBox_Fan.TabIndex = 3;
            this.groupBox_Fan.TabStop = false;
            this.groupBox_Fan.Text = "Fan";
            // 
            // listView_Fan
            // 
            this.listView_Fan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Fan_Fan,
            this.columnHeader_Fan_Status,
            this.columnHeader_Fan_Speed});
            this.listView_Fan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Fan.FullRowSelect = true;
            this.listView_Fan.GridLines = true;
            this.listView_Fan.HideSelection = false;
            this.listView_Fan.Location = new System.Drawing.Point(3, 19);
            this.listView_Fan.MultiSelect = false;
            this.listView_Fan.Name = "listView_Fan";
            this.listView_Fan.Size = new System.Drawing.Size(414, 68);
            this.listView_Fan.TabIndex = 2;
            this.listView_Fan.UseCompatibleStateImageBehavior = false;
            this.listView_Fan.View = System.Windows.Forms.View.Details;
            this.listView_Fan.SelectedIndexChanged += new System.EventHandler(this.listView_Fan_SelectedIndexChanged);
            // 
            // columnHeader_Fan_Fan
            // 
            this.columnHeader_Fan_Fan.Text = "Fan";
            this.columnHeader_Fan_Fan.Width = 130;
            // 
            // columnHeader_Fan_Status
            // 
            this.columnHeader_Fan_Status.Text = "Status";
            this.columnHeader_Fan_Status.Width = 65;
            // 
            // columnHeader_Fan_Speed
            // 
            this.columnHeader_Fan_Speed.Text = "Speed";
            this.columnHeader_Fan_Speed.Width = 55;
            // 
            // groupBox_Temp
            // 
            this.groupBox_Temp.Controls.Add(this.listView_Temp);
            this.groupBox_Temp.Location = new System.Drawing.Point(168, 123);
            this.groupBox_Temp.Name = "groupBox_Temp";
            this.groupBox_Temp.Size = new System.Drawing.Size(419, 303);
            this.groupBox_Temp.TabIndex = 4;
            this.groupBox_Temp.TabStop = false;
            this.groupBox_Temp.Text = "Temp";
            // 
            // listView_Temp
            // 
            this.listView_Temp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Temp_Sensor,
            this.columnHeader_Temp_Status,
            this.columnHeader_Temp_Temp,
            this.columnHeader_Temp_Caution,
            this.columnHeader_Temp_Critical});
            this.listView_Temp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Temp.FullRowSelect = true;
            this.listView_Temp.GridLines = true;
            this.listView_Temp.HideSelection = false;
            this.listView_Temp.Location = new System.Drawing.Point(3, 19);
            this.listView_Temp.MultiSelect = false;
            this.listView_Temp.Name = "listView_Temp";
            this.listView_Temp.Size = new System.Drawing.Size(413, 281);
            this.listView_Temp.TabIndex = 1;
            this.listView_Temp.UseCompatibleStateImageBehavior = false;
            this.listView_Temp.View = System.Windows.Forms.View.Details;
            this.listView_Temp.SelectedIndexChanged += new System.EventHandler(this.listView_Temp_SelectedIndexChanged);
            // 
            // columnHeader_Temp_Sensor
            // 
            this.columnHeader_Temp_Sensor.Text = "Sensor";
            this.columnHeader_Temp_Sensor.Width = 130;
            // 
            // columnHeader_Temp_Status
            // 
            this.columnHeader_Temp_Status.Text = "Status";
            this.columnHeader_Temp_Status.Width = 65;
            // 
            // columnHeader_Temp_Temp
            // 
            this.columnHeader_Temp_Temp.Text = "Temp";
            this.columnHeader_Temp_Temp.Width = 55;
            // 
            // columnHeader_Temp_Caution
            // 
            this.columnHeader_Temp_Caution.Text = "Caution";
            this.columnHeader_Temp_Caution.Width = 75;
            // 
            // columnHeader_Temp_Critical
            // 
            this.columnHeader_Temp_Critical.Text = "Critical";
            this.columnHeader_Temp_Critical.Width = 80;
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Action});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(600, 24);
            this.menuStrip_Main.TabIndex = 5;
            this.menuStrip_Main.Text = "menuStrip";
            // 
            // toolStripMenuItem_Action
            // 
            this.toolStripMenuItem_Action.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Action_Power,
            this.toolStripMenuItem_Action_RemoteConsole});
            this.toolStripMenuItem_Action.Name = "toolStripMenuItem_Action";
            this.toolStripMenuItem_Action.ShortcutKeyDisplayString = "";
            this.toolStripMenuItem_Action.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem_Action.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem_Action.Text = "&Action";
            this.toolStripMenuItem_Action.DropDownOpened += new System.EventHandler(this.toolStripMenuItem_Action_DropDownOpened);
            // 
            // toolStripMenuItem_Action_Power
            // 
            this.toolStripMenuItem_Action_Power.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Action_Power_MomentaryPress,
            this.pressAndHoldToolStripMenuItem,
            this.coldbootToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.toolStripMenuItem_Action_Power.Name = "toolStripMenuItem_Action_Power";
            this.toolStripMenuItem_Action_Power.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem_Action_Power.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem_Action_Power.Text = "&Power";
            // 
            // toolStripMenuItem_Action_Power_MomentaryPress
            // 
            this.toolStripMenuItem_Action_Power_MomentaryPress.Name = "toolStripMenuItem_Action_Power_MomentaryPress";
            this.toolStripMenuItem_Action_Power_MomentaryPress.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.toolStripMenuItem_Action_Power_MomentaryPress.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem_Action_Power_MomentaryPress.Text = "&Momentary Press";
            this.toolStripMenuItem_Action_Power_MomentaryPress.Click += new System.EventHandler(this.toolStripMenuItem_Action_Power_MomentaryPress_Click);
            // 
            // pressAndHoldToolStripMenuItem
            // 
            this.pressAndHoldToolStripMenuItem.Name = "pressAndHoldToolStripMenuItem";
            this.pressAndHoldToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.pressAndHoldToolStripMenuItem.Text = "&Press and Hold";
            this.pressAndHoldToolStripMenuItem.Click += new System.EventHandler(this.pressAndHoldToolStripMenuItem_Click);
            // 
            // coldbootToolStripMenuItem
            // 
            this.coldbootToolStripMenuItem.Name = "coldbootToolStripMenuItem";
            this.coldbootToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.coldbootToolStripMenuItem.Text = "&Cold boot";
            this.coldbootToolStripMenuItem.Click += new System.EventHandler(this.coldBootToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_Action_RemoteConsole
            // 
            this.toolStripMenuItem_Action_RemoteConsole.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Action_RemoteConsole_DotNet});
            this.toolStripMenuItem_Action_RemoteConsole.Name = "toolStripMenuItem_Action_RemoteConsole";
            this.toolStripMenuItem_Action_RemoteConsole.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.toolStripMenuItem_Action_RemoteConsole.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem_Action_RemoteConsole.Text = "&Remote Console";
            // 
            // toolStripMenuItem_Action_RemoteConsole_DotNet
            // 
            this.toolStripMenuItem_Action_RemoteConsole_DotNet.Name = "toolStripMenuItem_Action_RemoteConsole_DotNet";
            this.toolStripMenuItem_Action_RemoteConsole_DotNet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem_Action_RemoteConsole_DotNet.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItem_Action_RemoteConsole_DotNet.Text = ".&Net";
            this.toolStripMenuItem_Action_RemoteConsole_DotNet.Click += new System.EventHandler(this.toolStripMenuItem_Action_RemoteConsole_DotNet_Click);
            // 
            // groupBox_iLOList
            // 
            this.groupBox_iLOList.Controls.Add(this.listBox_iLOList);
            this.groupBox_iLOList.Location = new System.Drawing.Point(12, 27);
            this.groupBox_iLOList.Name = "groupBox_iLOList";
            this.groupBox_iLOList.Size = new System.Drawing.Size(150, 399);
            this.groupBox_iLOList.TabIndex = 7;
            this.groupBox_iLOList.TabStop = false;
            this.groupBox_iLOList.Text = "iLO";
            // 
            // listBox_iLOList
            // 
            this.listBox_iLOList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_iLOList.ContextMenuStrip = this.contextMenuStrip_listBox_iLOList;
            this.listBox_iLOList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_iLOList.FormattingEnabled = true;
            this.listBox_iLOList.HorizontalScrollbar = true;
            this.listBox_iLOList.ItemHeight = 15;
            this.listBox_iLOList.Location = new System.Drawing.Point(3, 19);
            this.listBox_iLOList.Name = "listBox_iLOList";
            this.listBox_iLOList.Size = new System.Drawing.Size(144, 377);
            this.listBox_iLOList.TabIndex = 0;
            this.listBox_iLOList.SelectedIndexChanged += new System.EventHandler(this.listBox_iLOList_SelectedIndexChanged);
            // 
            // contextMenuStrip_listBox_iLOList
            // 
            this.contextMenuStrip_listBox_iLOList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_listBox_iLOList_Add,
            this.toolStripMenuItem_listBox_iLOList_Edit,
            this.toolStripMenuItem_listBox_iLOList_Delete});
            this.contextMenuStrip_listBox_iLOList.Name = "contextMenuStrip_listBox_iLOList";
            this.contextMenuStrip_listBox_iLOList.Size = new System.Drawing.Size(114, 70);
            this.contextMenuStrip_listBox_iLOList.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_listBox_iLOList_Opening);
            // 
            // toolStripMenuItem_listBox_iLOList_Add
            // 
            this.toolStripMenuItem_listBox_iLOList_Add.Name = "toolStripMenuItem_listBox_iLOList_Add";
            this.toolStripMenuItem_listBox_iLOList_Add.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem_listBox_iLOList_Add.Text = "Add";
            this.toolStripMenuItem_listBox_iLOList_Add.Click += new System.EventHandler(this.toolStripMenuItem_listBox_iLOList_Add_Click);
            // 
            // toolStripMenuItem_listBox_iLOList_Edit
            // 
            this.toolStripMenuItem_listBox_iLOList_Edit.Name = "toolStripMenuItem_listBox_iLOList_Edit";
            this.toolStripMenuItem_listBox_iLOList_Edit.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem_listBox_iLOList_Edit.Text = "Edit";
            this.toolStripMenuItem_listBox_iLOList_Edit.Click += new System.EventHandler(this.toolStripMenuItem_listBox_iLOList_Edit_Click);
            // 
            // toolStripMenuItem_listBox_iLOList_Delete
            // 
            this.toolStripMenuItem_listBox_iLOList_Delete.Name = "toolStripMenuItem_listBox_iLOList_Delete";
            this.toolStripMenuItem_listBox_iLOList_Delete.Size = new System.Drawing.Size(113, 22);
            this.toolStripMenuItem_listBox_iLOList_Delete.Text = "Delete";
            this.toolStripMenuItem_listBox_iLOList_Delete.Click += new System.EventHandler(this.toolStripMenuItem_listBox_iLOList_Delete_Click);
            // 
            // contextMenuStrip_NotifyIcon
            // 
            this.contextMenuStrip_NotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_NotifyIcon_Exit});
            this.contextMenuStrip_NotifyIcon.Name = "contextMenuStrip_Action";
            this.contextMenuStrip_NotifyIcon.Size = new System.Drawing.Size(97, 26);
            // 
            // toolStripMenuItem_NotifyIcon_Exit
            // 
            this.toolStripMenuItem_NotifyIcon_Exit.Name = "toolStripMenuItem_NotifyIcon_Exit";
            this.toolStripMenuItem_NotifyIcon_Exit.Size = new System.Drawing.Size(96, 22);
            this.toolStripMenuItem_NotifyIcon_Exit.Text = "Exit";
            this.toolStripMenuItem_NotifyIcon_Exit.Click += new System.EventHandler(this.toolStripMenuItem_NotifyIcon_Exit_Click);
            // 
            // notifyIcon_Main
            // 
            this.notifyIcon_Main.ContextMenuStrip = this.contextMenuStrip_NotifyIcon;
            this.notifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Main.Icon")));
            this.notifyIcon_Main.Text = "iLO Viewer";
            this.notifyIcon_Main.Visible = true;
            this.notifyIcon_Main.DoubleClick += new System.EventHandler(this.notifyIcon_Main_DoubleClick);
            // 
            // timer_UpdateServerInfo
            // 
            this.timer_UpdateServerInfo.Interval = 10000;
            this.timer_UpdateServerInfo.Tick += new System.EventHandler(this.timer_UpdateServerInfo_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 457);
            this.Controls.Add(this.groupBox_iLOList);
            this.Controls.Add(this.groupBox_Temp);
            this.Controls.Add(this.groupBox_Fan);
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "iLO Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.statusStrip_Main.ResumeLayout(false);
            this.statusStrip_Main.PerformLayout();
            this.groupBox_Fan.ResumeLayout(false);
            this.groupBox_Temp.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_iLOList.ResumeLayout(false);
            this.contextMenuStrip_listBox_iLOList.ResumeLayout(false);
            this.contextMenuStrip_NotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_ShowServerInfo;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ServerIP;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ServerPower;
        private System.Windows.Forms.GroupBox groupBox_Fan;
        private System.Windows.Forms.GroupBox groupBox_Temp;
        private Control.ListViewNF listView_Temp;
        private System.Windows.Forms.ColumnHeader columnHeader_Temp_Sensor;
        private System.Windows.Forms.ColumnHeader columnHeader_Temp_Status;
        private System.Windows.Forms.ColumnHeader columnHeader_Temp_Temp;
        private System.Windows.Forms.ColumnHeader columnHeader_Temp_Caution;
        private System.Windows.Forms.ColumnHeader columnHeader_Temp_Critical;
        private Control.ListViewNF listView_Fan;
        private System.Windows.Forms.ColumnHeader columnHeader_Fan_Fan;
        private System.Windows.Forms.ColumnHeader columnHeader_Fan_Status;
        private System.Windows.Forms.ColumnHeader columnHeader_Fan_Speed;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Action;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Action_Power;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Action_Power_MomentaryPress;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Action_RemoteConsole;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Action_RemoteConsole_DotNet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_LastRefresh;
        private System.Windows.Forms.GroupBox groupBox_iLOList;
        private System.Windows.Forms.ListBox listBox_iLOList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_NotifyIcon;
        private System.Windows.Forms.NotifyIcon notifyIcon_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_NotifyIcon_Exit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ServerStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_ConnStatus;
        private System.Windows.Forms.Timer timer_UpdateServerInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_listBox_iLOList;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_listBox_iLOList_Add;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_listBox_iLOList_Edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_listBox_iLOList_Delete;
        private System.Windows.Forms.ToolStripMenuItem pressAndHoldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coldbootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

