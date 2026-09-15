using Restaurant_Management.Forms;
using Restaurant_Management.Services;
using Restaurant_Management.Utilities;
using Restaurant_Management.Enums;
using System;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            txtUserName.Text = "Welcome , " + SessionManager.CurrentUser.Username;
            SetRolePermissions();
            ShowOrders();
            ShowPendingOrders();
            ShowPreparingOrders();
            ShowTotalOrders();
            ShowTotalSale();
        }

        private void SetRolePermissions()
        {
            UserRole role = SessionManager.CurrentUser.Role;

            if (role == UserRole.Chef)
            {
                btnTables.Visible = false;
                btnCreateOrder.Visible = false;
                btnBilling.Visible = false;
                btnReports.Visible = false;

                btnMenu.Visible  = true;
                btnKitchen.Visible = true;
            }
            else if (role == UserRole.Cashier)
            {
                btnMenu.Visible = true;
                btnTables.Visible = true;
                btnCreateOrder.Visible = true;
                btnBilling.Visible = true;
                btnReports.Visible = false;

                btnKitchen.Visible = false;
            }
            else if (role == UserRole.Manager)
            {
                btnMenu.Visible = true;
                btnTables.Visible = true;
                btnCreateOrder.Visible = true;
                btnKitchen.Visible = true;
                btnBilling.Visible = true;
                btnReports.Visible = true;
            }
        }

        public void ShowOrders()
        {
            DashBoardService dashBoardService = new DashBoardService();
            string orders = dashBoardService.GetOrders().ToString();
            if (orders == null) {
                MessageBox.Show(dashBoardService.GetErrorMassege());
            }
            txtOrders.Text = orders;
        }
        public void ShowTotalOrders()
        {
            DashBoardService dashBoardService = new DashBoardService();
            string TodaysOrders = dashBoardService.GetOrders().ToString();
            if (TodaysOrders == null)
            {
                MessageBox.Show(dashBoardService.GetErrorMassege());
            }
            txtTotalOrders.Text = TodaysOrders;
        }

        public void ShowPendingOrders()
        {
            DashBoardService dashBoardService = new DashBoardService();
            string pendings = dashBoardService.GetPendingOrders().ToString();
            if (pendings == null)
            {
                MessageBox.Show(dashBoardService.GetErrorMassege());
            }
            txtPending.Text = pendings;
        }

        public void ShowPreparingOrders()
        {
            DashBoardService dashBoardService = new DashBoardService();
            string preparing = dashBoardService.GetPreparingOrders().ToString();
            if (preparing == null)
            {
                MessageBox.Show(dashBoardService.GetErrorMassege());
            }
            txtPreparing.Text = preparing;
        }

        public void ShowTotalSale()
        {
            DashBoardService dashBoardService = new DashBoardService();
            string TotalSales = dashBoardService.GetTotalSales().ToString("0.00");
            if (TotalSales == null)
            {
                MessageBox.Show(dashBoardService.GetErrorMassege());
            }
            txtTotalSale.Text = "TK." + TotalSales;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPreparing_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuManageForm menuManageForm = new MenuManageForm();
            menuManageForm.Show();
            this.Hide();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            TableManageForm tableManageForm = new TableManageForm();
            tableManageForm.Show();
            this.Hide();

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            KitchenForm kitchenForm = new KitchenForm();
            kitchenForm.Show();
            this.Hide();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            BillingForm billingForm = new BillingForm();
            billingForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();
            this.Hide();

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
