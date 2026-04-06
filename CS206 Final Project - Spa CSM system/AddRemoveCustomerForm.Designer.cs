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
            lstCustomers = new ListBox();
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
            SuspendLayout();
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(10, 23);
            lstCustomers.Margin = new Padding(3, 2, 3, 2);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(189, 184);
            lstCustomers.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(205, 41);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 1;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(342, 41);
            txtDOB.Margin = new Padding(3, 2, 3, 2);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(110, 23);
            txtDOB.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(342, 96);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(205, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 15);
            lblName.TabIndex = 4;
            lblName.Text = "First Name";
            lblName.Click += lblName_Click;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(346, 23);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(76, 15);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(346, 79);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(205, 132);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(206, 149);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(110, 23);
            txtPhone.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(205, 186);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 21);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(205, 79);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(206, 95);
            txtLastName.Margin = new Padding(2, 1, 2, 1);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(110, 23);
            txtLastName.TabIndex = 16;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(342, 186);
            btnAddCustomer.Margin = new Padding(2, 1, 2, 1);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(120, 21);
            btnAddCustomer.TabIndex = 17;
            btnAddCustomer.Text = "&Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnRemoveCustomer
            // 
            btnRemoveCustomer.Location = new Point(342, 150);
            btnRemoveCustomer.Margin = new Padding(2, 1, 2, 1);
            btnRemoveCustomer.Name = "btnRemoveCustomer";
            btnRemoveCustomer.Size = new Size(120, 22);
            btnRemoveCustomer.TabIndex = 18;
            btnRemoveCustomer.Text = "&Remove Customer";
            btnRemoveCustomer.UseVisualStyleBackColor = true;
            // 
            // AddRemoveCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 240);
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
            Controls.Add(lstCustomers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddRemoveCustomerForm";
            Text = "AddRemoveCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCustomers;
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
    }
}