using GoodweLib;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GoodweLogger
{
    public partial class MainForm : Form
    {
        private Worker worker;

        public MainForm()
        {
            InitializeComponent();

            this.textBoxHostAddress.Text = GoodweLogger.Properties.Settings.Default.hostAddress;
            this.textBoxBroadcastAddress.Text = GoodweLogger.Properties.Settings.Default.broadcastAddress;
            this.textBoxLogInterval.Text = GoodweLogger.Properties.Settings.Default.logInterval.ToString();
            this.textBoxPVOutputSystemID.Text = GoodweLogger.Properties.Settings.Default.PVOutputSystemID;
            this.textBoxPVOutputAPIKey.Text = GoodweLogger.Properties.Settings.Default.PVOutputAPIKey;
            this.textBoxPVOutputRequestURL.Text = GoodweLogger.Properties.Settings.Default.PVOutputRequestURL;
            this.textBoxLogFileName.Text = GoodweLogger.Properties.Settings.Default.logfileName;

            this.worker = new Worker(this);
        }

        private void CheckBoxStartStop_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxStartStop.Checked)
            {
                // start
                this.checkBoxStartStop.Text = "Stop";

                int logInterval = 300;
                this.worker.hostAddress = this.textBoxHostAddress.Text;
                this.worker.broadcastAddress = this.textBoxBroadcastAddress.Text;
                this.worker.PVOutputSystemID = this.textBoxPVOutputSystemID.Text;
                this.worker.PVOutputAPIKey = this.textBoxPVOutputAPIKey.Text;
                this.worker.PVOutputRequestURL = this.textBoxPVOutputRequestURL.Text;
                this.worker.logFilename = this.textBoxLogFileName.Text;
                Int32.TryParse(this.textBoxLogInterval.Text, out logInterval);
                this.worker.logInterval = logInterval;

                this.worker.loggingEnabled = true;

            }
            else
            {
                // stop
                this.checkBoxStartStop.Text = "Start";

                this.worker.loggingEnabled = false;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int interval=300;
            Int32.TryParse(this.textBoxLogInterval.Text, out interval);

            GoodweLogger.Properties.Settings.Default.hostAddress = this.textBoxHostAddress.Text;
            GoodweLogger.Properties.Settings.Default.broadcastAddress = this.textBoxBroadcastAddress.Text;
            GoodweLogger.Properties.Settings.Default.logInterval = interval;
            GoodweLogger.Properties.Settings.Default.PVOutputSystemID = this.textBoxPVOutputSystemID.Text;
            GoodweLogger.Properties.Settings.Default.PVOutputAPIKey = this.textBoxPVOutputAPIKey.Text;
            GoodweLogger.Properties.Settings.Default.PVOutputRequestURL = this.textBoxPVOutputRequestURL.Text;
            GoodweLogger.Properties.Settings.Default.logfileName = this.textBoxLogFileName.Text;
            Properties.Settings.Default.Save();

            this.worker.Close(5);

            System.Windows.Forms.Application.Exit();
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

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        public void WriteToLog(string text)
        {
            if (this.listBoxLogEntry.InvokeRequired)
            {
                this.listBoxLogEntry.Invoke((Action)delegate { WriteToLog(text); });
            }
            else
            {
                string[] lines = text.Split("\r\n");
                foreach (string line in lines)
                {
                    this.listBoxLogEntry.Items.Add(line);
                    if (this.listBoxLogEntry.Items.Count > 100)
                    {
                        listBoxLogEntry.Items.RemoveAt(0);
                    }
                    this.listBoxLogEntry.SelectedIndex = this.listBoxLogEntry.Items.Count - 1;
                }
            }
        }

        public void SetProgressBar(int value)
        {
            if (this.progressBar.InvokeRequired)
            {
                this.progressBar.Invoke((Action)delegate { SetProgressBar(value); });
            }
            else
            {
                this.progressBar.Value = value;
            }
        }
    }
}
