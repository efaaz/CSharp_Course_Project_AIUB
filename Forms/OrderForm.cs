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
        private DataTable selectedItemsData = new DataTable();
        private DataTable menuItemsData = new DataTable();
        private DataTable tableInfoData = new DataTable();
        private OrderItem[] orderItemsArray = new OrderItem[30];
        

        private int itemCount = 0;
        public OrderForm()
        {
            InitializeComponent();
            ShowMenuItems();
            ShowOrderInfo();
            ShowTableInfo();
            selectedItemsData.Columns.Add("Item Name");
            selectedItemsData.Columns.Add("Price");
            selectedItemsData.Columns.Add("Quantity");
            selectedItemsData.Columns.Add("Total");
            dgSelectedItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgSelectedItems.MultiSelect = false;

            dgSelectedItems.DataSource = selectedItemsData;
             

        }

        public void ShowTableInfo()
        {
            OrderService orderService = new OrderService();
            tableInfoData = orderService.GetTableInfo();
            dgTableInfo.AutoGenerateColumns = true;
            dgTableInfo.DataSource = tableInfoData;
            dgTableInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgTableInfo.MultiSelect = false;
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

            menuItemsData = menuService.GetAllMenuItems();

            dgMenuItems.AutoGenerateColumns = true;
            dgMenuItems.DataSource = menuItemsData;
            dgMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgMenuItems.MultiSelect = false;

        }

        private void ClearOrderForm()
        {
            selectedItemsData.Rows.Clear();

            for (int i = 0; i < orderItemsArray.Length; i++)
            {
                orderItemsArray[i] = null;
            }

            itemCount = 0;
            txtTotalPrice.Text = "0";
            txtClickedItem.Text = "";
            txtQuantity.Text = "";
            txtSelectTableId.Text = "";
            ShowTableInfo();
        }
        public Decimal CalculateTotalPrice()
        {
            Decimal totalPrice = 0;
            for (int i = 0; i < itemCount; i++)
            {
                if (orderItemsArray[i] == null)
                {
                    continue;
                }
                totalPrice += orderItemsArray[i].Price;
            }
            return totalPrice;
        }

        private void dgMenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Please select a menu item.");
                return;
            }

            string itemname = dgMenuItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtClickedItem.Text = itemname;

        }
        private void btnAddItem_Click(object sender, EventArgs e)
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


            orderItemsArray[itemCount] = item;
            itemCount++;
            selectedItemsData.Rows.Add(
                itemName,
                price,
                quantity,
                price * quantity
            );

            decimal totalPrice = CalculateTotalPrice();
            txtTotalPrice.Text = totalPrice.ToString();

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

            if (dgSelectedItems.SelectedRows.Count <= 0 || dgSelectedItems.SelectedRows[0].Index <0)
            {
                MessageBox.Show("Please select a item to remove.");
                return;
            }
            
            int selectedRowId = dgSelectedItems.SelectedRows[0].Index;

            if (selectedRowId >= selectedItemsData.Rows.Count)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }
            selectedItemsData.Rows.RemoveAt(selectedRowId);
            orderItemsArray[selectedRowId] = null;

            txtTotalPrice.Text = CalculateTotalPrice().ToString();
        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (selectedItemsData.Rows.Count == 0)
            {
                MessageBox.Show("Please Add items to the order.");
                return;
            }
            if (txtSelectTableId.Text == "")
            {
                MessageBox.Show("Please select table first");
                return;
            };  
          
            OrderService orderService = new OrderService();
            Order order = new Order();
            order.TableId = Convert.ToInt32(txtSelectTableId.Text);
            order.UserId = SessionManager.CurrentUser.UserId;
            order.Status = OrderStatus.Pending;
            order.OrderDate = DateTime.Now;
            order.TotalPrice = CalculateTotalPrice();
            order.Items = orderItemsArray;

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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void txtSelectTableId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgTableInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Please select a table item.");
                return;
            }

            string tableId = dgTableInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSelectTableId.Text = tableId;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
