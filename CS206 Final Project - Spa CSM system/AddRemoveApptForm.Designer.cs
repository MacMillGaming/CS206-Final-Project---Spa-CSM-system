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
            cboService = new ComboBox();
            SuspendLayout();
            // 
            // lblSelectCustomer
            // 
            lblSelectCustomer.AutoSize = true;
            lblSelectCustomer.Location = new Point(17, 15);
            lblSelectCustomer.Margin = new Padding(2, 0, 2, 0);
            lblSelectCustomer.Name = "lblSelectCustomer";
            lblSelectCustomer.Size = new Size(93, 15);
            lblSelectCustomer.TabIndex = 0;
            lblSelectCustomer.Text = "Select Customer";
            // 
            // lblSelectAppt
            // 
            lblSelectAppt.AutoSize = true;
            lblSelectAppt.Location = new Point(18, 71);
            lblSelectAppt.Margin = new Padding(2, 0, 2, 0);
            lblSelectAppt.Name = "lblSelectAppt";
            lblSelectAppt.Size = new Size(112, 15);
            lblSelectAppt.TabIndex = 2;
            lblSelectAppt.Text = "Select Appointment";
            // 
            // lblProfessional
            // 
            lblProfessional.AutoSize = true;
            lblProfessional.Location = new Point(307, 14);
            lblProfessional.Margin = new Padding(2, 0, 2, 0);
            lblProfessional.Name = "lblProfessional";
            lblProfessional.Size = new Size(71, 15);
            lblProfessional.TabIndex = 4;
            lblProfessional.Text = "Professional";
            // 
            // txtProfessional
            // 
            txtProfessional.Location = new Point(307, 31);
            txtProfessional.Margin = new Padding(2, 2, 2, 2);
            txtProfessional.Name = "txtProfessional";
            txtProfessional.Size = new Size(106, 23);
            txtProfessional.TabIndex = 5;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Location = new Point(307, 94);
            lblService.Margin = new Padding(2, 0, 2, 0);
            lblService.Name = "lblService";
            lblService.Size = new Size(44, 15);
            lblService.TabIndex = 6;
            lblService.Text = "Service";
            // 
            // txtService
            // 
            txtService.Location = new Point(431, 61);
            txtService.Margin = new Padding(2, 2, 2, 2);
            txtService.Name = "txtService";
            txtService.Size = new Size(106, 23);
            txtService.TabIndex = 7;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(307, 158);
            lblDate.Margin = new Padding(2, 0, 2, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            // 
            // btnAddAppt
            // 
            btnAddAppt.BackColor = Color.LightPink;
            btnAddAppt.Location = new Point(442, 29);
            btnAddAppt.Margin = new Padding(2, 1, 2, 1);
            btnAddAppt.Name = "btnAddAppt";
            btnAddAppt.Size = new Size(111, 22);
            btnAddAppt.TabIndex = 16;
            btnAddAppt.Text = "&Add Appointment";
            btnAddAppt.UseVisualStyleBackColor = false;
            btnAddAppt.Click += btnAddAppt_Click;
            // 
            // btnRemoveAppt
            // 
            btnRemoveAppt.BackColor = Color.LightPink;
            btnRemoveAppt.Location = new Point(442, 110);
            btnRemoveAppt.Margin = new Padding(2, 1, 2, 1);
            btnRemoveAppt.Name = "btnRemoveAppt";
            btnRemoveAppt.Size = new Size(106, 22);
            btnRemoveAppt.TabIndex = 17;
            btnRemoveAppt.Text = "&Remove Appt";
            btnRemoveAppt.UseVisualStyleBackColor = false;
            btnRemoveAppt.Click += btnRemoveAppt_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightPink;
            btnCancel.Location = new Point(451, 234);
            btnCancel.Margin = new Padding(2, 1, 2, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 22);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lstAppt
            // 
            lstAppt.FormattingEnabled = true;
            lstAppt.ItemHeight = 15;
            lstAppt.Location = new Point(18, 89);
            lstAppt.Margin = new Padding(2, 1, 2, 1);
            lstAppt.Name = "lstAppt";
            lstAppt.Size = new Size(272, 169);
            lstAppt.TabIndex = 19;
            // 
            // dateApptDate
            // 
            dateApptDate.Location = new Point(306, 174);
            dateApptDate.Margin = new Padding(2, 1, 2, 1);
            dateApptDate.Name = "dateApptDate";
            dateApptDate.Size = new Size(244, 23);
            dateApptDate.TabIndex = 20;
            // 
            // cboNameLookup
            // 
            cboNameLookup.FormattingEnabled = true;
            cboNameLookup.Location = new Point(17, 30);
            cboNameLookup.Margin = new Padding(2, 1, 2, 1);
            cboNameLookup.Name = "cboNameLookup";
            cboNameLookup.Size = new Size(273, 23);
            cboNameLookup.TabIndex = 21;
            cboNameLookup.SelectedIndexChanged += cboNameLookup_SelectedIndexChanged;
            // 
            // cboService
            // 
            cboService.FormattingEnabled = true;
            cboService.Location = new Point(298, 110);
            cboService.Margin = new Padding(2, 1, 2, 1);
            cboService.Name = "cboService";
            cboService.Size = new Size(132, 23);
            cboService.TabIndex = 22;
            // 
            // AddRemoveApptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(560, 270);
            Controls.Add(cboService);
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
            Margin = new Padding(2, 2, 2, 2);
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
        private ComboBox cboService;
    }
}