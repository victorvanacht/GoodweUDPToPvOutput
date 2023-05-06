namespace GoodweLogger
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHostAddress = new System.Windows.Forms.Label();
            this.textBoxHostAddress = new System.Windows.Forms.TextBox();
            this.labelLogInterval = new System.Windows.Forms.Label();
            this.textBoxLogInterval = new System.Windows.Forms.TextBox();
            this.checkBoxStartStop = new System.Windows.Forms.CheckBox();
            this.groupBoxPVOutput = new System.Windows.Forms.GroupBox();
            this.labelPVOutputRequestURL = new System.Windows.Forms.Label();
            this.textBoxPVOutputRequestURL = new System.Windows.Forms.TextBox();
            this.textBoxPVOutputAPIKey = new System.Windows.Forms.TextBox();
            this.labelPVOutputAPIKey = new System.Windows.Forms.Label();
            this.textBoxPVOutputSystemID = new System.Windows.Forms.TextBox();
            this.labelPVOutputSystemID = new System.Windows.Forms.Label();
            this.groupBoxLocalLogFile = new System.Windows.Forms.GroupBox();
            this.textBoxLogFileName = new System.Windows.Forms.TextBox();
            this.labelLogFileName = new System.Windows.Forms.Label();
            this.labelLogEntry = new System.Windows.Forms.Label();
            this.listBoxLogEntry = new System.Windows.Forms.ListBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textBoxBroadcastAddress = new System.Windows.Forms.TextBox();
            this.labelBroadcastAddress = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxPVOutput.SuspendLayout();
            this.groupBoxLocalLogFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // labelHostAddress
            // 
            this.labelHostAddress.AutoSize = true;
            this.labelHostAddress.Location = new System.Drawing.Point(12, 39);
            this.labelHostAddress.Name = "labelHostAddress";
            this.labelHostAddress.Size = new System.Drawing.Size(77, 15);
            this.labelHostAddress.TabIndex = 1;
            this.labelHostAddress.Text = "Host Address";
            // 
            // textBoxHostAddress
            // 
            this.textBoxHostAddress.Location = new System.Drawing.Point(122, 36);
            this.textBoxHostAddress.Name = "textBoxHostAddress";
            this.textBoxHostAddress.Size = new System.Drawing.Size(204, 23);
            this.textBoxHostAddress.TabIndex = 2;
            // 
            // labelLogInterval
            // 
            this.labelLogInterval.AutoSize = true;
            this.labelLogInterval.Location = new System.Drawing.Point(12, 96);
            this.labelLogInterval.Name = "labelLogInterval";
            this.labelLogInterval.Size = new System.Drawing.Size(69, 15);
            this.labelLogInterval.TabIndex = 3;
            this.labelLogInterval.Text = "Log interval";
            // 
            // textBoxLogInterval
            // 
            this.textBoxLogInterval.Location = new System.Drawing.Point(122, 93);
            this.textBoxLogInterval.Name = "textBoxLogInterval";
            this.textBoxLogInterval.Size = new System.Drawing.Size(68, 23);
            this.textBoxLogInterval.TabIndex = 4;
            // 
            // checkBoxStartStop
            // 
            this.checkBoxStartStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxStartStop.Location = new System.Drawing.Point(226, 93);
            this.checkBoxStartStop.Name = "checkBoxStartStop";
            this.checkBoxStartStop.Size = new System.Drawing.Size(100, 24);
            this.checkBoxStartStop.TabIndex = 5;
            this.checkBoxStartStop.Text = "Start";
            this.checkBoxStartStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxStartStop.UseVisualStyleBackColor = true;
            this.checkBoxStartStop.CheckedChanged += new System.EventHandler(this.CheckBoxStartStop_CheckedChanged);
            // 
            // groupBoxPVOutput
            // 
            this.groupBoxPVOutput.Controls.Add(this.labelPVOutputRequestURL);
            this.groupBoxPVOutput.Controls.Add(this.textBoxPVOutputRequestURL);
            this.groupBoxPVOutput.Controls.Add(this.textBoxPVOutputAPIKey);
            this.groupBoxPVOutput.Controls.Add(this.labelPVOutputAPIKey);
            this.groupBoxPVOutput.Controls.Add(this.textBoxPVOutputSystemID);
            this.groupBoxPVOutput.Controls.Add(this.labelPVOutputSystemID);
            this.groupBoxPVOutput.Location = new System.Drawing.Point(12, 139);
            this.groupBoxPVOutput.Name = "groupBoxPVOutput";
            this.groupBoxPVOutput.Size = new System.Drawing.Size(322, 124);
            this.groupBoxPVOutput.TabIndex = 6;
            this.groupBoxPVOutput.TabStop = false;
            this.groupBoxPVOutput.Text = "PVOutput.org";
            // 
            // labelPVOutputRequestURL
            // 
            this.labelPVOutputRequestURL.AutoSize = true;
            this.labelPVOutputRequestURL.Location = new System.Drawing.Point(6, 89);
            this.labelPVOutputRequestURL.Name = "labelPVOutputRequestURL";
            this.labelPVOutputRequestURL.Size = new System.Drawing.Size(73, 15);
            this.labelPVOutputRequestURL.TabIndex = 11;
            this.labelPVOutputRequestURL.Text = "Request URL";
            // 
            // textBoxPVOutputRequestURL
            // 
            this.textBoxPVOutputRequestURL.Location = new System.Drawing.Point(110, 86);
            this.textBoxPVOutputRequestURL.Name = "textBoxPVOutputRequestURL";
            this.textBoxPVOutputRequestURL.Size = new System.Drawing.Size(204, 23);
            this.textBoxPVOutputRequestURL.TabIndex = 10;
            // 
            // textBoxPVOutputAPIKey
            // 
            this.textBoxPVOutputAPIKey.Location = new System.Drawing.Point(110, 57);
            this.textBoxPVOutputAPIKey.Name = "textBoxPVOutputAPIKey";
            this.textBoxPVOutputAPIKey.Size = new System.Drawing.Size(204, 23);
            this.textBoxPVOutputAPIKey.TabIndex = 9;
            // 
            // labelPVOutputAPIKey
            // 
            this.labelPVOutputAPIKey.AutoSize = true;
            this.labelPVOutputAPIKey.Location = new System.Drawing.Point(6, 60);
            this.labelPVOutputAPIKey.Name = "labelPVOutputAPIKey";
            this.labelPVOutputAPIKey.Size = new System.Drawing.Size(49, 15);
            this.labelPVOutputAPIKey.TabIndex = 8;
            this.labelPVOutputAPIKey.Text = "API-Key";
            // 
            // textBoxPVOutputSystemID
            // 
            this.textBoxPVOutputSystemID.Location = new System.Drawing.Point(110, 28);
            this.textBoxPVOutputSystemID.Name = "textBoxPVOutputSystemID";
            this.textBoxPVOutputSystemID.Size = new System.Drawing.Size(204, 23);
            this.textBoxPVOutputSystemID.TabIndex = 7;
            // 
            // labelPVOutputSystemID
            // 
            this.labelPVOutputSystemID.AutoSize = true;
            this.labelPVOutputSystemID.Location = new System.Drawing.Point(6, 31);
            this.labelPVOutputSystemID.Name = "labelPVOutputSystemID";
            this.labelPVOutputSystemID.Size = new System.Drawing.Size(61, 15);
            this.labelPVOutputSystemID.TabIndex = 7;
            this.labelPVOutputSystemID.Text = "System-ID";
            // 
            // groupBoxLocalLogFile
            // 
            this.groupBoxLocalLogFile.Controls.Add(this.textBoxLogFileName);
            this.groupBoxLocalLogFile.Controls.Add(this.labelLogFileName);
            this.groupBoxLocalLogFile.Location = new System.Drawing.Point(12, 269);
            this.groupBoxLocalLogFile.Name = "groupBoxLocalLogFile";
            this.groupBoxLocalLogFile.Size = new System.Drawing.Size(322, 76);
            this.groupBoxLocalLogFile.TabIndex = 7;
            this.groupBoxLocalLogFile.TabStop = false;
            this.groupBoxLocalLogFile.Text = "Local log file";
            // 
            // textBoxLogFileName
            // 
            this.textBoxLogFileName.Location = new System.Drawing.Point(110, 28);
            this.textBoxLogFileName.Name = "textBoxLogFileName";
            this.textBoxLogFileName.Size = new System.Drawing.Size(204, 23);
            this.textBoxLogFileName.TabIndex = 7;
            // 
            // labelLogFileName
            // 
            this.labelLogFileName.AutoSize = true;
            this.labelLogFileName.Location = new System.Drawing.Point(6, 31);
            this.labelLogFileName.Name = "labelLogFileName";
            this.labelLogFileName.Size = new System.Drawing.Size(79, 15);
            this.labelLogFileName.TabIndex = 7;
            this.labelLogFileName.Text = "Log file name";
            // 
            // labelLogEntry
            // 
            this.labelLogEntry.AutoSize = true;
            this.labelLogEntry.Location = new System.Drawing.Point(371, 39);
            this.labelLogEntry.Name = "labelLogEntry";
            this.labelLogEntry.Size = new System.Drawing.Size(57, 15);
            this.labelLogEntry.TabIndex = 8;
            this.labelLogEntry.Text = "Log entry";
            // 
            // listBoxLogEntry
            // 
            this.listBoxLogEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLogEntry.FormattingEnabled = true;
            this.listBoxLogEntry.ItemHeight = 15;
            this.listBoxLogEntry.Location = new System.Drawing.Point(434, 36);
            this.listBoxLogEntry.Name = "listBoxLogEntry";
            this.listBoxLogEntry.Size = new System.Drawing.Size(245, 274);
            this.listBoxLogEntry.TabIndex = 9;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "GoodweLogger";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(434, 324);
            this.progressBar.Maximum = 1;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(246, 21);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 10;
            // 
            // textBoxBroadcastAddress
            // 
            this.textBoxBroadcastAddress.Location = new System.Drawing.Point(122, 64);
            this.textBoxBroadcastAddress.Name = "textBoxBroadcastAddress";
            this.textBoxBroadcastAddress.Size = new System.Drawing.Size(204, 23);
            this.textBoxBroadcastAddress.TabIndex = 12;
            // 
            // labelBroadcastAddress
            // 
            this.labelBroadcastAddress.AutoSize = true;
            this.labelBroadcastAddress.Location = new System.Drawing.Point(12, 67);
            this.labelBroadcastAddress.Name = "labelBroadcastAddress";
            this.labelBroadcastAddress.Size = new System.Drawing.Size(104, 15);
            this.labelBroadcastAddress.TabIndex = 11;
            this.labelBroadcastAddress.Text = "Broadcast Address";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 353);
            this.Controls.Add(this.textBoxBroadcastAddress);
            this.Controls.Add(this.labelBroadcastAddress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listBoxLogEntry);
            this.Controls.Add(this.labelLogEntry);
            this.Controls.Add(this.groupBoxLocalLogFile);
            this.Controls.Add(this.groupBoxPVOutput);
            this.Controls.Add(this.checkBoxStartStop);
            this.Controls.Add(this.textBoxLogInterval);
            this.Controls.Add(this.labelLogInterval);
            this.Controls.Add(this.textBoxHostAddress);
            this.Controls.Add(this.labelHostAddress);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "GoodweLogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxPVOutput.ResumeLayout(false);
            this.groupBoxPVOutput.PerformLayout();
            this.groupBoxLocalLogFile.ResumeLayout(false);
            this.groupBoxLocalLogFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Label labelHostAddress;
        private TextBox textBoxHostAddress;
        private Label labelLogInterval;
        private TextBox textBoxLogInterval;
        private CheckBox checkBoxStartStop;
        private GroupBox groupBoxPVOutput;
        private Label labelPVOutputRequestURL;
        private TextBox textBoxPVOutputRequestURL;
        private TextBox textBoxPVOutputAPIKey;
        private Label labelPVOutputAPIKey;
        private TextBox textBoxPVOutputSystemID;
        private Label labelPVOutputSystemID;
        private GroupBox groupBoxLocalLogFile;
        private TextBox textBoxLogFileName;
        private Label labelLogFileName;
        private Label labelLogEntry;
        private ListBox listBoxLogEntry;
        private ToolStripMenuItem versionToolStripMenuItem;
        private NotifyIcon notifyIcon;
        private ProgressBar progressBar;
        private TextBox textBoxBroadcastAddress;
        private Label labelBroadcastAddress;
    }
}
