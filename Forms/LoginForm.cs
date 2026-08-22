using Restaurant_Management.Models;
using Restaurant_Management.Utilities;
using Restaurant_Management.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Restaurant_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();
            string password = txt_pass.Text.Trim();
            if (ValidationHelper.IsEmpty(email) ||
                   ValidationHelper.IsEmpty(password))
            {
                MessageBox.Show("Please enter email and password correctly.");
                return;
            }

            Authentication authService = new Authentication();

            User user = authService.Login(email, password);

            if (user != null)
            {
                SessionManager.CurrentUser = user;

                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
