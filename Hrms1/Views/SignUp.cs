using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hrms1.Controllers;


namespace Hrms1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
           
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {


        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string genderHolder = MaleBtn.Text;
            if (FemaleBtn.Checked == true)
                genderHolder = FemaleBtn.Text;
            else if (OthersBtn.Checked == true)
                genderHolder = OthersBtn.Text;

            Login log = new Login();
            EmployeesController employeesController = new EmployeesController();
            employeesController.Create(firstName.Text, lastName.Text,this.birthDate.Text, genderHolder.ToLower(),hireDate.Text,password.Text,emailAddr.Text);

            this.Hide();
            log.Show();

            }
    

        private void FemaleBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void middleName_Click(object sender, EventArgs e)
        {

        }
    }
}
