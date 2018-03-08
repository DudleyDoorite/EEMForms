﻿namespace EEMMain
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEpisodes = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pullFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pullSaveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbSaveGameFolder = new System.Windows.Forms.TextBox();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.toolStripEpisode = new System.Windows.Forms.ToolStrip();
            this.TSLFolderName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBSave = new System.Windows.Forms.ToolStripButton();
            this.TSBRevert = new System.Windows.Forms.ToolStripButton();
            this.TSBCopyTags = new System.Windows.Forms.ToolStripButton();
            this.TSBCopyDesc = new System.Windows.Forms.ToolStripButton();
            this.TSBCopyTitle = new System.Windows.Forms.ToolStripButton();
            this.TSBCopyFolderName = new System.Windows.Forms.ToolStripButton();
            this.tabDoorsign = new System.Windows.Forms.TabPage();
            this.CBAutoDetect = new System.Windows.Forms.CheckBox();
            this.ButtonStreaming = new System.Windows.Forms.Button();
            this.CBOSignColor = new System.Windows.Forms.ComboBox();
            this.TBSignExtra = new System.Windows.Forms.TextBox();
            this.TBSignTitle = new System.Windows.Forms.TextBox();
            this.ButtonRecording = new System.Windows.Forms.Button();
            this.ButtonAvailable = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.TSBGrabCaptures = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEpisodes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStripEpisode.SuspendLayout();
            this.tabDoorsign.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(623, 470);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(623, 495);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEpisodes);
            this.tabControl1.Controls.Add(this.tabDoorsign);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 470);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEpisodes
            // 
            this.tabEpisodes.Controls.Add(this.splitContainer1);
            this.tabEpisodes.Location = new System.Drawing.Point(4, 22);
            this.tabEpisodes.Name = "tabEpisodes";
            this.tabEpisodes.Padding = new System.Windows.Forms.Padding(3);
            this.tabEpisodes.Size = new System.Drawing.Size(615, 444);
            this.tabEpisodes.TabIndex = 1;
            this.tabEpisodes.Text = "Episodes";
            this.tabEpisodes.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbSaveGameFolder);
            this.splitContainer1.Panel2.Controls.Add(this.tbTags);
            this.splitContainer1.Panel2.Controls.Add(this.tbDescription);
            this.splitContainer1.Panel2.Controls.Add(this.tbTitle);
            this.splitContainer1.Panel2.Controls.Add(this.toolStripEpisode);
            this.splitContainer1.Size = new System.Drawing.Size(609, 438);
            this.splitContainer1.SplitterDistance = 126;
            this.splitContainer1.SplitterIncrement = 10;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowRootLines = false;
            this.treeView1.Size = new System.Drawing.Size(123, 433);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInFolderToolStripMenuItem,
            this.cloneToolStripMenuItem,
            this.archiveToolStripMenuItem,
            this.pullFilesToolStripMenuItem,
            this.pullSaveGameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // openInFolderToolStripMenuItem
            // 
            this.openInFolderToolStripMenuItem.Name = "openInFolderToolStripMenuItem";
            this.openInFolderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openInFolderToolStripMenuItem.Text = "Open in Folder";
            this.openInFolderToolStripMenuItem.Click += new System.EventHandler(this.openInFolderToolStripMenuItem_Click);
            // 
            // cloneToolStripMenuItem
            // 
            this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            this.cloneToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cloneToolStripMenuItem.Text = "Clone";
            this.cloneToolStripMenuItem.Click += new System.EventHandler(this.cloneToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.archiveToolStripMenuItem.Text = "Archive";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // pullFilesToolStripMenuItem
            // 
            this.pullFilesToolStripMenuItem.Name = "pullFilesToolStripMenuItem";
            this.pullFilesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pullFilesToolStripMenuItem.Text = "Pull Capture Files";
            this.pullFilesToolStripMenuItem.Click += new System.EventHandler(this.pullFilesToolStripMenuItem_Click);
            // 
            // pullSaveGameToolStripMenuItem
            // 
            this.pullSaveGameToolStripMenuItem.Name = "pullSaveGameToolStripMenuItem";
            this.pullSaveGameToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pullSaveGameToolStripMenuItem.Text = "Pull Save Game";
            this.pullSaveGameToolStripMenuItem.Click += new System.EventHandler(this.pullSaveGameToolStripMenuItem_Click);
            // 
            // tbSaveGameFolder
            // 
            this.tbSaveGameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSaveGameFolder.Location = new System.Drawing.Point(1, 413);
            this.tbSaveGameFolder.Name = "tbSaveGameFolder";
            this.tbSaveGameFolder.Size = new System.Drawing.Size(477, 20);
            this.tbSaveGameFolder.TabIndex = 3;
            // 
            // tbTags
            // 
            this.tbTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTags.Location = new System.Drawing.Point(1, 342);
            this.tbTags.Multiline = true;
            this.tbTags.Name = "tbTags";
            this.tbTags.Size = new System.Drawing.Size(477, 65);
            this.tbTags.TabIndex = 2;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(1, 64);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(477, 269);
            this.tbDescription.TabIndex = 1;
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(1, 26);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(477, 32);
            this.tbTitle.TabIndex = 0;
            // 
            // toolStripEpisode
            // 
            this.toolStripEpisode.CanOverflow = false;
            this.toolStripEpisode.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEpisode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLFolderName,
            this.toolStripSeparator2,
            this.TSBSave,
            this.TSBRevert,
            this.TSBCopyTags,
            this.TSBCopyDesc,
            this.TSBCopyTitle,
            this.TSBCopyFolderName,
            this.toolStripSeparator3,
            this.TSBGrabCaptures});
            this.toolStripEpisode.Location = new System.Drawing.Point(0, 0);
            this.toolStripEpisode.Name = "toolStripEpisode";
            this.toolStripEpisode.Size = new System.Drawing.Size(481, 25);
            this.toolStripEpisode.TabIndex = 9;
            this.toolStripEpisode.Text = "toolStrip2";
            // 
            // TSLFolderName
            // 
            this.TSLFolderName.Name = "TSLFolderName";
            this.TSLFolderName.Size = new System.Drawing.Size(91, 22);
            this.TSLFolderName.Text = "TSLFolderName";
            this.TSLFolderName.Click += new System.EventHandler(this.TSLFolderName_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBSave
            // 
            this.TSBSave.Image = ((System.Drawing.Image)(resources.GetObject("TSBSave.Image")));
            this.TSBSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSave.Name = "TSBSave";
            this.TSBSave.Size = new System.Drawing.Size(51, 22);
            this.TSBSave.Text = "Save";
            this.TSBSave.Click += new System.EventHandler(this.TSBSave_Click);
            // 
            // TSBRevert
            // 
            this.TSBRevert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBRevert.Image = ((System.Drawing.Image)(resources.GetObject("TSBRevert.Image")));
            this.TSBRevert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBRevert.Name = "TSBRevert";
            this.TSBRevert.Size = new System.Drawing.Size(23, 22);
            this.TSBRevert.Text = "Revert";
            this.TSBRevert.Click += new System.EventHandler(this.TSBRevert_Click);
            // 
            // TSBCopyTags
            // 
            this.TSBCopyTags.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBCopyTags.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBCopyTags.Image = ((System.Drawing.Image)(resources.GetObject("TSBCopyTags.Image")));
            this.TSBCopyTags.Name = "TSBCopyTags";
            this.TSBCopyTags.Size = new System.Drawing.Size(23, 22);
            this.TSBCopyTags.Text = "Copy Tags";
            this.TSBCopyTags.Click += new System.EventHandler(this.TSBCopyTags_Click);
            // 
            // TSBCopyDesc
            // 
            this.TSBCopyDesc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBCopyDesc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBCopyDesc.Image = ((System.Drawing.Image)(resources.GetObject("TSBCopyDesc.Image")));
            this.TSBCopyDesc.Name = "TSBCopyDesc";
            this.TSBCopyDesc.Size = new System.Drawing.Size(23, 22);
            this.TSBCopyDesc.Text = "Copy Description";
            this.TSBCopyDesc.Click += new System.EventHandler(this.TSBCopyDesc_Click);
            // 
            // TSBCopyTitle
            // 
            this.TSBCopyTitle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBCopyTitle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBCopyTitle.Image = ((System.Drawing.Image)(resources.GetObject("TSBCopyTitle.Image")));
            this.TSBCopyTitle.Name = "TSBCopyTitle";
            this.TSBCopyTitle.Size = new System.Drawing.Size(23, 22);
            this.TSBCopyTitle.Text = "Copy Title";
            this.TSBCopyTitle.Click += new System.EventHandler(this.TSBCopyTitle_Click);
            // 
            // TSBCopyFolderName
            // 
            this.TSBCopyFolderName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBCopyFolderName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBCopyFolderName.Image = ((System.Drawing.Image)(resources.GetObject("TSBCopyFolderName.Image")));
            this.TSBCopyFolderName.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBCopyFolderName.Name = "TSBCopyFolderName";
            this.TSBCopyFolderName.Size = new System.Drawing.Size(23, 22);
            this.TSBCopyFolderName.Text = "Copy Folder Name";
            this.TSBCopyFolderName.Click += new System.EventHandler(this.TSBCopyFolderName_Click);
            // 
            // tabDoorsign
            // 
            this.tabDoorsign.Controls.Add(this.CBAutoDetect);
            this.tabDoorsign.Controls.Add(this.ButtonStreaming);
            this.tabDoorsign.Controls.Add(this.CBOSignColor);
            this.tabDoorsign.Controls.Add(this.TBSignExtra);
            this.tabDoorsign.Controls.Add(this.TBSignTitle);
            this.tabDoorsign.Controls.Add(this.ButtonRecording);
            this.tabDoorsign.Controls.Add(this.ButtonAvailable);
            this.tabDoorsign.Location = new System.Drawing.Point(4, 22);
            this.tabDoorsign.Name = "tabDoorsign";
            this.tabDoorsign.Padding = new System.Windows.Forms.Padding(3);
            this.tabDoorsign.Size = new System.Drawing.Size(615, 444);
            this.tabDoorsign.TabIndex = 2;
            this.tabDoorsign.Text = "Door Sign";
            this.tabDoorsign.UseVisualStyleBackColor = true;
            // 
            // CBAutoDetect
            // 
            this.CBAutoDetect.AutoSize = true;
            this.CBAutoDetect.Location = new System.Drawing.Point(497, 39);
            this.CBAutoDetect.Name = "CBAutoDetect";
            this.CBAutoDetect.Size = new System.Drawing.Size(80, 17);
            this.CBAutoDetect.TabIndex = 4;
            this.CBAutoDetect.Text = "AutoDetect";
            this.CBAutoDetect.UseVisualStyleBackColor = true;
            // 
            // ButtonStreaming
            // 
            this.ButtonStreaming.BackColor = System.Drawing.Color.Red;
            this.ButtonStreaming.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStreaming.Location = new System.Drawing.Point(290, 7);
            this.ButtonStreaming.Name = "ButtonStreaming";
            this.ButtonStreaming.Size = new System.Drawing.Size(135, 49);
            this.ButtonStreaming.TabIndex = 3;
            this.ButtonStreaming.Text = "Streaming";
            this.ButtonStreaming.UseVisualStyleBackColor = false;
            this.ButtonStreaming.Click += new System.EventHandler(this.ButtonStreaming_Click);
            // 
            // CBOSignColor
            // 
            this.CBOSignColor.FormattingEnabled = true;
            this.CBOSignColor.Items.AddRange(new object[] {
            "Lime",
            "Yellow",
            "Red",
            "Blue",
            "Grey",
            "Black"});
            this.CBOSignColor.Location = new System.Drawing.Point(497, 62);
            this.CBOSignColor.Name = "CBOSignColor";
            this.CBOSignColor.Size = new System.Drawing.Size(110, 21);
            this.CBOSignColor.TabIndex = 2;
            this.CBOSignColor.SelectedIndexChanged += new System.EventHandler(this.CBOSignColor_SelectedIndexChanged);
            // 
            // TBSignExtra
            // 
            this.TBSignExtra.AcceptsReturn = true;
            this.TBSignExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBSignExtra.Location = new System.Drawing.Point(8, 88);
            this.TBSignExtra.Multiline = true;
            this.TBSignExtra.Name = "TBSignExtra";
            this.TBSignExtra.Size = new System.Drawing.Size(599, 348);
            this.TBSignExtra.TabIndex = 1;
            // 
            // TBSignTitle
            // 
            this.TBSignTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBSignTitle.Location = new System.Drawing.Point(9, 62);
            this.TBSignTitle.Name = "TBSignTitle";
            this.TBSignTitle.Size = new System.Drawing.Size(481, 20);
            this.TBSignTitle.TabIndex = 1;
            // 
            // ButtonRecording
            // 
            this.ButtonRecording.BackColor = System.Drawing.Color.Yellow;
            this.ButtonRecording.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRecording.Location = new System.Drawing.Point(149, 6);
            this.ButtonRecording.Name = "ButtonRecording";
            this.ButtonRecording.Size = new System.Drawing.Size(135, 49);
            this.ButtonRecording.TabIndex = 0;
            this.ButtonRecording.Text = "Recording";
            this.ButtonRecording.UseVisualStyleBackColor = false;
            this.ButtonRecording.Click += new System.EventHandler(this.ButtonRecording_Click);
            // 
            // ButtonAvailable
            // 
            this.ButtonAvailable.BackColor = System.Drawing.Color.Chartreuse;
            this.ButtonAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAvailable.Location = new System.Drawing.Point(8, 6);
            this.ButtonAvailable.Name = "ButtonAvailable";
            this.ButtonAvailable.Size = new System.Drawing.Size(135, 49);
            this.ButtonAvailable.TabIndex = 0;
            this.ButtonAvailable.Text = "Available";
            this.ButtonAvailable.UseVisualStyleBackColor = false;
            this.ButtonAvailable.Click += new System.EventHandler(this.ButtonAvailable_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(623, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton3.Text = "Episodes";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton1.Text = "Upload";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton2.Text = "Panzoid";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // TSBGrabCaptures
            // 
            this.TSBGrabCaptures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBGrabCaptures.Image = ((System.Drawing.Image)(resources.GetObject("TSBGrabCaptures.Image")));
            this.TSBGrabCaptures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBGrabCaptures.Name = "TSBGrabCaptures";
            this.TSBGrabCaptures.Size = new System.Drawing.Size(23, 22);
            this.TSBGrabCaptures.Text = "Grab Captures";
            this.TSBGrabCaptures.Click += new System.EventHandler(this.pullFilesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 495);
            this.Controls.Add(this.toolStripContainer1);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "Form1";
            this.Text = "Epiktetus Episode Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabEpisodes.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStripEpisode.ResumeLayout(false);
            this.toolStripEpisode.PerformLayout();
            this.tabDoorsign.ResumeLayout(false);
            this.tabDoorsign.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEpisodes;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pullFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pullSaveGameToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSaveGameFolder;
        private System.Windows.Forms.TabPage tabDoorsign;
        private System.Windows.Forms.Button ButtonAvailable;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button ButtonRecording;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openInFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripEpisode;
        private System.Windows.Forms.ToolStripButton TSBSave;
        private System.Windows.Forms.ToolStripLabel TSLFolderName;
        private System.Windows.Forms.ToolStripButton TSBRevert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBCopyFolderName;
        private System.Windows.Forms.ToolStripButton TSBCopyTitle;
        private System.Windows.Forms.ToolStripButton TSBCopyDesc;
        private System.Windows.Forms.ToolStripButton TSBCopyTags;
        private System.Windows.Forms.TextBox TBSignTitle;
        private System.Windows.Forms.ComboBox CBOSignColor;
        private System.Windows.Forms.TextBox TBSignExtra;
        private System.Windows.Forms.Button ButtonStreaming;
        private System.Windows.Forms.CheckBox CBAutoDetect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSBGrabCaptures;
    }
}

