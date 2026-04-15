namespace CS206_Final_Project___Spa_CSM_system
{
    partial class AddRemoveCustomerForm
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
            txtName = new TextBox();
            txtDOB = new TextBox();
            txtEmail = new TextBox();
            lblName = new Label();
            lblDateOfBirth = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnCancel = new Button();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnAddCustomer = new Button();
            btnRemoveCustomer = new Button();
            cboNameLookup = new ComboBox();
            label1 = new Label();
            cboCustomer = new ComboBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(338, 56);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 39);
            txtName.TabIndex = 1;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(338, 156);
            txtDOB.Margin = new Padding(3, 2, 3, 2);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(201, 39);
            txtDOB.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(342, 206);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(201, 39);
            txtEmail.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(203, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(129, 32);
            lblName.TabIndex = 4;
            lblName.Text = "First Name";
            lblName.Click += lblName_Click;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(177, 156);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(155, 32);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(253, 213);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 32);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(242, 260);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(87, 32);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(338, 260);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(201, 39);
            txtPhone.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(608, 239);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(168, 39);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(203, 108);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(126, 32);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(337, 105);
            txtLastName.Margin = new Padding(2, 1, 2, 1);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(201, 39);
            txtLastName.TabIndex = 2;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(548, 125);
            btnAddCustomer.Margin = new Padding(2, 1, 2, 1);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(228, 41);
            btnAddCustomer.TabIndex = 17;
            btnAddCustomer.Text = "&Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnRemoveCustomer
            // 
            btnRemoveCustomer.Location = new Point(548, 168);
            btnRemoveCustomer.Margin = new Padding(2, 1, 2, 1);
            btnRemoveCustomer.Name = "btnRemoveCustomer";
            btnRemoveCustomer.Size = new Size(228, 47);
            btnRemoveCustomer.TabIndex = 18;
            btnRemoveCustomer.Text = "&Remove Customer";
            btnRemoveCustomer.UseVisualStyleBackColor = true;
            btnRemoveCustomer.Click += btnRemoveCustomer_Click;
            // 
            // cboNameLookup
            // 
            cboNameLookup.FormattingEnabled = true;
            cboNameLookup.Location = new Point(21, 42);
            cboNameLookup.Name = "cboNameLookup";
            cboNameLookup.Size = new Size(316, 40);
            cboNameLookup.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 6);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 20;
            label1.Text = "label1";
            // 
            // cboCustomer
            // 
            cboCustomer.FormattingEnabled = true;
            cboCustomer.Location = new Point(12, 12);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(276, 40);
            cboCustomer.TabIndex = 19;
            // 
            // AddRemoveCustomerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 335);
            Controls.Add(cboCustomer);
            Controls.Add(btnRemoveCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(btnCancel);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblName);
            Controls.Add(txtEmail);
            Controls.Add(txtDOB);
            Controls.Add(txtName);
            Margin = new Padding(6, 4, 6, 4);
            Name = "AddRemoveCustomerForm";
            Text = "AddRemoveCustomerForm";
            Load += AddRemoveCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private TextBox txtDOB;
        private TextBox txtEmail;
        private Label lblName;
        private Label lblDateOfBirth;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Button btnCancel;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnAddCustomer;
        private Button btnRemoveCustomer;
        private ComboBox cboNameLookup;
        private Label label1;
        private ComboBox cboCustomer;
    }
}