using Restaurant_Management.Forms;
using Restaurant_Management.Services;
using Restaurant_Management.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            txtUserName.Text = "Welcome , " + SessionManager.CurrentUser.Username;
            ShowOrders();
            ShowPendingOrders();
            ShowPreparingOrders();
            ShowTotalOrders();
            ShowTotalSale();
        }

        public void ShowOrders()
        {
            DashBoardService dashBoardService = new DashBoardService();
            int orders = dashBoardService.GetOrders();
            txtOrders.Text = orders.ToString();
        }
        public void ShowTotalOrders()
        {
            DashBoardService dashBoardService = new DashBoardService();
            int TodaysOrders = dashBoardService.GetOrders();
            txtTotalOrders.Text = TodaysOrders.ToString();
        }

        public void ShowPendingOrders()
        {
            DashBoardService dashBoardService = new DashBoardService();
            int pendings = dashBoardService.GetPendingOrders();
            txtPending.Text = pendings.ToString();
        }

        public void ShowPreparingOrders()
        {
            DashBoardService dashBoardService = new DashBoardService();
            int preparing = dashBoardService.GetPreparingOrders();
            txtPreparing.Text = preparing.ToString();
        }

        public void ShowTotalSale()
        {
            DashBoardService dashBoardService = new DashBoardService();
            double TotalSales = dashBoardService.GetTotalSales();
            txtTotalSale.Text = "TK." + TotalSales.ToString("0.00");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPreparing_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnTables_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            KitchenForm kitchenForm = new KitchenForm();
            kitchenForm.Show();
            this.Hide();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOrders_Click(object sender, EventArgs e)
        {

        }

        private void txtOrders_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPending_Click(object sender, EventArgs e)
        {

        }

        private void txtPending_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreparing_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOverallReport_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalOrders_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalOrders_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalsale_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalSale_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Logged Out.");
            SessionManager.Logout();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();   
        }
    }
}
