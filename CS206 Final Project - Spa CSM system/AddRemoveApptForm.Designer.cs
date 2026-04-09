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
            lblSelectAppt = new Label();
            lblProfessional = new Label();
            txtProfessional = new TextBox();
            lblService = new Label();
            txtService = new TextBox();
            lblDate = new Label();
            btnAddAppt = new Button();
            btnRemoveAppt = new Button();
            btnCancel = new Button();
            lstAppt = new ListBox();
            dateApptDate = new DateTimePicker();
            cboNameLookup = new ComboBox();
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
            // lblSelectAppt
            // 
            lblSelectAppt.AutoSize = true;
            lblSelectAppt.Location = new Point(34, 151);
            lblSelectAppt.Margin = new Padding(4, 0, 4, 0);
            lblSelectAppt.Name = "lblSelectAppt";
            lblSelectAppt.Size = new Size(226, 32);
            lblSelectAppt.TabIndex = 2;
            lblSelectAppt.Text = "Select Appointment";
            // 
            // lblProfessional
            // 
            lblProfessional.AutoSize = true;
            lblProfessional.Location = new Point(570, 30);
            lblProfessional.Margin = new Padding(4, 0, 4, 0);
            lblProfessional.Name = "lblProfessional";
            lblProfessional.Size = new Size(142, 32);
            lblProfessional.TabIndex = 4;
            lblProfessional.Text = "Professional";
            // 
            // txtProfessional
            // 
            txtProfessional.Location = new Point(570, 66);
            txtProfessional.Margin = new Padding(4);
            txtProfessional.Name = "txtProfessional";
            txtProfessional.Size = new Size(194, 39);
            txtProfessional.TabIndex = 5;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(570, 197);
            lblService.Margin = new Padding(4, 0, 4, 0);
            lblService.Name = "lblService";
            lblService.Size = new Size(90, 32);
            lblService.TabIndex = 6;
            lblService.Text = "Service";
            // 
            // txtService
            // 
            txtService.Location = new Point(570, 242);
            txtService.Margin = new Padding(4);
            txtService.Name = "txtService";
            txtService.Size = new Size(194, 39);
            txtService.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(570, 336);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(64, 32);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            // 
            // btnAddAppt
            // 
            btnAddAppt.Location = new Point(801, 62);
            btnAddAppt.Name = "btnAddAppt";
            btnAddAppt.Size = new Size(227, 46);
            btnAddAppt.TabIndex = 16;
            btnAddAppt.Text = "&Add Appointment";
            btnAddAppt.UseVisualStyleBackColor = true;
            btnAddAppt.Click += btnAddAppt_Click;
            // 
            // btnRemoveAppt
            // 
            btnRemoveAppt.Location = new Point(801, 235);
            btnRemoveAppt.Name = "btnRemoveAppt";
            btnRemoveAppt.Size = new Size(217, 46);
            btnRemoveAppt.TabIndex = 17;
            btnRemoveAppt.Text = "&Remove Appt";
            btnRemoveAppt.UseVisualStyleBackColor = true;
            btnRemoveAppt.Click += btnRemoveAppt_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(838, 499);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 46);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lstAppt
            // 
            lstAppt.FormattingEnabled = true;
            lstAppt.Location = new Point(34, 189);
            lstAppt.Name = "lstAppt";
            lstAppt.Size = new Size(502, 356);
            lstAppt.TabIndex = 19;
            // 
            // dateApptDate
            // 
            dateApptDate.Location = new Point(568, 371);
            dateApptDate.Name = "dateApptDate";
            dateApptDate.Size = new Size(450, 39);
            dateApptDate.TabIndex = 20;
            // 
            // cboNameLookup
            // 
            cboNameLookup.FormattingEnabled = true;
            cboNameLookup.Location = new Point(32, 65);
            cboNameLookup.Name = "cboNameLookup";
            cboNameLookup.Size = new Size(504, 40);
            cboNameLookup.TabIndex = 21;
            cboNameLookup.SelectedIndexChanged += cboNameLookup_SelectedIndexChanged;
            // 
            // AddRemoveApptForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(cboNameLookup);
            Controls.Add(dateApptDate);
            Controls.Add(lstAppt);
            Controls.Add(btnCancel);
            Controls.Add(btnRemoveAppt);
            Controls.Add(btnAddAppt);
            Controls.Add(lblDate);
            Controls.Add(txtService);
            Controls.Add(lblService);
            Controls.Add(txtProfessional);
            Controls.Add(lblProfessional);
            Controls.Add(lblSelectAppt);
            Controls.Add(lblSelectCustomer);
            Margin = new Padding(4);
            Name = "AddRemoveApptForm";
            Text = "AddRemoveApptForm";
            Load += AddRemoveApptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectCustomer;
        private Label lblSelectAppt;
        private Label lblProfessional;
        private TextBox txtProfessional;
        private Label lblService;
        private TextBox txtService;
        private Label lblDate;
        private Button btnAddAppt;
        private Button btnRemoveAppt;
        private Button btnCancel;
        private ListBox lstAppt;
        private DateTimePicker dateApptDate;
        private ComboBox cboNameLookup;
    }
}