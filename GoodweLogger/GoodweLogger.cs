using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodweLogger
{
    public partial class GoodweLogger : Form
    {
        public GoodweLogger()
        {
            InitializeComponent();
        }

         private void checkBoxStartStop_MouseClick(object sender, MouseEventArgs e)
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
