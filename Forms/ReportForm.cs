using Restaurant_Management.Services;
using Restaurant_Management.Models;
using System;
using System.Data;

using System.Windows.Forms;

namespace Restaurant_Management.Forms
{
    public partial class ReportForm : Form
    {
        DataTable recentPaymentData;
        public ReportForm()
        {
            InitializeComponent();
            GenerateSalesReport();
            GenerateRecentReport();
        }

        public void GenerateRecentReport()
        {
            ReportService reportService = new ReportService();
            recentPaymentData = reportService.GetRecentOrderPaymentDetails();
            dgPaymentTable.DataSource = recentPaymentData;

        }

        public void GenerateSalesReport()
        {
            ReportService reportService = new ReportService();
            Report report = reportService.GenerateSalesReport();
            txtTotalOrders.Text = report.TotalOrders.ToString();
            txtCompletedOrders.Text = report.TotalCompleteOrders.ToString();
            txtTotalSales.Text = report.TotalSales.ToString();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ReportService reportService = new ReportService();

            DateTime startDate = dtStartDate.Value;
            DateTime endDate = dtEndDate.Value;

            Report report = reportService.GenerateCustomSalesReport(startDate, endDate);
            txtTotalOrders.Text = report.TotalOrders.ToString();
            txtCompletedOrders.Text = report.TotalCompleteOrders.ToString();
            txtTotalSales.Text = report.TotalSales.ToString();



        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void dgOrderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
