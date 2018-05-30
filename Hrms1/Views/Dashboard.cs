using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hrms1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
            lblDay.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login m = new Login();
            m.Show();
            Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(sidebar.Width==50)
            {
                sidebar.Visible = false;
                sidebar.Width = 244;
                animator.ShowSync(sidebar);
            }
            else
            {
                sidebar.Visible = false;
                sidebar.Width = 50;
                animator.ShowSync(sidebar);
            }
        }
    }
}
