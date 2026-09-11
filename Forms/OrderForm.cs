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
using System.Xml.Linq;

namespace Restaurant_Management.Forms
{
    public partial class OrderForm : Form
    {
        private DataTable selectedItemsTable = new DataTable();
        private DataTable menuItemsTable = new DataTable();
        public OrderForm()
        {
            InitializeComponent();
            selectedItemsTable.Columns.Add("Item Name");
            selectedItemsTable.Columns.Add("Price");
            selectedItemsTable.Columns.Add("Quantity");
            selectedItemsTable.Columns.Add("Total");

            dgSelectedItems.DataSource = selectedItemsTable;
            showMenuItems();
        }

        public void showMenuItems()
        {
            MenuService menuService = new MenuService();

            DataTable menuItemsTable = menuService.GetAllMenuItems();

            dgMenuItems.AutoGenerateColumns = true;
            dgMenuItems.DataSource = menuItemsTable;
            dgMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMenuItems.MultiSelect = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string itemname = dgMenuItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtClickedItem.Text = itemname;

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

        }

        private void dgSelectedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
