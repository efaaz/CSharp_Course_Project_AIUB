using Restaurant_Management.Services;
using Restaurant_Management.Models;
using Restaurant_Management.Enums;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restaurant_Management.Forms
{
    public partial class TableManageForm : Form
    {
        private DataTable TableInfoData;
        private int tableId;
        public TableManageForm()
        {
            InitializeComponent();
            ShowTableInfo();
        }

        public void ShowTableInfo() { 
            TableService tableService = new TableService();
            TableInfoData = tableService.GetTableInfo();
            dgTable.DataSource = TableInfoData;
            dgTable.AutoGenerateColumns = true;
            dgTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTable.MultiSelect = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNumber.Text == "" || txtCapacity.Text == "" || cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }
            TableService tableService = new TableService();
            RestaurantTable table = new RestaurantTable();
            table.TableNumber = Convert.ToInt32(txtNumber.Text);
            table.Capacity = Convert.ToInt32(txtCapacity.Text);
            if (cbStatus.Text == "Available")
            {
                table.TableStatus = TableStatus.Available;
            }
            else if (cbStatus.Text == "Occupied")
            {
                table.TableStatus = TableStatus.Occupied;
            }

            bool result = tableService.AddTable(table);
            if (!result)
            {
                MessageBox.Show(tableService.GetErrorMessage());
            }
            else
            {
                MessageBox.Show("Table added successfully.");
                ShowTableInfo();
                txtNumber.Text = txtCapacity.Text = "";
                cbStatus.SelectedIndex = -1;
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            TableService tableService = new TableService();
            RestaurantTable table = new RestaurantTable();
            if (txtNumber.Text == "" || txtCapacity.Text == "" || cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select an Item first");
                return;
            }

            table.TableId = tableId;
            table.TableNumber = Convert.ToInt32(txtNumber.Text);
            table.Capacity = Convert.ToInt32(txtCapacity.Text);
            if (cbStatus.Text == "Available")
            {
                table.TableStatus = TableStatus.Available;
            }
            else if (cbStatus.Text == "Occupied")
            {
                table.TableStatus = TableStatus.Occupied;
            }

            bool result = tableService.UpdateTableInfo(table);
            if (!result)
            {
                MessageBox.Show(tableService.GetErrorMessage());
            }
            else
            {
                MessageBox.Show("Table updated successfully.");
                ShowTableInfo();
                txtNumber.Text = txtCapacity.Text = "";
                cbStatus.SelectedIndex = -1;
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void dgTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgTable.Rows[e.RowIndex];
                tableId = Convert.ToInt32(dgTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNumber.Text = dgTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCapacity.Text = dgTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                string status = dgTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (status == "Available")
                {
                    cbStatus.SelectedIndex = 0;
                }
                if (status == "Occupied")
                {
                    cbStatus.SelectedIndex = 1;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
