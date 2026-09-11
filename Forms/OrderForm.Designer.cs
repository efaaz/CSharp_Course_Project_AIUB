namespace Restaurant_Management.Forms
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSelectTable = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgMenuItems = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dgSelectedItems = new System.Windows.Forms.DataGridView();
            this.txtClickedItem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(950, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "User:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsername.Location = new System.Drawing.Point(158, 227);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(202, 40);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "Efaz";
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDate.Location = new System.Drawing.Point(158, 318);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(202, 40);
            this.txtDate.TabIndex = 5;
            this.txtDate.Text = "Efaz";
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStatus.Location = new System.Drawing.Point(158, 402);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(202, 40);
            this.txtStatus.TabIndex = 7;
            this.txtStatus.Text = "Pending";
            this.txtStatus.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Status:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "Select Table:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbSelectTable
            // 
            this.cbSelectTable.FormattingEnabled = true;
            this.cbSelectTable.Items.AddRange(new object[] {
            "2",
            "4",
            "5",
            "8"});
            this.cbSelectTable.Location = new System.Drawing.Point(249, 487);
            this.cbSelectTable.Name = "cbSelectTable";
            this.cbSelectTable.Size = new System.Drawing.Size(156, 33);
            this.cbSelectTable.TabIndex = 9;
            this.cbSelectTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(506, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 42);
            this.label7.TabIndex = 10;
            this.label7.Text = "Menu Items";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgMenuItems
            // 
            this.dgMenuItems.AllowUserToDeleteRows = false;
            this.dgMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenuItems.Location = new System.Drawing.Point(513, 208);
            this.dgMenuItems.Name = "dgMenuItems";
            this.dgMenuItems.ReadOnly = true;
            this.dgMenuItems.RowHeadersWidth = 82;
            this.dgMenuItems.RowTemplate.Height = 33;
            this.dgMenuItems.Size = new System.Drawing.Size(950, 400);
            this.dgMenuItems.TabIndex = 11;
            this.dgMenuItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenuItems_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1463, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 42);
            this.label8.TabIndex = 12;
            this.label8.Text = "Selected Items";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgSelectedItems
            // 
            this.dgSelectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelectedItems.Location = new System.Drawing.Point(1470, 208);
            this.dgSelectedItems.Name = "dgSelectedItems";
            this.dgSelectedItems.RowHeadersWidth = 82;
            this.dgSelectedItems.RowTemplate.Height = 33;
            this.dgSelectedItems.Size = new System.Drawing.Size(900, 400);
            this.dgSelectedItems.TabIndex = 13;
            this.dgSelectedItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSelectedItems_CellContentClick);
            // 
            // txtClickedItem
            // 
            this.txtClickedItem.BackColor = System.Drawing.SystemColors.Control;
            this.txtClickedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClickedItem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClickedItem.Location = new System.Drawing.Point(800, 648);
            this.txtClickedItem.Multiline = true;
            this.txtClickedItem.Name = "txtClickedItem";
            this.txtClickedItem.ReadOnly = true;
            this.txtClickedItem.Size = new System.Drawing.Size(202, 40);
            this.txtClickedItem.TabIndex = 15;
            this.txtClickedItem.Text = "Burger";
            this.txtClickedItem.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(525, 649);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 37);
            this.label9.TabIndex = 14;
            this.label9.Text = "Clicked Item:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtQuantity.Location = new System.Drawing.Point(800, 740);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(202, 40);
            this.txtQuantity.TabIndex = 17;
            this.txtQuantity.Text = "Burger";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(525, 743);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 37);
            this.label10.TabIndex = 16;
            this.label10.Text = "Select Quantity:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(1104, 648);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(289, 61);
            this.btnAddItem.TabIndex = 18;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTotalPrice.Location = new System.Drawing.Point(2058, 649);
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 40);
            this.txtTotalPrice.TabIndex = 20;
            this.txtTotalPrice.Text = "1000";
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1861, 652);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 37);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total Price:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2164, 657);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 33);
            this.label12.TabIndex = 21;
            this.label12.Text = "Tk";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(931, 837);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(273, 69);
            this.btnCreateOrder.TabIndex = 22;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(1104, 719);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(289, 61);
            this.btnRemoveItem.TabIndex = 23;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2432, 1162);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtClickedItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgSelectedItems);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgMenuItems);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSelectTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgMenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSelectTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgMenuItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgSelectedItems;
        private System.Windows.Forms.TextBox txtClickedItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}