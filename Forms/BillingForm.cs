using Restaurant_Management.Models;
using Restaurant_Management.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restaurant_Management.Forms
{
    public partial class BillingForm : Form
    {
        private DataTable OrderData = new DataTable();
        private DataTable ItemData = new DataTable();
        private int orderId;
        private int tableId;
        public BillingForm()
        {
            InitializeComponent();
            ShowTableDetails();
            ItemData.Columns.Add("Item Name");
            ItemData.Columns.Add("Price");
            ItemData.Columns.Add("Quentity");
            ItemData.Columns.Add("Total");
            dgItemDetails.DataSource = ItemData;
        }

        public void ShowTableDetails() {
            BillingService billingService = new BillingService();
            OrderData = billingService.GetOrderDetails();
            dgOrderDetails.DataSource = OrderData;
            dgOrderDetails.AutoGenerateColumns = true;
            dgOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgOrderDetails.MultiSelect = false;
        }

        public double GetSubTotal()
        {
            double subTotal = 0;

            foreach (DataRow row in ItemData.Rows)
            {
                if (row[3] != null)
                {
                    subTotal += Convert.ToDouble(row[3]);
                }
            }

            return subTotal;
        }

        public double GetserviceCharge() {
            double serviceCharge = 0;
            double serviceChargePercent = 0.10;
            serviceCharge = GetSubTotal() * serviceChargePercent;
            return serviceCharge;
        }

        public double GetVat()
        {
            double vat = 0;
            double vatPercent = 0.05;
            vat = GetSubTotal() * vatPercent;
            return vat;
        }

        public double GetGrandTotal() { 
            double grandTotal = 0;
            grandTotal = GetSubTotal() + GetserviceCharge() + GetVat() ;
            return grandTotal;
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblServiceCharge_Click(object sender, EventArgs e)
        {

        }

        private void txtServiceCharge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVat_Click(object sender, EventArgs e)
        {

        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGrandTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaymentMethod_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            PaymentDetails paymentDetails = new PaymentDetails();
            paymentDetails.OrderId = orderId;
            if (cbPaymentMethod.Text == "") 
            {
                MessageBox.Show("Please Select Payment Method!");
                return;
            }

            paymentDetails.PaymentMethod = cbPaymentMethod.Text;
            paymentDetails.ServiceCharge = Convert.ToDouble(txtServiceCharge.Text);
            paymentDetails.Vat = Convert.ToDouble(txtVat.Text);
            paymentDetails.TotalAmount = Convert.ToDouble(txtGrandTotal.Text);
            paymentDetails.TableId = tableId;
            BillingService service = new BillingService();
            bool result = service.GenerateBill(paymentDetails);
            if (!result)
            {
                MessageBox.Show(service.GetErrorMessage());
            }
            else
            {
                MessageBox.Show("Bill Generated Successfully.");
                txtSubtotal.Text = txtServiceCharge.Text = txtVat.Text = txtGrandTotal.Text = "";
                ItemData.Rows.Clear();
                ShowTableDetails();
            }

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void cbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblOrderDetails_Click(object sender, EventArgs e)
        {

        }

        private void dgOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) {
                MessageBox.Show("Enter a valid row!");
                return;
            }
            orderId = Convert.ToInt32(dgOrderDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
            tableId = Convert.ToInt32(dgOrderDetails.Rows[e.RowIndex].Cells[1].Value.ToString());
            BillingService billingService = new BillingService();
            ItemData = billingService.GetItemDetails(orderId);
            dgItemDetails.DataSource = ItemData;
            txtSubtotal.Text = GetSubTotal().ToString("0.00");
            txtServiceCharge.Text = GetserviceCharge().ToString("0.00");
            txtVat.Text = GetVat().ToString("0.00");
            txtGrandTotal.Text = GetGrandTotal().ToString("0.00");

        }

        private void lblItemDetails_Click(object sender, EventArgs e)
        {

        }

        private void dgItemDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
