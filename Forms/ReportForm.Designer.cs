namespace Restaurant_Management.Forms
{
    partial class ReportForm
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
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalOrders = new System.Windows.Forms.TextBox();
            this.dgPaymentTable = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCompletedOrders = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dtStartDate
            // 
            this.dtStartDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Location = new System.Drawing.Point(193, 254);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(486, 40);
            this.dtStartDate.TabIndex = 0;
            // 
            // dtEndDate
            // 
            this.dtEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Location = new System.Drawing.Point(193, 355);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(486, 40);
            this.dtEndDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(777, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reports";
            // 
            // txtTotalOrders
            // 
            this.txtTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrders.Location = new System.Drawing.Point(372, 437);
            this.txtTotalOrders.Name = "txtTotalOrders";
            this.txtTotalOrders.ReadOnly = true;
            this.txtTotalOrders.Size = new System.Drawing.Size(224, 44);
            this.txtTotalOrders.TabIndex = 3;
            this.txtTotalOrders.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgPaymentTable
            // 
            this.dgPaymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaymentTable.Location = new System.Drawing.Point(723, 325);
            this.dgPaymentTable.Name = "dgPaymentTable";
            this.dgPaymentTable.ReadOnly = true;
            this.dgPaymentTable.RowHeadersWidth = 82;
            this.dgPaymentTable.RowTemplate.Height = 33;
            this.dgPaymentTable.Size = new System.Drawing.Size(1086, 516);
            this.dgPaymentTable.TabIndex = 4;
            this.dgPaymentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrderTable_CellContentClick);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(63, 795);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(261, 65);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Orders:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 37);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Completed Orders:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCompletedOrders
            // 
            this.txtCompletedOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompletedOrders.Location = new System.Drawing.Point(372, 532);
            this.txtCompletedOrders.Name = "txtCompletedOrders";
            this.txtCompletedOrders.ReadOnly = true;
            this.txtCompletedOrders.Size = new System.Drawing.Size(224, 44);
            this.txtCompletedOrders.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 659);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Sales:";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSales.Location = new System.Drawing.Point(372, 652);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.ReadOnly = true;
            this.txtTotalSales.Size = new System.Drawing.Size(224, 44);
            this.txtTotalSales.TabIndex = 12;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(1548, 67);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(261, 65);
            this.btnDashboard.TabIndex = 14;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(714, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(509, 51);
            this.label8.TabIndex = 15;
            this.label8.Text = "Recent Payment History";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 1166);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCompletedOrders);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgPaymentTable);
            this.Controls.Add(this.txtTotalOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtStartDate);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPaymentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalOrders;
        private System.Windows.Forms.DataGridView dgPaymentTable;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCompletedOrders;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label8;
    }
}