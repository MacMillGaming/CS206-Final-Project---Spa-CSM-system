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
            cboNameLookup.BackColor = Color.White;
            cboNameLookup.FormattingEnabled = true;
            cboNameLookup.Location = new Point(23, 40);
            cboNameLookup.Margin = new Padding(2, 1, 2, 1);
            cboNameLookup.Name = "cboNameLookup";
            cboNameLookup.Size = new Size(344, 23);
            cboNameLookup.TabIndex = 0;
            cboNameLookup.SelectedIndexChanged += cboNameLookup_SelectedIndexChanged;
            // 
            // lstAppt
            // 
            lstAppt.BackColor = Color.White;
            lstAppt.FormattingEnabled = true;
            lstAppt.ItemHeight = 15;
            lstAppt.Location = new Point(23, 88);
            lstAppt.Margin = new Padding(2, 1, 2, 1);
            lstAppt.Name = "lstAppt";
            lstAppt.Size = new Size(531, 169);
            lstAppt.TabIndex = 1;
            // 
            // btnAddRemoveCust
            // 
            btnAddRemoveCust.BackColor = Color.Pink;
            btnAddRemoveCust.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddRemoveCust.Location = new Point(562, 40);
            btnAddRemoveCust.Margin = new Padding(2, 1, 2, 1);
            btnAddRemoveCust.Name = "btnAddRemoveCust";
            btnAddRemoveCust.Size = new Size(151, 30);
            btnAddRemoveCust.TabIndex = 2;
            btnAddRemoveCust.Text = "Add/Remove &Customer";
            btnAddRemoveCust.UseVisualStyleBackColor = false;
            btnAddRemoveCust.Click += btnAddRemoveCust_Click;
            // 
            // btnAddRemoveAppt
            // 
            btnAddRemoveAppt.BackColor = Color.Pink;
            btnAddRemoveAppt.Font = new Font("Mongolian Baiti", 9.75F);
            btnAddRemoveAppt.Location = new Point(562, 98);
            btnAddRemoveAppt.Margin = new Padding(2, 1, 2, 1);
            btnAddRemoveAppt.Name = "btnAddRemoveAppt";
            btnAddRemoveAppt.Size = new Size(151, 30);
            btnAddRemoveAppt.TabIndex = 3;
            btnAddRemoveAppt.Text = "Add/Remove &Appt";
            btnAddRemoveAppt.UseVisualStyleBackColor = false;
            btnAddRemoveAppt.Click += btnAddRemoveAppt_Click;
            // 
            // btnViewSummaries
            // 
            btnViewSummaries.BackColor = Color.Pink;
            btnViewSummaries.BackgroundImageLayout = ImageLayout.Stretch;
            btnViewSummaries.Cursor = Cursors.IBeam;
            btnViewSummaries.Font = new Font("Mongolian Baiti", 9.75F);
            btnViewSummaries.ForeColor = SystemColors.ActiveCaptionText;
            btnViewSummaries.Location = new Point(562, 158);
            btnViewSummaries.Margin = new Padding(2, 1, 2, 1);
            btnViewSummaries.Name = "btnViewSummaries";
            btnViewSummaries.Size = new Size(151, 31);
            btnViewSummaries.TabIndex = 4;
            btnViewSummaries.Text = "View &Summaries";
            btnViewSummaries.UseVisualStyleBackColor = false;
            btnViewSummaries.Click += btnViewSummaries_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Pink;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.Font = new Font("Mongolian Baiti", 9.75F);
            btnExit.Location = new Point(562, 214);
            btnExit.Margin = new Padding(2, 1, 2, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(139, 30);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 6;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 7;
            label2.Text = "Appointment List";
            // 
            // Form1
            // 
            AcceptButton = btnAddRemoveCust;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            CancelButton = btnExit;
            ClientSize = new Size(728, 286);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnViewSummaries);
            Controls.Add(btnAddRemoveAppt);
            Controls.Add(btnAddRemoveCust);
            Controls.Add(lstAppt);
            Controls.Add(cboNameLookup);
            Name = "Form1";
            Text = "Form1";
            Load += form1_Load;
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
