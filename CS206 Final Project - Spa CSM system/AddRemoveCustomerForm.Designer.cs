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
            txtAddress = new TextBox();
            lblName = new Label();
            lblDateOfBirth = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnCancel = new Button();
            lblAddCustomer = new Label();
            lblRemoveCustomer = new Label();
            txtAddCustomer = new TextBox();
            txtRemoveCustomer = new TextBox();
            SuspendLayout();
            // 
            // lstCustomers
            // 
            lstCustomers.FormattingEnabled = true;
            lstCustomers.ItemHeight = 15;
            lstCustomers.Location = new Point(10, 23);
            lstCustomers.Margin = new Padding(3, 2, 3, 2);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(180, 199);
            lstCustomers.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(207, 40);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 1;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(207, 94);
            txtDOB.Margin = new Padding(3, 2, 3, 2);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(110, 23);
            txtDOB.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(207, 145);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(110, 23);
            txtAddress.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(207, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(207, 76);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(76, 15);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(207, 128);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(206, 176);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(207, 193);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(110, 23);
            txtPhone.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(366, 145);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAddCustomer
            // 
            lblAddCustomer.AutoSize = true;
            lblAddCustomer.Location = new Point(354, 23);
            lblAddCustomer.Name = "lblAddCustomer";
            lblAddCustomer.Size = new Size(87, 15);
            lblAddCustomer.TabIndex = 10;
            lblAddCustomer.Text = "Add Customer:";
            // 
            // lblRemoveCustomer
            // 
            lblRemoveCustomer.AutoSize = true;
            lblRemoveCustomer.Location = new Point(354, 76);
            lblRemoveCustomer.Name = "lblRemoveCustomer";
            lblRemoveCustomer.Size = new Size(108, 15);
            lblRemoveCustomer.TabIndex = 11;
            lblRemoveCustomer.Text = "Remove Customer:";
            // 
            // txtAddCustomer
            // 
            txtAddCustomer.Location = new Point(354, 40);
            txtAddCustomer.Margin = new Padding(3, 2, 3, 2);
            txtAddCustomer.Name = "txtAddCustomer";
            txtAddCustomer.Size = new Size(110, 23);
            txtAddCustomer.TabIndex = 12;
            // 
            // txtRemoveCustomer
            // 
            txtRemoveCustomer.Location = new Point(354, 94);
            txtRemoveCustomer.Margin = new Padding(3, 2, 3, 2);
            txtRemoveCustomer.Name = "txtRemoveCustomer";
            txtRemoveCustomer.Size = new Size(110, 23);
            txtRemoveCustomer.TabIndex = 13;
            // 
            // AddRemoveCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 239);
            Controls.Add(txtRemoveCustomer);
            Controls.Add(txtAddCustomer);
            Controls.Add(lblRemoveCustomer);
            Controls.Add(lblAddCustomer);
            Controls.Add(btnCancel);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblName);
            Controls.Add(txtAddress);
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
        private TextBox txtAddress;
        private Label lblName;
        private Label lblDateOfBirth;
        private Label lblAddress;
        private Label lblPhone;
        private TextBox txtPhone;
        private Button btnCancel;
        private Label lblAddCustomer;
        private Label lblRemoveCustomer;
        private TextBox txtAddCustomer;
        private TextBox txtRemoveCustomer;
    }
}