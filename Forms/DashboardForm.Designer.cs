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
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 906);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(660, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(429, 73);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "HOME PAGE";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(48, 253);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(326, 81);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Manage Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnTables
            // 
            this.btnTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.Location = new System.Drawing.Point(48, 374);
            this.btnTables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(326, 85);
            this.btnTables.TabIndex = 3;
            this.btnTables.Text = "Manage Tables";
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(48, 147);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(326, 71);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.Location = new System.Drawing.Point(48, 497);
            this.btnKitchen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(326, 70);
            this.btnKitchen.TabIndex = 6;
            this.btnKitchen.Text = "Kitchen";
            this.btnKitchen.UseVisualStyleBackColor = true;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.Location = new System.Drawing.Point(48, 625);
            this.btnBilling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(326, 64);
            this.btnBilling.TabIndex = 7;
            this.btnBilling.Text = "Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.Location = new System.Drawing.Point(48, 736);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(326, 58);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1364, 147);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(248, 64);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(532, 147);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(632, 49);
            this.txtUserName.TabIndex = 10;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.Location = new System.Drawing.Point(561, 269);
            this.lblOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(162, 42);
            this.lblOrders.TabIndex = 11;
            this.lblOrders.Text = "Orders : ";
            this.lblOrders.Click += new System.EventHandler(this.lblOrders_Click);
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.Location = new System.Drawing.Point(538, 362);
            this.lblPending.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(186, 42);
            this.lblPending.TabIndex = 12;
            this.lblPending.Text = "Pending : ";
            this.lblPending.Click += new System.EventHandler(this.lblPending_Click);
            // 
            // lblPreparing
            // 
            this.lblPreparing.AutoSize = true;
            this.lblPreparing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparing.Location = new System.Drawing.Point(514, 455);
            this.lblPreparing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreparing.Name = "lblPreparing";
            this.lblPreparing.Size = new System.Drawing.Size(210, 42);
            this.lblPreparing.TabIndex = 13;
            this.lblPreparing.Text = "Preparing : ";
            this.lblPreparing.Click += new System.EventHandler(this.lblPreparing_Click);
            // 
            // lblOverallReport
            // 
            this.lblOverallReport.AutoSize = true;
            this.lblOverallReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallReport.Location = new System.Drawing.Point(698, 556);
            this.lblOverallReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverallReport.Name = "lblOverallReport";
            this.lblOverallReport.Size = new System.Drawing.Size(389, 55);
            this.lblOverallReport.TabIndex = 14;
            this.lblOverallReport.Text = "Overall Report : ";
            this.lblOverallReport.Click += new System.EventHandler(this.lblOverallReport_Click);
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(470, 647);
            this.lblTotalOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(255, 42);
            this.lblTotalOrders.TabIndex = 15;
            this.lblTotalOrders.Text = "Total Orders : ";
            this.lblTotalOrders.Click += new System.EventHandler(this.lblTotalOrders_Click);
            // 
            // lblTotalsale
            // 
            this.lblTotalsale.AutoSize = true;
            this.lblTotalsale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalsale.Location = new System.Drawing.Point(508, 741);
            this.lblTotalsale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalsale.Name = "lblTotalsale";
            this.lblTotalsale.Size = new System.Drawing.Size(216, 42);
            this.lblTotalsale.TabIndex = 16;
            this.lblTotalsale.Text = "Total Sale : ";
            this.lblTotalsale.Click += new System.EventHandler(this.lblTotalsale_Click);
            // 
            // txtOrders
            // 
            this.txtOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrders.Location = new System.Drawing.Point(729, 269);
            this.txtOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.ReadOnly = true;
            this.txtOrders.Size = new System.Drawing.Size(337, 49);
            this.txtOrders.TabIndex = 17;
            this.txtOrders.TextChanged += new System.EventHandler(this.txtOrders_TextChanged);
            // 
            // txtPending
            // 
            this.txtPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPending.Location = new System.Drawing.Point(729, 362);
            this.txtPending.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPending.Name = "txtPending";
            this.txtPending.ReadOnly = true;
            this.txtPending.Size = new System.Drawing.Size(337, 49);
            this.txtPending.TabIndex = 18;
            this.txtPending.TextChanged += new System.EventHandler(this.txtPending_TextChanged);
            // 
            // txtPreparing
            // 
            this.txtPreparing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreparing.Location = new System.Drawing.Point(729, 455);
            this.txtPreparing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPreparing.Name = "txtPreparing";
            this.txtPreparing.ReadOnly = true;
            this.txtPreparing.Size = new System.Drawing.Size(337, 49);
            this.txtPreparing.TabIndex = 19;
            this.txtPreparing.TextChanged += new System.EventHandler(this.txtPreparing_TextChanged);
            // 
            // txtTotalOrders
            // 
            this.txtTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrders.Location = new System.Drawing.Point(729, 647);
            this.txtTotalOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalOrders.Name = "txtTotalOrders";
            this.txtTotalOrders.ReadOnly = true;
            this.txtTotalOrders.Size = new System.Drawing.Size(337, 49);
            this.txtTotalOrders.TabIndex = 20;
            this.txtTotalOrders.TextChanged += new System.EventHandler(this.txtTotalOrders_TextChanged);
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSale.Location = new System.Drawing.Point(729, 736);
            this.txtTotalSale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(337, 49);
            this.txtTotalSale.TabIndex = 21;
            this.txtTotalSale.TextChanged += new System.EventHandler(this.txtTotalSale_TextChanged);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 906);
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
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.btnTables);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.splitter1);
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