namespace GoodweLogger
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.textBoxHostAddress.Text = GoodweLogger.Properties.Settings.Default.hostAddress;
            this.textBoxLogInterval.Text = GoodweLogger.Properties.Settings.Default.logInterval.ToString();
            this.textBoxPVOutputSystemID.Text = GoodweLogger.Properties.Settings.Default.PVOutputSystemID;
            this.textBoxPVOutputAPIKey.Text = GoodweLogger.Properties.Settings.Default.PVOutputAPIKey;
            this.textBoxPVOutputRequestURL.Text = GoodweLogger.Properties.Settings.Default.PVOutputRequestURL;
            this.textBoxLogFileName.Text = GoodweLogger.Properties.Settings.Default.logfileName;
        }

        private void checkBoxStartStop_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxStartStop.Checked)
            {
                // start
                this.checkBoxStartStop.Text = "Stop";
            }
            else
            {
                // stop
                this.checkBoxStartStop.Text = "Start";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoodweLogger.Properties.Settings.Default.hostAddress = this.textBoxHostAddress.Text;
            GoodweLogger.Properties.Settings.Default.logInterval = Int32.Parse(this.textBoxLogInterval.Text);
            GoodweLogger.Properties.Settings.Default.PVOutputSystemID = this.textBoxPVOutputSystemID.Text;
            GoodweLogger.Properties.Settings.Default.PVOutputAPIKey = this.textBoxPVOutputAPIKey.Text;
            GoodweLogger.Properties.Settings.Default.PVOutputRequestURL = this.textBoxPVOutputRequestURL.Text;
            GoodweLogger.Properties.Settings.Default.logfileName = this.textBoxLogFileName.Text;
            Properties.Settings.Default.Save();
            Application.Exit();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {

            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
