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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            txtPassword.PasswordChar = '•'; 
        }

        private void linkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPass forgetPass = new ForgetPass();
            forgetPass.ShowDialog();
        }

        private void btnSignUpC_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        Modify modify = new Modify();

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string Uname = txtUser.Text;
            string pass = txtPassword.Text;
            if (Uname.Trim() == "") { MessageBox.Show("Required enter username!"); }
            else if (pass.Trim() == "") { MessageBox.Show("Required enter password!"); }
            else
            {
                string query = "Select * from Account where Username = '" + Uname + "' and Password = '" + pass + "'";
                if (modify.Accounts(query).Count != 0)
                {
                    MessageBox.Show("Log in successfully!", "Announce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HomePage homePage = new HomePage();
                    homePage.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect.", "Announce", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            if (btn_showPass.Checked)
            {
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }
    }
}
