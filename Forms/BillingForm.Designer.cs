namespace Restaurant_Management.Forms
{
    partial class BillingForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblServiceCharge = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.lblItemDetails = new System.Windows.Forms.Label();
            this.dgOrderDetails = new System.Windows.Forms.DataGridView();
            this.dgItemDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(470, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Billing Page";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(735, 186);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(142, 32);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal : ";
            this.lblSubtotal.Click += new System.EventHandler(this.lblSubtotal_Click);
            // 
            // lblServiceCharge
            // 
            this.lblServiceCharge.AutoSize = true;
            this.lblServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCharge.Location = new System.Drawing.Point(575, 258);
            this.lblServiceCharge.Name = "lblServiceCharge";
            this.lblServiceCharge.Size = new System.Drawing.Size(306, 32);
            this.lblServiceCharge.TabIndex = 6;
            this.lblServiceCharge.Text = "Service Charge(10%) : ";
            this.lblServiceCharge.Click += new System.EventHandler(this.lblServiceCharge_Click);
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(739, 333);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(138, 32);
            this.lblVat.TabIndex = 7;
            this.lblVat.Text = "Vat(5%) : ";
            this.lblVat.Click += new System.EventHandler(this.lblVat_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(691, 403);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(186, 32);
            this.lblGrandTotal.TabIndex = 8;
            this.lblGrandTotal.Text = "Grand Total : ";
            this.lblGrandTotal.Click += new System.EventHandler(this.lblGrandTotal_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(631, 476);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(250, 32);
            this.lblPaymentMethod.TabIndex = 9;
            this.lblPaymentMethod.Text = "Payment Method : ";
            this.lblPaymentMethod.Click += new System.EventHandler(this.lblPaymentMethod_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(905, 180);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(212, 38);
            this.txtSubtotal.TabIndex = 10;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCharge.Location = new System.Drawing.Point(905, 252);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.ReadOnly = true;
            this.txtServiceCharge.Size = new System.Drawing.Size(212, 38);
            this.txtServiceCharge.TabIndex = 11;
            this.txtServiceCharge.TextChanged += new System.EventHandler(this.txtServiceCharge_TextChanged);
            // 
            // txtVat
            // 
            this.txtVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVat.Location = new System.Drawing.Point(905, 327);
            this.txtVat.Name = "txtVat";
            this.txtVat.ReadOnly = true;
            this.txtVat.Size = new System.Drawing.Size(212, 38);
            this.txtVat.TabIndex = 12;
            this.txtVat.TextChanged += new System.EventHandler(this.txtVat_TextChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(905, 397);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(212, 38);
            this.txtGrandTotal.TabIndex = 13;
            this.txtGrandTotal.TextChanged += new System.EventHandler(this.txtGrandTotal_TextChanged);
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.Location = new System.Drawing.Point(764, 551);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(250, 54);
            this.btnGenerateBill.TabIndex = 15;
            this.btnGenerateBill.Text = "Generate Bill";
            this.btnGenerateBill.UseVisualStyleBackColor = true;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.Location = new System.Drawing.Point(940, 75);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(250, 54);
            this.btnHomePage.TabIndex = 16;
            this.btnHomePage.Text = "Home Page";
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cbPaymentMethod.Location = new System.Drawing.Point(905, 469);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(212, 39);
            this.cbPaymentMethod.TabIndex = 17;
            this.cbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cbPaymentMethod_SelectedIndexChanged);
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.Location = new System.Drawing.Point(12, 75);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(201, 36);
            this.lblOrderDetails.TabIndex = 18;
            this.lblOrderDetails.Text = "Order Details";
            this.lblOrderDetails.Click += new System.EventHandler(this.lblOrderDetails_Click);
            // 
            // lblItemDetails
            // 
            this.lblItemDetails.AutoSize = true;
            this.lblItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemDetails.Location = new System.Drawing.Point(12, 397);
            this.lblItemDetails.Name = "lblItemDetails";
            this.lblItemDetails.Size = new System.Drawing.Size(180, 36);
            this.lblItemDetails.TabIndex = 19;
            this.lblItemDetails.Text = "Item Details";
            this.lblItemDetails.Click += new System.EventHandler(this.lblItemDetails_Click);
            // 
            // dgOrderDetails
            // 
            this.dgOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderDetails.Location = new System.Drawing.Point(18, 114);
            this.dgOrderDetails.Name = "dgOrderDetails";
            this.dgOrderDetails.RowHeadersWidth = 51;
            this.dgOrderDetails.RowTemplate.Height = 24;
            this.dgOrderDetails.Size = new System.Drawing.Size(551, 264);
            this.dgOrderDetails.TabIndex = 20;
            this.dgOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderDetails_CellContentClick);
            // 
            // dgItemDetails
            // 
            this.dgItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemDetails.Location = new System.Drawing.Point(18, 439);
            this.dgItemDetails.Name = "dgItemDetails";
            this.dgItemDetails.RowHeadersWidth = 51;
            this.dgItemDetails.RowTemplate.Height = 24;
            this.dgItemDetails.Size = new System.Drawing.Size(551, 209);
            this.dgItemDetails.TabIndex = 21;
            this.dgItemDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemDetails_CellContentClick);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 660);
            this.Controls.Add(this.dgItemDetails);
            this.Controls.Add(this.dgOrderDetails);
            this.Controls.Add(this.lblItemDetails);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.cbPaymentMethod);
            this.Controls.Add(this.btnHomePage);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblServiceCharge);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTitle);
            this.Name = "BillingForm";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblServiceCharge;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtServiceCharge;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Label lblItemDetails;
        private System.Windows.Forms.DataGridView dgOrderDetails;
        private System.Windows.Forms.DataGridView dgItemDetails;
    }
}