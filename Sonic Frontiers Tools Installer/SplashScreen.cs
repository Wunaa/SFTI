using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sonic_Frontiers_Tools_Installer
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            DialogResult result = MessageBox.Show("Make sure you have HedgeModManager installed before trying to use these tools", "Installer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes) ;
            {
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 7;
            if(panel3.Width >= 450)
            {
                timer1.Stop();
                Form1 f2 = new Form1();
                f2.Show();
                this.Hide();
            }
        }
    }
}
