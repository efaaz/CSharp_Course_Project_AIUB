using System;
using Restaurant_Management.Services;
using Restaurant_Management.Models;
using Restaurant_Management.Enums;
using System.Data;
using System.Windows.Forms;

namespace Restaurant_Management.Forms
{
    public partial class MenuManageForm : Form
    {
        DataTable menuData = new DataTable();

        public MenuManageForm()
        {
            InitializeComponent();
            ShowMenuInfo();
        }
        public void ShowMenuInfo()
        {
            MenuService menuService = new MenuService();
            menuData = menuService.GetAllMenuItems();
            dgMenuTable.DataSource = menuData;
            dgMenuTable.AutoGenerateColumns = true;
            dgMenuTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMenuTable.MultiSelect = false;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgMenuTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgMenuTable.SelectedRows[0].Cells[1].Value.ToString();
            txtPrice.Text = dgMenuTable.SelectedRows[0].Cells[2].Value.ToString();
            string status = dgMenuTable.SelectedRows[0].Cells [3].Value.ToString();
            if (status == "Available")
            {
                cbAvaibility.SelectedIndex = 0; 
            }
            if(status == "Unavailable")
            {
                cbAvaibility.SelectedIndex = 1;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || cbAvaibility.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            MenuService menuService = new MenuService();
            MenuItems menuItem = new MenuItems();



            menuItem.ItemName = txtName.Text;
            menuItem.ItemPrice = Convert.ToDouble(txtPrice.Text);

            if (cbAvaibility.Text == "Available")
            {
                menuItem.ItemStatus = ItemStatus.Available;
            }
            else if (cbAvaibility.Text == "Unavailable")
            {
                menuItem.ItemStatus = ItemStatus.Unavailable;
            }
           

            bool result = menuService.AddMenuItem(menuItem);
            if (!result)
            {
                MessageBox.Show(menuService.GetErrorMessage());
            }
            else
            {
                MessageBox.Show("Menu item added successfully.");
                ShowMenuInfo();
                txtName.Text = txtPrice.Text = "";
                cbAvaibility.SelectedIndex = -1;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrice.Text == "" || cbAvaibility.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Menu Item first");
                return;
            }

            MenuService menuService = new MenuService();
            MenuItems menuItem = new MenuItems();

            menuItem.ItemName = txtName.Text;
            menuItem.ItemPrice = Convert.ToDouble(txtPrice.Text);
            menuItem.ItemId = Convert.ToInt32(dgMenuTable.SelectedRows[0].Cells[0].Value);
            if (cbAvaibility.Text == "Available")
            {
                menuItem.ItemStatus = ItemStatus.Available;
            }
            else if (cbAvaibility.Text == "Unavailable")
            {
                menuItem.ItemStatus = ItemStatus.Unavailable;
            }
            bool result = menuService.UpdateMenuItem(menuItem);
            if (!result)
            {
                MessageBox.Show(menuService.GetErrorMessage());
            }
            else
            {
                MessageBox.Show("Menu item updated successfully.");
                ShowMenuInfo();
                txtName.Text = txtPrice.Text = "";
                cbAvaibility.SelectedIndex = -1;
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();

        }

        private void MenuManageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
