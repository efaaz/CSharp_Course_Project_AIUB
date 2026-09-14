using Restaurant_Management.Services;
using Restaurant_Management.Models;
using Restaurant_Management.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.Models;

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
            TableService tableService = new TableService();
            RestaurantTable table = new RestaurantTable();

            if(txtStatus.Text != "Available" && txtStatus.Text != "Occupied")
            {
                MessageBox.Show("Invalid table status. Please enter 'Available' or 'Occupied'.");
                return;
            }

            table.TableNumber = Convert.ToInt32(txtNumber.Text);
            table.Capacity = Convert.ToInt32(txtCapacity.Text);
            if (txtStatus.Text == "Available")
            {
                table.TableStatus = TableStatus.Available;
            }
            else if (txtStatus.Text == "Occupied")
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
                txtStatus.Text = txtNumber.Text = txtCapacity.Text = "";
            }



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TableService tableService = new TableService();
            RestaurantTable table = new RestaurantTable();


            if (txtStatus.Text != "Available" && txtStatus.Text != "Occupied")
            {
                MessageBox.Show("Invalid table status. Please enter 'Available' or 'Occupied'.");
                return;
            }
            table.TableId = tableId;
            table.TableNumber = Convert.ToInt32(txtNumber.Text);
            table.Capacity = Convert.ToInt32(txtCapacity.Text);
            if (txtStatus.Text == "Available")
            {
                table.TableStatus = TableStatus.Available;
            }
            else if (txtStatus.Text == "Occupied")
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
                txtStatus.Text = txtNumber.Text = txtCapacity.Text = "";
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
                txtStatus.Text = dgTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
