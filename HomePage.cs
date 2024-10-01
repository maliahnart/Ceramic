using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cera
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_Signout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to sign out?", "Announce", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) { 
            this.Close();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            }
        }
    }
}
