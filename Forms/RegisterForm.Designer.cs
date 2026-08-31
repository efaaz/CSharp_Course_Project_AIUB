namespace Restaurant_Management.Forms
{
    partial class RegisterForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorRole = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(202, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(382, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registration Page";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(186, 105);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name : ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(190, 172);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 29);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email : ";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(206, 245);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(82, 29);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Role : ";
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(150, 309);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(138, 29);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password : ";
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(308, 105);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 34);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(308, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 34);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(308, 309);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(265, 34);
            this.txtPass.TabIndex = 7;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // cbRole
            // 
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Chef",
            "Manager",
            "Cashier"});
            this.cbRole.Location = new System.Drawing.Point(308, 237);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(265, 37);
            this.cbRole.TabIndex = 8;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(317, 378);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(171, 41);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorName.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorName.Location = new System.Drawing.Point(314, 142);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(0, 18);
            this.lblErrorName.TabIndex = 10;
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorEmail.Location = new System.Drawing.Point(314, 206);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(0, 18);
            this.lblErrorEmail.TabIndex = 11;
            // 
            // lblErrorRole
            // 
            this.lblErrorRole.AutoSize = true;
            this.lblErrorRole.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRole.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorRole.Location = new System.Drawing.Point(314, 277);
            this.lblErrorRole.Name = "lblErrorRole";
            this.lblErrorRole.Size = new System.Drawing.Size(0, 18);
            this.lblErrorRole.TabIndex = 12;
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPass.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorPass.Location = new System.Drawing.Point(314, 346);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(0, 18);
            this.lblErrorPass.TabIndex = 13;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorPass);
            this.Controls.Add(this.lblErrorRole);
            this.Controls.Add(this.lblErrorEmail);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorRole;
        private System.Windows.Forms.Label lblErrorPass;
    }
}