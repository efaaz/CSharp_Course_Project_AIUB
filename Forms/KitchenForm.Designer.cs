namespace Restaurant_Management.Forms
{
    partial class KitchenForm
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
            this.dgItemTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrderid = new System.Windows.Forms.TextBox();
            this.btnPreparing = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgOrdertable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdertable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitchen Display";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Orders";
            // 
            // dgItemTable
            // 
            this.dgItemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemTable.Location = new System.Drawing.Point(987, 271);
            this.dgItemTable.Name = "dgItemTable";
            this.dgItemTable.ReadOnly = true;
            this.dgItemTable.RowHeadersWidth = 82;
            this.dgItemTable.RowTemplate.Height = 33;
            this.dgItemTable.Size = new System.Drawing.Size(605, 456);
            this.dgItemTable.TabIndex = 3;
            this.dgItemTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemTable_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(978, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(417, 51);
            this.label3.TabIndex = 4;
            this.label3.Text = "Items to be Prepare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 806);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selected Order:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(461, 805);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Order Status:";
            // 
            // txtOrderid
            // 
            this.txtOrderid.BackColor = System.Drawing.SystemColors.Control;
            this.txtOrderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderid.Location = new System.Drawing.Point(304, 805);
            this.txtOrderid.Name = "txtOrderid";
            this.txtOrderid.ReadOnly = true;
            this.txtOrderid.Size = new System.Drawing.Size(130, 38);
            this.txtOrderid.TabIndex = 7;
            this.txtOrderid.TextChanged += new System.EventHandler(this.txtOrderid_TextChanged);
            // 
            // btnPreparing
            // 
            this.btnPreparing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreparing.Location = new System.Drawing.Point(51, 938);
            this.btnPreparing.Name = "btnPreparing";
            this.btnPreparing.Size = new System.Drawing.Size(300, 66);
            this.btnPreparing.TabIndex = 8;
            this.btnPreparing.Text = "Start Preparing";
            this.btnPreparing.UseVisualStyleBackColor = true;
            this.btnPreparing.Click += new System.EventHandler(this.btnPreparing_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(688, 806);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(130, 38);
            this.txtStatus.TabIndex = 9;
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.Location = new System.Drawing.Point(519, 938);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(300, 66);
            this.btnReady.TabIndex = 10;
            this.btnReady.Text = "Mark As Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(1381, 53);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(211, 66);
            this.btnDashboard.TabIndex = 11;
            this.btnDashboard.Text = "Dashboard ->";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1133, 938);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(300, 66);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgOrdertable
            // 
            this.dgOrdertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdertable.Location = new System.Drawing.Point(50, 271);
            this.dgOrdertable.Name = "dgOrdertable";
            this.dgOrdertable.ReadOnly = true;
            this.dgOrdertable.RowHeadersWidth = 82;
            this.dgOrdertable.RowTemplate.Height = 33;
            this.dgOrdertable.Size = new System.Drawing.Size(768, 456);
            this.dgOrdertable.TabIndex = 13;
            this.dgOrdertable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrdertable_CellContentClick);
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 1127);
            this.Controls.Add(this.dgOrdertable);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnPreparing);
            this.Controls.Add(this.txtOrderid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgItemTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KitchenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "KicthenForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgItemTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdertable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgItemTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrderid;
        private System.Windows.Forms.Button btnPreparing;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgOrdertable;
    }
}