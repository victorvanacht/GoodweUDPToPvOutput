namespace GoodweLogger1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
