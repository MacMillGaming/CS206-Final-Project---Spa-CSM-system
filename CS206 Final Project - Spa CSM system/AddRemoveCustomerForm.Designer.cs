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
            txtDateOfBirth = new TextBox();
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
            lstCustomers.Location = new Point(12, 31);
            lstCustomers.Name = "lstCustomers";
            lstCustomers.Size = new Size(205, 264);
            lstCustomers.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(237, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(237, 125);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(125, 27);
            txtDateOfBirth.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(237, 193);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(237, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(237, 102);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(97, 20);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(237, 170);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(236, 234);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(237, 257);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(418, 193);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAddCustomer
            // 
            lblAddCustomer.AutoSize = true;
            lblAddCustomer.Location = new Point(405, 31);
            lblAddCustomer.Name = "lblAddCustomer";
            lblAddCustomer.Size = new Size(107, 20);
            lblAddCustomer.TabIndex = 10;
            lblAddCustomer.Text = "Add Customer:";
            // 
            // lblRemoveCustomer
            // 
            lblRemoveCustomer.AutoSize = true;
            lblRemoveCustomer.Location = new Point(405, 102);
            lblRemoveCustomer.Name = "lblRemoveCustomer";
            lblRemoveCustomer.Size = new Size(133, 20);
            lblRemoveCustomer.TabIndex = 11;
            lblRemoveCustomer.Text = "Remove Customer:";
            // 
            // txtAddCustomer
            // 
            txtAddCustomer.Location = new Point(405, 54);
            txtAddCustomer.Name = "txtAddCustomer";
            txtAddCustomer.Size = new Size(125, 27);
            txtAddCustomer.TabIndex = 12;
            // 
            // txtRemoveCustomer
            // 
            txtRemoveCustomer.Location = new Point(405, 125);
            txtRemoveCustomer.Name = "txtRemoveCustomer";
            txtRemoveCustomer.Size = new Size(125, 27);
            txtRemoveCustomer.TabIndex = 13;
            // 
            // AddRemoveCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 319);
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
            Controls.Add(txtDateOfBirth);
            Controls.Add(txtName);
            Controls.Add(lstCustomers);
            Name = "AddRemoveCustomerForm";
            Text = "AddRemoveCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCustomers;
        private TextBox txtName;
        private TextBox txtDateOfBirth;
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