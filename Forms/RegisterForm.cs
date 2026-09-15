using Restaurant_Management.Enums;
using Restaurant_Management.Models;
using Restaurant_Management.Services;
using Restaurant_Management.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management.Forms
{
    public partial class RegisterForm : Form
    {
        string name, email, role, pass;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorName_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorRole_Click(object sender, EventArgs e)
        {

        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            name = txtName.Text.Trim();
            email = txtEmail.Text.Trim();
            role = cbRole.Text.Trim();
            pass = txtPass.Text.Trim();

            lblErrorName.Text = lblErrorEmail.Text = lblErrorRole.Text = lblErrorPass.Text = "";
            if (name == "")
            {
                lblErrorName.Text = "Please Enter Your Name!";
            }
            if (email == "")
            {
                lblErrorEmail.Text = "Please Enter Your Email!";
            }
            if (!email.EndsWith("@gmail.com") && !email.EndsWith("@email.com")) 
            {
                lblErrorEmail.Text = "Enter Valid Email";
                return;
            }
            if (role == "")
            {
                lblErrorRole.Text = "Please Enter Select Your Role!";
            }
            if (pass.Length < 8)
            {
                lblErrorPass.Text = "Please Enter A Strong Password!";
            }
            if (name == "" || email == "" || role == "" || pass.Length < 8 )
            {
                return;
            }
          

           User user = new User();
            user.Username = name;
            user.Email = email;
            if (role == "Manager")
            {
                user.Role = UserRole.Manager;
            }
            if (role == "Cashier")
            {
                user.Role = UserRole.Cashier;
            }
            if (role == "Chef")
            {
                user.Role = UserRole.Chef;
            }
            user.Password = pass;
            Authentication service = new Authentication();
            service.Register(user);

            MessageBox.Show("Registration Successfull.");

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}

    
