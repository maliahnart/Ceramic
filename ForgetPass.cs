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
    public partial class ForgetPass : Form
    {
        public ForgetPass()
        {
            InitializeComponent();
            txt_Result.Text = "";
        }
        Modify modify = new Modify();
        private void btn_Recover_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            if(Email.Trim() == "")
            {
                MessageBox.Show("Please enter a email!");
            }
            else
            {
                string query = "Select * from Account where Email = '" + Email + "'";
                if (modify.Accounts(query).Count != 0)
                {
                    label1.ForeColor = Color.Red;
                    txt_Result.Text = "Password: " + modify.Accounts(query)[0].Password;
                }
                else
                {
                    label1.ForeColor = Color.Blue;
                    txt_Result.Text = "Email is not registered";
                }
            }
        }
    }
}
