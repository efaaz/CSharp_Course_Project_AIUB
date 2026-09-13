using Restaurant_Management.Services;
using Restaurant_Management.Enums;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restaurant_Management.Forms
{
    public partial class KitchenForm : Form
    {
        private DataTable ordersdata = new DataTable();
        private DataTable itemsdata = new DataTable();
        public KitchenForm()
        {
            InitializeComponent();
            ShowOrders();
            itemsdata.Columns.Add("Item Name");
            itemsdata.Columns.Add("Quantity");
            dgItemTable.DataSource = itemsdata;
        }

        public void ShowOrders()
        { 
            KitchenService kitchenservice = new KitchenService();
            ordersdata = kitchenservice.GetAllOrders();
            dgOrdertable.DataSource = ordersdata;
            dgOrdertable.AutoGenerateColumns = true;
            dgOrdertable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrdertable.MultiSelect = false;
        }    

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }
        private void dgOrdertable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Please select a order item.");
                return;
            }
            
            txtOrderid.Text = dgOrdertable.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtStatus.Text = dgOrdertable.Rows[e.RowIndex].Cells[2].Value.ToString();

            KitchenService kitchenservice = new KitchenService();
            itemsdata = kitchenservice.GetOrderItems(Convert.ToInt32(txtOrderid.Text));
            dgItemTable.DataSource = itemsdata;

        }

        private void btnPreparing_Click(object sender, EventArgs e)
        {
            if (txtOrderid.Text == "")
            {
                MessageBox.Show("Please select a Order item.");
                return;
            }
            KitchenService kitchenservice = new KitchenService();
            bool result = kitchenservice.UpdateOrderStatus(Convert.ToInt32(txtOrderid.Text), OrderStatus.Preparing.ToString());
            if (!result)
            {
                MessageBox.Show(kitchenservice.getErrorMessage());
            }
            if (result)
            {
                MessageBox.Show("Order status updated to Preparing.");
                ShowOrders();
                txtOrderid.Text = "";
                txtStatus.Text = "";
            }
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            if (txtOrderid.Text == "")
            {
                MessageBox.Show("Please select a Order item.");
                return;
            }
            KitchenService kitchenservice = new KitchenService();
            bool result = kitchenservice.UpdateOrderStatus(Convert.ToInt32(txtOrderid.Text), OrderStatus.Ready.ToString());
            if (!result)
            {
                MessageBox.Show(kitchenservice.getErrorMessage());
            }
            if (result)
            {
                MessageBox.Show("Order status updated to Ready.");
                ShowOrders();
                txtOrderid.Text = "";
                txtStatus.Text = "";
                itemsdata.Rows.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowOrders();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtOrderid_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgItemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
