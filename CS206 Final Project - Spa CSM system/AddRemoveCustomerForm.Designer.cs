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
            txtName.Location = new Point(196, 68);
            txtName.Margin = new Padding(2, 1, 2, 1);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 1;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(376, 26);
            txtDOB.Margin = new Padding(2, 1, 2, 1);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(110, 23);
            txtDOB.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(376, 63);
            txtEmail.Margin = new Padding(2, 1, 2, 1);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(110, 23);
            txtEmail.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(128, 71);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 15);
            lblName.TabIndex = 4;
            lblName.Text = "First Name";
            lblName.Click += lblName_Click;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(296, 29);
            lblDateOfBirth.Margin = new Padding(2, 0, 2, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(76, 15);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(333, 66);
            lblEmail.Margin = new Padding(2, 0, 2, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(328, 108);
            lblPhone.Margin = new Padding(2, 0, 2, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(376, 100);
            txtPhone.Margin = new Padding(2, 1, 2, 1);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(110, 23);
            txtPhone.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Pink;
            btnCancel.Location = new Point(396, 144);
            btnCancel.Margin = new Padding(2, 1, 2, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 25);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(129, 103);
            lblLastName.Margin = new Padding(1, 0, 1, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(197, 100);
            txtLastName.Margin = new Padding(1, 0, 1, 0);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(110, 23);
            txtLastName.TabIndex = 2;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.LightPink;
            btnAddCustomer.BackgroundImageLayout = ImageLayout.Center;
            btnAddCustomer.Location = new Point(11, 147);
            btnAddCustomer.Margin = new Padding(1, 0, 1, 0);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(123, 25);
            btnAddCustomer.TabIndex = 17;
            btnAddCustomer.Text = "&Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnRemoveCustomer
            // 
            btnRemoveCustomer.BackColor = Color.LightPink;
            btnRemoveCustomer.Location = new Point(184, 147);
            btnRemoveCustomer.Margin = new Padding(1, 0, 1, 0);
            btnRemoveCustomer.Name = "btnRemoveCustomer";
            btnRemoveCustomer.Size = new Size(123, 22);
            btnRemoveCustomer.TabIndex = 18;
            btnRemoveCustomer.Text = "&Remove Customer";
            btnRemoveCustomer.UseVisualStyleBackColor = false;
            btnRemoveCustomer.Click += btnRemoveCustomer_Click;
            // 
            // cboNameLookup
            // 
            cboNameLookup.FormattingEnabled = true;
            cboNameLookup.Location = new Point(21, 42);
            cboNameLookup.Name = "cboNameLookup";
            cboNameLookup.Size = new Size(316, 23);
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
            cboCustomer.Location = new Point(11, 21);
            cboCustomer.Margin = new Padding(2, 1, 2, 1);
            cboCustomer.Name = "cboCustomer";
            cboCustomer.Size = new Size(150, 23);
            cboCustomer.TabIndex = 19;
            // 
            // AddRemoveCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(522, 207);
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
            Margin = new Padding(3, 2, 3, 2);
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