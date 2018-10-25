using System;
using System.Windows.Forms;

namespace Unturned_Uconomy_Utility
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Dispose();
            this.Dispose();
        }
    }
}
