using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Managment
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {

        }
        private void Timer_PrgBar_Tick(object sender, EventArgs e)
        {
            if (circularProgressBar1.Value != 100)
            {
                circularProgressBar1.Value = circularProgressBar1.Value + 2;
            }
            else
            {
                Timer_PrgBar.Enabled = false;
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    Timer_PrgBar.Enabled = false;
                    Login h1 = new Login();
                    this.Hide();
                    h1.Show();
                }
                else
                {
                    MessageBox.Show("You are Dis-connected");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}