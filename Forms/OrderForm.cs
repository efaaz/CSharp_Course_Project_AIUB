using Restaurant_Management.Models;
using Restaurant_Management.Services;
using Restaurant_Management.Utilities;
using Restaurant_Management.Enums;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restaurant_Management.Forms
{
    public partial class OrderForm : Form
    {
        private DataTable selectedItemsTable = new DataTable();
        private DataTable menuItemsTable = new DataTable();
        private OrderItem[] orderItems = new OrderItem[30];
        

        private int itemCount = 0;
        public OrderForm()
        {
            InitializeComponent();
            ShowMenuItems();
            ShowOrderInfo();
            selectedItemsTable.Columns.Add("Item Name");
            selectedItemsTable.Columns.Add("Price");
            selectedItemsTable.Columns.Add("Quantity");
            selectedItemsTable.Columns.Add("Total");
            dgSelectedItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSelectedItems.MultiSelect = false;

            dgSelectedItems.DataSource = selectedItemsTable;
           
        }

        public void ShowOrderInfo()
        {
            txtUsername.Text = SessionManager.CurrentUser.Username;
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txtStatus.Text = OrderStatus.Pending.ToString();
        }

        public void ShowMenuItems()
        {
            MenuService menuService = new MenuService();

            menuItemsTable = menuService.GetAllMenuItems();

            dgMenuItems.AutoGenerateColumns = true;
            dgMenuItems.DataSource = menuItemsTable;
            dgMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMenuItems.MultiSelect = false;

        }

        private void ClearOrderForm()
        {
            // Clear selected-items DataTable
            selectedItemsTable.Rows.Clear();

            // Clear the array
            for (int i = 0; i < orderItems.Length; i++)
            {
                orderItems[i] = null;
            }

            // Reset item count
            itemCount = 0;

            // Reset total price
            txtTotalPrice.Text = "0";

            // Clear selected menu item textbox
            txtClickedItem.Clear();

            // Clear quantity textbox
            txtQuantity.Clear();

            // Clear table selection if needed
            cbSelectTable.SelectedIndex = -1;
        }
        public Decimal CalculateTotalPrice()
        {
            Decimal totalPrice = 0;
            for (int i = 0; i < itemCount; i++)
            {
                if (orderItems[i] == null)
                {
                    continue;
                }
                totalPrice += orderItems[i].Price;
            }
            return totalPrice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgMenuItems.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a menu item.");
                return;
            }
            int menuItemId = Convert.ToInt32(dgMenuItems.SelectedRows[0].Cells["ItemId"].Value);

            string itemName = dgMenuItems.SelectedRows[0].Cells["ItemName"].Value.ToString();

            decimal price = Convert.ToDecimal(dgMenuItems.SelectedRows[0].Cells["ItemPrice"].Value);



            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            int quantity = Convert.ToInt32(txtQuantity.Text);
            OrderItem item = new OrderItem();
            item.ItemId = menuItemId;
            item.Quantity = quantity;
            item.Price = price*quantity;


            // Store the object in the array
            orderItems[itemCount] = item;

            // Increase the number of actual items
            itemCount++;

            // Display the item in the selected-items grid
            selectedItemsTable.Rows.Add(
                itemName,
                price,
                quantity,
                price * quantity
            );

            decimal totalPrice = CalculateTotalPrice();
            txtTotalPrice.Text = totalPrice.ToString();

        }

        private void dgMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string itemname = dgMenuItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtClickedItem.Text = itemname;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dgSelectedItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Add items to the order.");
                return;
            }
            if (cbSelectTable.Text == "")
            {
                MessageBox.Show("Please select table first");
                return;
            };  
          
            OrderService orderService = new OrderService();
            Order order = new Order();
            order.TableId = Convert.ToInt32(cbSelectTable.Text);
            order.UserId = SessionManager.CurrentUser.UserId;
            order.Status = OrderStatus.Pending;
            order.OrderDate = DateTime.Now;
            order.TotalPrice = CalculateTotalPrice();
            order.Items = orderItems;

            MessageBox.Show("TableId: " + order.TableId + ", UserId: " + order.UserId +", Status: " + order.Status + ", OrderDate: " + order.OrderDate + ", TotalPrice: " + order.TotalPrice);
            bool result = orderService.PlaceOrder(order);
            if (!result)
            {
                MessageBox.Show("Order not placed. " + orderService.GetErrorMessage());
            }
            if (result)
            {
                MessageBox.Show("Order placed successfully.");
                ClearOrderForm();
            }
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

            if (dgSelectedItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a item to remove.");
                return;
            }
            int selectedRowId = dgSelectedItems.SelectedRows[0].Index;
            selectedItemsTable.Rows.RemoveAt(selectedRowId);
            orderItems[selectedRowId] = null;

            txtTotalPrice.Text = CalculateTotalPrice().ToString();
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


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgSelectedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
