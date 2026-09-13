using Restaurant_Management.Forms;
using Restaurant_Management.Models;
using Restaurant_Management.Services;
using Restaurant_Management.Utilities;
using System;
using System.Windows.Forms;

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
            string username = txt_username.Text;
            string password = txt_pass.Text;

            txt_error_username.Text = txt_error_pass.Text = "";

            if (username == "")
            {
                txt_error_username.Text = "Please enter username correctly";
            }
            if (password == "")
            {
                txt_error_pass.Text = "Please enter password correctly.";
            }
            if (username == "" || password == "")
            {
                return;
            }


            Authentication authService = new Authentication();

            User user = authService.Login(username, password);


            if (user != null)
            {
                SessionManager.SessionLogin(user);
                MessageBox.Show("Login successful! Welcome "+ SessionManager.CurrentUser.Username);

                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();

                this.Hide();

                
                //OrderForm orderForm = new OrderForm();
                //orderForm.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");

            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void TextErrorPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtErrorUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

        }
    }
}
