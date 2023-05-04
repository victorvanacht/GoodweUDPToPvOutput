namespace GoodweLogger
{
    partial class GoodweLogger
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
            this.labelLogFilename = new System.Windows.Forms.Label();
            this.labelHostAddress = new System.Windows.Forms.Label();
            this.textBoxHostAddress = new System.Windows.Forms.TextBox();
            this.textBoxLogFilename = new System.Windows.Forms.TextBox();
            this.groupBoxLocalLogFile = new System.Windows.Forms.GroupBox();
            this.groupBoxPVOutput = new System.Windows.Forms.GroupBox();
            this.labelPVOutputRequestURL = new System.Windows.Forms.Label();
            this.textBoxPVOutputRequestURL = new System.Windows.Forms.TextBox();
            this.textBoxPVOutputAPIKey = new System.Windows.Forms.TextBox();
            this.labelPVOutputAPIKey = new System.Windows.Forms.Label();
            this.textBoxPVOutputSystemID = new System.Windows.Forms.TextBox();
            this.labelPVOutputSystemID = new System.Windows.Forms.Label();
            this.labelLogInterval = new System.Windows.Forms.Label();
            this.textBoxLogInterval = new System.Windows.Forms.TextBox();
            this.listBoxLogEntry = new System.Windows.Forms.ListBox();
            this.labelLogEntry = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLocalLogFile.SuspendLayout();
            this.groupBoxPVOutput.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogFilename
            // 
            this.labelLogFilename.AutoSize = true;
            this.labelLogFilename.Location = new System.Drawing.Point(11, 38);
            this.labelLogFilename.Name = "labelLogFilename";
            this.labelLogFilename.Size = new System.Drawing.Size(70, 13);
            this.labelLogFilename.TabIndex = 0;
            this.labelLogFilename.Text = "Log Filename";
            // 
            // labelHostAddress
            // 
            this.labelHostAddress.AutoSize = true;
            this.labelHostAddress.Location = new System.Drawing.Point(10, 44);
            this.labelHostAddress.Name = "labelHostAddress";
            this.labelHostAddress.Size = new System.Drawing.Size(70, 13);
            this.labelHostAddress.TabIndex = 1;
            this.labelHostAddress.Text = "Host Address";
            // 
            // textBoxHostAddress
            // 
            this.textBoxHostAddress.Location = new System.Drawing.Point(98, 41);
            this.textBoxHostAddress.Name = "textBoxHostAddress";
            this.textBoxHostAddress.Size = new System.Drawing.Size(166, 20);
            this.textBoxHostAddress.TabIndex = 2;
            // 
            // textBoxLogFilename
            // 
            this.textBoxLogFilename.Location = new System.Drawing.Point(88, 35);
            this.textBoxLogFilename.Name = "textBoxLogFilename";
            this.textBoxLogFilename.Size = new System.Drawing.Size(166, 20);
            this.textBoxLogFilename.TabIndex = 3;
            // 
            // groupBoxLocalLogFile
            // 
            this.groupBoxLocalLogFile.Controls.Add(this.textBoxLogFilename);
            this.groupBoxLocalLogFile.Controls.Add(this.labelLogFilename);
            this.groupBoxLocalLogFile.Location = new System.Drawing.Point(10, 270);
            this.groupBoxLocalLogFile.Name = "groupBoxLocalLogFile";
            this.groupBoxLocalLogFile.Size = new System.Drawing.Size(267, 72);
            this.groupBoxLocalLogFile.TabIndex = 4;
            this.groupBoxLocalLogFile.TabStop = false;
            this.groupBoxLocalLogFile.Text = "Local log file";
            // 
            // groupBoxPVOutput
            // 
            this.groupBoxPVOutput.Controls.Add(this.labelPVOutputRequestURL);
            this.groupBoxPVOutput.Controls.Add(this.textBoxPVOutputRequestURL);
            this.groupBoxPVOutput.Controls.Add(this.textBoxPVOutputAPIKey);
            this.groupBoxPVOutput.Controls.Add(this.labelPVOutputAPIKey);
            this.groupBoxPVOutput.Controls.Add(this.textBoxPVOutputSystemID);
            this.groupBoxPVOutput.Controls.Add(this.labelPVOutputSystemID);
            this.groupBoxPVOutput.Location = new System.Drawing.Point(10, 126);
            this.groupBoxPVOutput.Name = "groupBoxPVOutput";
            this.groupBoxPVOutput.Size = new System.Drawing.Size(267, 110);
            this.groupBoxPVOutput.TabIndex = 5;
            this.groupBoxPVOutput.TabStop = false;
            this.groupBoxPVOutput.Text = "PVOutput.org";
            // 
            // labelPVOutputRequestURL
            // 
            this.labelPVOutputRequestURL.AutoSize = true;
            this.labelPVOutputRequestURL.Location = new System.Drawing.Point(6, 77);
            this.labelPVOutputRequestURL.Name = "labelPVOutputRequestURL";
            this.labelPVOutputRequestURL.Size = new System.Drawing.Size(72, 13);
            this.labelPVOutputRequestURL.TabIndex = 9;
            this.labelPVOutputRequestURL.Text = "Request URL";
            // 
            // textBoxPVOutputRequestURL
            // 
            this.textBoxPVOutputRequestURL.Location = new System.Drawing.Point(88, 74);
            this.textBoxPVOutputRequestURL.Name = "textBoxPVOutputRequestURL";
            this.textBoxPVOutputRequestURL.Size = new System.Drawing.Size(166, 20);
            this.textBoxPVOutputRequestURL.TabIndex = 8;
            // 
            // textBoxPVOutputAPIKey
            // 
            this.textBoxPVOutputAPIKey.Location = new System.Drawing.Point(88, 48);
            this.textBoxPVOutputAPIKey.Name = "textBoxPVOutputAPIKey";
            this.textBoxPVOutputAPIKey.Size = new System.Drawing.Size(166, 20);
            this.textBoxPVOutputAPIKey.TabIndex = 7;
            // 
            // labelPVOutputAPIKey
            // 
            this.labelPVOutputAPIKey.AutoSize = true;
            this.labelPVOutputAPIKey.Location = new System.Drawing.Point(6, 51);
            this.labelPVOutputAPIKey.Name = "labelPVOutputAPIKey";
            this.labelPVOutputAPIKey.Size = new System.Drawing.Size(45, 13);
            this.labelPVOutputAPIKey.TabIndex = 6;
            this.labelPVOutputAPIKey.Text = "API-Key";
            // 
            // textBoxPVOutputSystemID
            // 
            this.textBoxPVOutputSystemID.Location = new System.Drawing.Point(88, 22);
            this.textBoxPVOutputSystemID.Name = "textBoxPVOutputSystemID";
            this.textBoxPVOutputSystemID.Size = new System.Drawing.Size(166, 20);
            this.textBoxPVOutputSystemID.TabIndex = 1;
            // 
            // labelPVOutputSystemID
            // 
            this.labelPVOutputSystemID.AutoSize = true;
            this.labelPVOutputSystemID.Location = new System.Drawing.Point(6, 25);
            this.labelPVOutputSystemID.Name = "labelPVOutputSystemID";
            this.labelPVOutputSystemID.Size = new System.Drawing.Size(55, 13);
            this.labelPVOutputSystemID.TabIndex = 0;
            this.labelPVOutputSystemID.Text = "System-ID";
            // 
            // labelLogInterval
            // 
            this.labelLogInterval.AutoSize = true;
            this.labelLogInterval.Location = new System.Drawing.Point(10, 81);
            this.labelLogInterval.Name = "labelLogInterval";
            this.labelLogInterval.Size = new System.Drawing.Size(76, 13);
            this.labelLogInterval.TabIndex = 6;
            this.labelLogInterval.Text = "Log interval (s)";
            // 
            // textBoxLogInterval
            // 
            this.textBoxLogInterval.Location = new System.Drawing.Point(98, 78);
            this.textBoxLogInterval.Name = "textBoxLogInterval";
            this.textBoxLogInterval.Size = new System.Drawing.Size(44, 20);
            this.textBoxLogInterval.TabIndex = 7;
            // 
            // listBoxLogEntry
            // 
            this.listBoxLogEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLogEntry.FormattingEnabled = true;
            this.listBoxLogEntry.Location = new System.Drawing.Point(424, 41);
            this.listBoxLogEntry.Name = "listBoxLogEntry";
            this.listBoxLogEntry.Size = new System.Drawing.Size(187, 303);
            this.listBoxLogEntry.TabIndex = 8;
            // 
            // labelLogEntry
            // 
            this.labelLogEntry.AutoSize = true;
            this.labelLogEntry.Location = new System.Drawing.Point(367, 41);
            this.labelLogEntry.Name = "labelLogEntry";
            this.labelLogEntry.Size = new System.Drawing.Size(51, 13);
            this.labelLogEntry.TabIndex = 9;
            this.labelLogEntry.Text = "Log entry";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 10;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // GoodweLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 353);
            this.Controls.Add(this.labelLogEntry);
            this.Controls.Add(this.listBoxLogEntry);
            this.Controls.Add(this.textBoxLogInterval);
            this.Controls.Add(this.labelLogInterval);
            this.Controls.Add(this.groupBoxPVOutput);
            this.Controls.Add(this.groupBoxLocalLogFile);
            this.Controls.Add(this.textBoxHostAddress);
            this.Controls.Add(this.labelHostAddress);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GoodweLogger";
            this.Text = "Form1";
            this.groupBoxLocalLogFile.ResumeLayout(false);
            this.groupBoxLocalLogFile.PerformLayout();
            this.groupBoxPVOutput.ResumeLayout(false);
            this.groupBoxPVOutput.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogFilename;
        private System.Windows.Forms.Label labelHostAddress;
        private System.Windows.Forms.TextBox textBoxHostAddress;
        private System.Windows.Forms.TextBox textBoxLogFilename;
        private System.Windows.Forms.GroupBox groupBoxLocalLogFile;
        private System.Windows.Forms.GroupBox groupBoxPVOutput;
        private System.Windows.Forms.Label labelPVOutputAPIKey;
        private System.Windows.Forms.TextBox textBoxPVOutputSystemID;
        private System.Windows.Forms.Label labelPVOutputSystemID;
        private System.Windows.Forms.TextBox textBoxPVOutputAPIKey;
        private System.Windows.Forms.Label labelPVOutputRequestURL;
        private System.Windows.Forms.TextBox textBoxPVOutputRequestURL;
        private System.Windows.Forms.Label labelLogInterval;
        private System.Windows.Forms.TextBox textBoxLogInterval;
        private System.Windows.Forms.ListBox listBoxLogEntry;
        private System.Windows.Forms.Label labelLogEntry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
    }
}

