namespace CS206_Final_Project___Spa_CSM_system
{
    partial class AddRemoveApptForm
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
            lblSelectCustomer = new Label();
            txtSelectCustomer = new TextBox();
            lblSelectAppt = new Label();
            txtSelectAppt = new TextBox();
            lblProfessional = new Label();
            txtProfessional = new TextBox();
            lblService = new Label();
            txtService = new TextBox();
            lblDate = new Label();
            textBox5 = new TextBox();
            lblAddAppt = new Label();
            txtAddAppt = new TextBox();
            lblRemoveAppt = new Label();
            txtRemoveAppt = new TextBox();
            lblCancel = new Label();
            txtCancel = new TextBox();
            SuspendLayout();
            // 
            // lblSelectCustomer
            // 
            lblSelectCustomer.AutoSize = true;
            lblSelectCustomer.Location = new Point(25, 26);
            lblSelectCustomer.Name = "lblSelectCustomer";
            lblSelectCustomer.Size = new Size(140, 25);
            lblSelectCustomer.TabIndex = 0;
            lblSelectCustomer.Text = "Select Customer";
            // 
            // txtSelectCustomer
            // 
            txtSelectCustomer.Location = new Point(25, 54);
            txtSelectCustomer.Name = "txtSelectCustomer";
            txtSelectCustomer.Size = new Size(150, 31);
            txtSelectCustomer.TabIndex = 1;
            // 
            // lblSelectAppt
            // 
            lblSelectAppt.AutoSize = true;
            lblSelectAppt.Location = new Point(25, 161);
            lblSelectAppt.Name = "lblSelectAppt";
            lblSelectAppt.Size = new Size(169, 25);
            lblSelectAppt.TabIndex = 2;
            lblSelectAppt.Text = "Select Appointment";
            // 
            // txtSelectAppt
            // 
            txtSelectAppt.Location = new Point(25, 189);
            txtSelectAppt.Name = "txtSelectAppt";
            txtSelectAppt.Size = new Size(150, 31);
            txtSelectAppt.TabIndex = 3;
            // 
            // lblProfessional
            // 
            lblProfessional.AutoSize = true;
            lblProfessional.Location = new Point(373, 26);
            lblProfessional.Name = "lblProfessional";
            lblProfessional.Size = new Size(108, 25);
            lblProfessional.TabIndex = 4;
            lblProfessional.Text = "Professional";
            // 
            // txtProfessional
            // 
            txtProfessional.Location = new Point(373, 54);
            txtProfessional.Name = "txtProfessional";
            txtProfessional.Size = new Size(150, 31);
            txtProfessional.TabIndex = 5;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(373, 161);
            lblService.Name = "lblService";
            lblService.Size = new Size(67, 25);
            lblService.TabIndex = 6;
            lblService.Text = "Service";
            // 
            // txtService
            // 
            txtService.Location = new Point(373, 189);
            txtService.Name = "txtService";
            txtService.Size = new Size(150, 31);
            txtService.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(373, 260);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(49, 25);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(373, 288);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 9;
            // 
            // lblAddAppt
            // 
            lblAddAppt.AutoSize = true;
            lblAddAppt.Location = new Point(638, 26);
            lblAddAppt.Name = "lblAddAppt";
            lblAddAppt.Size = new Size(157, 25);
            lblAddAppt.TabIndex = 10;
            lblAddAppt.Text = "Add Appointment";
            // 
            // txtAddAppt
            // 
            txtAddAppt.Location = new Point(638, 54);
            txtAddAppt.Name = "txtAddAppt";
            txtAddAppt.Size = new Size(150, 31);
            txtAddAppt.TabIndex = 11;
            // 
            // lblRemoveAppt
            // 
            lblRemoveAppt.AutoSize = true;
            lblRemoveAppt.Location = new Point(618, 161);
            lblRemoveAppt.Name = "lblRemoveAppt";
            lblRemoveAppt.Size = new Size(187, 25);
            lblRemoveAppt.TabIndex = 12;
            lblRemoveAppt.Text = "Remove Appointment";
            // 
            // txtRemoveAppt
            // 
            txtRemoveAppt.Location = new Point(638, 189);
            txtRemoveAppt.Name = "txtRemoveAppt";
            txtRemoveAppt.Size = new Size(150, 31);
            txtRemoveAppt.TabIndex = 13;
            // 
            // lblCancel
            // 
            lblCancel.AutoSize = true;
            lblCancel.Location = new Point(686, 260);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(63, 25);
            lblCancel.TabIndex = 14;
            lblCancel.Text = "Cancel";
            // 
            // txtCancel
            // 
            txtCancel.Location = new Point(638, 288);
            txtCancel.Name = "txtCancel";
            txtCancel.Size = new Size(150, 31);
            txtCancel.TabIndex = 15;
            // 
            // AddRemoveApptForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCancel);
            Controls.Add(lblCancel);
            Controls.Add(txtRemoveAppt);
            Controls.Add(lblRemoveAppt);
            Controls.Add(txtAddAppt);
            Controls.Add(lblAddAppt);
            Controls.Add(textBox5);
            Controls.Add(lblDate);
            Controls.Add(txtService);
            Controls.Add(lblService);
            Controls.Add(txtProfessional);
            Controls.Add(lblProfessional);
            Controls.Add(txtSelectAppt);
            Controls.Add(lblSelectAppt);
            Controls.Add(txtSelectCustomer);
            Controls.Add(lblSelectCustomer);
            Name = "AddRemoveApptForm";
            Text = "AddRemoveApptForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectCustomer;
        private TextBox txtSelectCustomer;
        private Label lblSelectAppt;
        private TextBox txtSelectAppt;
        private Label lblProfessional;
        private TextBox txtProfessional;
        private Label lblService;
        private TextBox txtService;
        private Label lblDate;
        private TextBox textBox5;
        private Label lblAddAppt;
        private TextBox txtAddAppt;
        private Label lblRemoveAppt;
        private TextBox txtRemoveAppt;
        private Label lblCancel;
        private TextBox txtCancel;
    }
}