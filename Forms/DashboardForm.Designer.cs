namespace Restaurant_Management
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnOrderStatus = new System.Windows.Forms.Button();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblPreparing = new System.Windows.Forms.Label();
            this.lblOverallReport = new System.Windows.Forms.Label();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalsale = new System.Windows.Forms.Label();
            this.txtOrders = new System.Windows.Forms.TextBox();
            this.txtPending = new System.Windows.Forms.TextBox();
            this.txtPreparing = new System.Windows.Forms.TextBox();
            this.txtTotalOrders = new System.Windows.Forms.TextBox();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 580);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(440, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HOME PAGE";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(32, 71);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(144, 41);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTables
            // 
            this.btnTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.Location = new System.Drawing.Point(32, 129);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(144, 41);
            this.btnTables.TabIndex = 3;
            this.btnTables.Text = "Tables";
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(32, 190);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(144, 76);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderStatus.Location = new System.Drawing.Point(32, 281);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(144, 78);
            this.btnOrderStatus.TabIndex = 5;
            this.btnOrderStatus.Text = "Order Status";
            this.btnOrderStatus.UseVisualStyleBackColor = true;
            this.btnOrderStatus.Click += new System.EventHandler(this.btnOrderStatus_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.Location = new System.Drawing.Point(32, 379);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(144, 41);
            this.btnKitchen.TabIndex = 6;
            this.btnKitchen.Text = "Kitchen";
            this.btnKitchen.UseVisualStyleBackColor = true;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.Location = new System.Drawing.Point(32, 437);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(144, 41);
            this.btnBilling.TabIndex = 7;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(32, 494);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(144, 41);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(909, 94);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(165, 41);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(355, 94);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(423, 34);
            this.txtUserName.TabIndex = 10;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(374, 172);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(106, 29);
            this.lblOrders.TabIndex = 11;
            this.lblOrders.Text = "Orders : ";
            this.lblOrders.Click += new System.EventHandler(this.lblOrders_Click);
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.Location = new System.Drawing.Point(359, 232);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(121, 29);
            this.lblPending.TabIndex = 12;
            this.lblPending.Text = "Pending : ";
            this.lblPending.Click += new System.EventHandler(this.lblPending_Click);
            // 
            // lblPreparing
            // 
            this.lblPreparing.AutoSize = true;
            this.lblPreparing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparing.Location = new System.Drawing.Point(343, 291);
            this.lblPreparing.Name = "lblPreparing";
            this.lblPreparing.Size = new System.Drawing.Size(137, 29);
            this.lblPreparing.TabIndex = 13;
            this.lblPreparing.Text = "Preparing : ";
            this.lblPreparing.Click += new System.EventHandler(this.lblPreparing_Click);
            // 
            // lblOverallReport
            // 
            this.lblOverallReport.AutoSize = true;
            this.lblOverallReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallReport.Location = new System.Drawing.Point(465, 356);
            this.lblOverallReport.Name = "lblOverallReport";
            this.lblOverallReport.Size = new System.Drawing.Size(247, 36);
            this.lblOverallReport.TabIndex = 14;
            this.lblOverallReport.Text = "Overall Report : ";
            this.lblOverallReport.Click += new System.EventHandler(this.lblOverallReport_Click);
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(313, 414);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(167, 29);
            this.lblTotalOrders.TabIndex = 15;
            this.lblTotalOrders.Text = "Total Orders : ";
            this.lblTotalOrders.Click += new System.EventHandler(this.lblTotalOrders_Click);
            // 
            // lblTotalsale
            // 
            this.lblTotalsale.AutoSize = true;
            this.lblTotalsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalsale.Location = new System.Drawing.Point(339, 474);
            this.lblTotalsale.Name = "lblTotalsale";
            this.lblTotalsale.Size = new System.Drawing.Size(141, 29);
            this.lblTotalsale.TabIndex = 16;
            this.lblTotalsale.Text = "Total Sale : ";
            this.lblTotalsale.Click += new System.EventHandler(this.lblTotalsale_Click);
            // 
            // txtOrders
            // 
            this.txtOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrders.Location = new System.Drawing.Point(486, 172);
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.ReadOnly = true;
            this.txtOrders.Size = new System.Drawing.Size(226, 34);
            this.txtOrders.TabIndex = 17;
            this.txtOrders.TextChanged += new System.EventHandler(this.txtOrders_TextChanged);
            // 
            // txtPending
            // 
            this.txtPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPending.Location = new System.Drawing.Point(486, 232);
            this.txtPending.Name = "txtPending";
            this.txtPending.ReadOnly = true;
            this.txtPending.Size = new System.Drawing.Size(226, 34);
            this.txtPending.TabIndex = 18;
            this.txtPending.TextChanged += new System.EventHandler(this.txtPending_TextChanged);
            // 
            // txtPreparing
            // 
            this.txtPreparing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreparing.Location = new System.Drawing.Point(486, 291);
            this.txtPreparing.Name = "txtPreparing";
            this.txtPreparing.ReadOnly = true;
            this.txtPreparing.Size = new System.Drawing.Size(226, 34);
            this.txtPreparing.TabIndex = 19;
            this.txtPreparing.TextChanged += new System.EventHandler(this.txtPreparing_TextChanged);
            // 
            // txtTotalOrders
            // 
            this.txtTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrders.Location = new System.Drawing.Point(486, 414);
            this.txtTotalOrders.Name = "txtTotalOrders";
            this.txtTotalOrders.ReadOnly = true;
            this.txtTotalOrders.Size = new System.Drawing.Size(226, 34);
            this.txtTotalOrders.TabIndex = 20;
            this.txtTotalOrders.TextChanged += new System.EventHandler(this.txtTotalOrders_TextChanged);
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSale.Location = new System.Drawing.Point(486, 471);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(226, 34);
            this.txtTotalSale.TabIndex = 21;
            this.txtTotalSale.TextChanged += new System.EventHandler(this.txtTotalSale_TextChanged);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 580);
            this.Controls.Add(this.txtTotalSale);
            this.Controls.Add(this.txtTotalOrders);
            this.Controls.Add(this.txtPreparing);
            this.Controls.Add(this.txtPending);
            this.Controls.Add(this.txtOrders);
            this.Controls.Add(this.lblTotalsale);
            this.Controls.Add(this.lblTotalOrders);
            this.Controls.Add(this.lblOverallReport);
            this.Controls.Add(this.lblPreparing);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnBilling);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.btnOrderStatus);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnTables);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnOrderStatus;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblPreparing;
        private System.Windows.Forms.Label lblOverallReport;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalsale;
        private System.Windows.Forms.TextBox txtOrders;
        private System.Windows.Forms.TextBox txtPending;
        private System.Windows.Forms.TextBox txtPreparing;
        private System.Windows.Forms.TextBox txtTotalOrders;
        private System.Windows.Forms.TextBox txtTotalSale;
    }
}