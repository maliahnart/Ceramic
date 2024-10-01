using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Cera
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void btn_Signup_Click(object sender, EventArgs e)
        {
            string Uname = txtUser.Text;
            string Pass = txtPassword.Text;
            string Confirm = txtConfirm.Text;
            string Email = txtEmail.Text;
            if (!CheckAccount(Uname)) 
            {
                MessageBox.Show("Please enter your account name from 6-24 characters, with numbers, uppercase and lowercase letters."); return;
            }
            if (!CheckAccount(Pass))
            {
                MessageBox.Show("Please enter your password from 6-24 characters, with numbers, uppercase and lowercase letters."); return;
            }
            if(Confirm != Pass)
            {
                MessageBox.Show("Please confirm correct password."); return;
            }
            if (!CheckEmail(Email))
            {
                MessageBox.Show("Please enter the correct email format."); return ;
            }
            if(modify.Accounts("Select * from Account where Email = '" + Email + "'").Count != 0){
                MessageBox.Show("Email already used, please try another email."); return;
            }
            try
            {
                string query = "Insert into Account values ('"+Uname+"', '"+Pass+"','"+Email+"')";
                modify.Command(query);
                if (MessageBox.Show("Registered successfully, do you want to log in?", "Announce", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) { 
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("The account name is now available.");
            }
        }
    }
}
