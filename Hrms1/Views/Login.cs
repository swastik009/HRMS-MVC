using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hrms1.Models;
using Configuration;
using Hrms1.Controllers;
namespace Hrms1
{
    public partial class Login : Form
    {
        public Login()
        {
           
            
            InitializeComponent();
            
            Checker();
            

        }

        public void Checker()
        {
            ConfigRepo Checker = new ConfigRepo();
            Employee empTableName = new Employee();

            if (Checker.CheckDataExist(empTableName.table_name) == 0)
            {
                signUp.Visible = true;
                signUpLabel.Visible = true;
            }

            else
            {
                signUp.Visible = false;
                signUpLabel.Visible = false;
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (emailAddr.Text == "Email address")
                emailAddr.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (emailAddr.Text == "")
                emailAddr.Text = "Email address";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
                password.Text = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
                password.Text = "Password";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void getANewID(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();

            this.Hide();
            signup.Closed += (s, args) => this.Close();
            signup.Show();


        }



        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            signInController validator = new signInController();
            validator.LoginAuth(emailAddr.Text, password.Text);

        }
    }
}
