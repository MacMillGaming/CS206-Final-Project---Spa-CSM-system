namespace CS206_Final_Project___Spa_CSM_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboNameLookup = new ComboBox();
            lstAppt = new ListBox();
            btnAddRemoveCust = new Button();
            btnAddRemoveAppt = new Button();
            btnViewSummaries = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cboNameLookup
            // 
            cboNameLookup.FormattingEnabled = true;
            cboNameLookup.Location = new Point(43, 86);
            cboNameLookup.Name = "cboNameLookup";
            cboNameLookup.Size = new Size(636, 40);
            cboNameLookup.TabIndex = 0;
            // 
            // lstAppt
            // 
            lstAppt.FormattingEnabled = true;
            lstAppt.Location = new Point(43, 187);
            lstAppt.Name = "lstAppt";
            lstAppt.Size = new Size(983, 356);
            lstAppt.TabIndex = 1;
            // 
            // btnAddRemoveCust
            // 
            btnAddRemoveCust.Location = new Point(1044, 86);
            btnAddRemoveCust.Name = "btnAddRemoveCust";
            btnAddRemoveCust.Size = new Size(281, 65);
            btnAddRemoveCust.TabIndex = 2;
            btnAddRemoveCust.Text = "Add/Remove &Customer";
            btnAddRemoveCust.UseVisualStyleBackColor = true;
            // 
            // btnAddRemoveAppt
            // 
            btnAddRemoveAppt.Location = new Point(1044, 209);
            btnAddRemoveAppt.Name = "btnAddRemoveAppt";
            btnAddRemoveAppt.Size = new Size(281, 65);
            btnAddRemoveAppt.TabIndex = 3;
            btnAddRemoveAppt.Text = "Add/Remove &Appt";
            btnAddRemoveAppt.UseVisualStyleBackColor = true;
            // 
            // btnViewSummaries
            // 
            btnViewSummaries.Location = new Point(1044, 337);
            btnViewSummaries.Name = "btnViewSummaries";
            btnViewSummaries.Size = new Size(281, 66);
            btnViewSummaries.TabIndex = 4;
            btnViewSummaries.Text = "View &Summaries";
            btnViewSummaries.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1066, 475);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(259, 63);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 40);
            label1.Name = "label1";
            label1.Size = new Size(188, 32);
            label1.TabIndex = 6;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 143);
            label2.Name = "label2";
            label2.Size = new Size(197, 32);
            label2.TabIndex = 7;
            label2.Text = "Appointment List";
            // 
            // Form1
            // 
            AcceptButton = btnAddRemoveCust;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(1352, 611);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnViewSummaries);
            Controls.Add(btnAddRemoveAppt);
            Controls.Add(btnAddRemoveCust);
            Controls.Add(lstAppt);
            Controls.Add(cboNameLookup);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboNameLookup;
        private ListBox lstAppt;
        private Button btnAddRemoveCust;
        private Button btnAddRemoveAppt;
        private Button btnViewSummaries;
        private Button btnExit;
        private Label label1;
        private Label label2;
    }
}
