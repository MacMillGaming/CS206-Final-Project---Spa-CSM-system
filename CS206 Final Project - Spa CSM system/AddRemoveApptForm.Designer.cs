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
            btnAddAppt = new Button();
            btnRemoveAppt = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblSelectCustomer
            // 
            lblSelectCustomer.AutoSize = true;
            lblSelectCustomer.Location = new Point(32, 33);
            lblSelectCustomer.Margin = new Padding(4, 0, 4, 0);
            lblSelectCustomer.Name = "lblSelectCustomer";
            lblSelectCustomer.Size = new Size(188, 32);
            lblSelectCustomer.TabIndex = 0;
            lblSelectCustomer.Text = "Select Customer";
            // 
            // txtSelectCustomer
            // 
            txtSelectCustomer.Location = new Point(32, 69);
            txtSelectCustomer.Margin = new Padding(4);
            txtSelectCustomer.Name = "txtSelectCustomer";
            txtSelectCustomer.Size = new Size(194, 39);
            txtSelectCustomer.TabIndex = 1;
            // 
            // lblSelectAppt
            // 
            lblSelectAppt.AutoSize = true;
            lblSelectAppt.Location = new Point(32, 206);
            lblSelectAppt.Margin = new Padding(4, 0, 4, 0);
            lblSelectAppt.Name = "lblSelectAppt";
            lblSelectAppt.Size = new Size(226, 32);
            lblSelectAppt.TabIndex = 2;
            lblSelectAppt.Text = "Select Appointment";
            // 
            // txtSelectAppt
            // 
            txtSelectAppt.Location = new Point(32, 242);
            txtSelectAppt.Margin = new Padding(4);
            txtSelectAppt.Name = "txtSelectAppt";
            txtSelectAppt.Size = new Size(194, 39);
            txtSelectAppt.TabIndex = 3;
            // 
            // lblProfessional
            // 
            lblProfessional.AutoSize = true;
            lblProfessional.Location = new Point(485, 33);
            lblProfessional.Margin = new Padding(4, 0, 4, 0);
            lblProfessional.Name = "lblProfessional";
            lblProfessional.Size = new Size(142, 32);
            lblProfessional.TabIndex = 4;
            lblProfessional.Text = "Professional";
            // 
            // txtProfessional
            // 
            txtProfessional.Location = new Point(485, 69);
            txtProfessional.Margin = new Padding(4);
            txtProfessional.Name = "txtProfessional";
            txtProfessional.Size = new Size(194, 39);
            txtProfessional.TabIndex = 5;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(485, 206);
            lblService.Margin = new Padding(4, 0, 4, 0);
            lblService.Name = "lblService";
            lblService.Size = new Size(90, 32);
            lblService.TabIndex = 6;
            lblService.Text = "Service";
            // 
            // txtService
            // 
            txtService.Location = new Point(485, 242);
            txtService.Margin = new Padding(4);
            txtService.Name = "txtService";
            txtService.Size = new Size(194, 39);
            txtService.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(485, 333);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(64, 32);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(485, 369);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(194, 39);
            textBox5.TabIndex = 9;
            // 
            // btnAddAppt
            // 
            btnAddAppt.Location = new Point(801, 62);
            btnAddAppt.Name = "btnAddAppt";
            btnAddAppt.Size = new Size(227, 46);
            btnAddAppt.TabIndex = 16;
            btnAddAppt.Text = "&Add Appointment";
            btnAddAppt.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAppt
            // 
            btnRemoveAppt.Location = new Point(801, 235);
            btnRemoveAppt.Name = "btnRemoveAppt";
            btnRemoveAppt.Size = new Size(217, 46);
            btnRemoveAppt.TabIndex = 17;
            btnRemoveAppt.Text = "&Remove Appt";
            btnRemoveAppt.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(838, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 46);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddRemoveApptForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(btnCancel);
            Controls.Add(btnRemoveAppt);
            Controls.Add(btnAddAppt);
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
            Margin = new Padding(4);
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
        private Button btnAddAppt;
        private Button btnRemoveAppt;
        private Button btnCancel;
    }
}