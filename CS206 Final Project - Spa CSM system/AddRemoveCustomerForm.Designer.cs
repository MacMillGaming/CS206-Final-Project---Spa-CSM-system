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
            txtAddCustomer = new TextBox();
            txtRemoveCustomer = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnAddCustomer = new Button();
            btnRemoveCustomer = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(383, 43);
            txtName.Margin = new Padding(6, 4, 6, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 39);
            txtName.TabIndex = 1;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(383, 222);
            txtDOB.Margin = new Padding(6, 4, 6, 4);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(201, 39);
            txtDOB.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(383, 311);
            txtEmail.Margin = new Padding(6, 4, 6, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(201, 39);
            txtEmail.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(383, 6);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(129, 32);
            lblName.TabIndex = 4;
            lblName.Text = "First Name";
            lblName.Click += lblName_Click;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(383, 186);
            lblDateOfBirth.Margin = new Padding(6, 0, 6, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(155, 32);
            lblDateOfBirth.TabIndex = 5;
            lblDateOfBirth.Text = "Date of Birth:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(383, 275);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(76, 32);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(383, 384);
            lblPhone.Margin = new Padding(6, 0, 6, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(87, 32);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(383, 425);
            txtPhone.Margin = new Padding(6, 4, 6, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(201, 39);
            txtPhone.TabIndex = 8;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(680, 309);
            btnCancel.Margin = new Padding(6, 4, 6, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 47);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtAddCustomer
            // 
            txtAddCustomer.Location = new Point(657, 412);
            txtAddCustomer.Margin = new Padding(6, 4, 6, 4);
            txtAddCustomer.Name = "txtAddCustomer";
            txtAddCustomer.Size = new Size(201, 39);
            txtAddCustomer.TabIndex = 12;
            // 
            // txtRemoveCustomer
            // 
            txtRemoveCustomer.Location = new Point(657, 367);
            txtRemoveCustomer.Margin = new Padding(6, 4, 6, 4);
            txtRemoveCustomer.Name = "txtRemoveCustomer";
            txtRemoveCustomer.Size = new Size(201, 39);
            txtRemoveCustomer.TabIndex = 13;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(383, 100);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(126, 32);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(383, 134);
            txtLastName.Margin = new Padding(4, 2, 4, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(201, 39);
            txtLastName.TabIndex = 16;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(635, 85);
            btnAddCustomer.Margin = new Padding(4, 2, 4, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(223, 47);
            btnAddCustomer.TabIndex = 17;
            btnAddCustomer.Text = "&Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnRemoveCustomer
            // 
            btnRemoveCustomer.Location = new Point(635, 201);
            btnRemoveCustomer.Margin = new Padding(4, 2, 4, 2);
            btnRemoveCustomer.Name = "btnRemoveCustomer";
            btnRemoveCustomer.Size = new Size(223, 47);
            btnRemoveCustomer.TabIndex = 18;
            btnRemoveCustomer.Text = "&Remove Customer";
            btnRemoveCustomer.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(316, 40);
            comboBox1.TabIndex = 19;
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
            // AddRemoveCustomerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 510);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnRemoveCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtRemoveCustomer);
            Controls.Add(txtAddCustomer);
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
        private TextBox txtAddCustomer;
        private TextBox txtRemoveCustomer;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnAddCustomer;
        private Button btnRemoveCustomer;
        private ComboBox comboBox1;
        private Label label1;
    }
}