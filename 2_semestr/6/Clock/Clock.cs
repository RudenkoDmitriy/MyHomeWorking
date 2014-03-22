using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class clockForm : Form
    {
        public clockForm()
        {
            InitializeComponent();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.clockLabel.Text = DateTime.Now.ToString();
        }
    }
}
