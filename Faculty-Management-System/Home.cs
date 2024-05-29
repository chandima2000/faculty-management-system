using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void academic_Click(object sender, EventArgs e)
        {
            Academic academic = new Academic();
            academic.Show();
            this.Hide();
        }

        private void undergraduate_Click(object sender, EventArgs e)
        {
            Undergraduate ud = new Undergraduate();
            ud.Show();
            this.Hide();
        }

        private void non_academic_Click(object sender, EventArgs e)
        {
            non_academics na = new non_academics();
            na.Show();
            this.Hide();
        }

        private void users_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        private void department_Click(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void exit_login_form_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
    }

