namespace CS206_Final_Project___Spa_CSM_system
{
    partial class ApptSummaryForm
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
            dateStartDate = new DateTimePicker();
            dateEndDate = new DateTimePicker();
            cboService = new ComboBox();
            listBox1 = new ListBox();
            btnRun = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // dateStartDate
            // 
            dateStartDate.Location = new Point(29, 50);
            dateStartDate.Name = "dateStartDate";
            dateStartDate.Size = new Size(400, 39);
            dateStartDate.TabIndex = 0;
            // 
            // dateEndDate
            // 
            dateEndDate.Location = new Point(29, 161);
            dateEndDate.Name = "dateEndDate";
            dateEndDate.Size = new Size(400, 39);
            dateEndDate.TabIndex = 1;
            // 
            // cboService
            // 
            cboService.FormattingEnabled = true;
            cboService.Location = new Point(29, 285);
            cboService.Name = "cboService";
            cboService.Size = new Size(391, 40);
            cboService.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(467, 161);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(718, 420);
            listBox1.TabIndex = 3;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(467, 66);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(164, 46);
            btnRun.TabIndex = 4;
            btnRun.Text = "&Run";
            btnRun.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1035, 66);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 6;
            label1.Text = "Start Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 125);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 7;
            label2.Text = "End Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 241);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 8;
            label3.Text = "Service";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 125);
            label4.Name = "label4";
            label4.Size = new Size(280, 32);
            label4.TabIndex = 9;
            label4.Text = "Appointment Summaries";
            // 
            // ApptSummaryForm
            // 
            AcceptButton = btnRun;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1248, 630);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnRun);
            Controls.Add(listBox1);
            Controls.Add(cboService);
            Controls.Add(dateEndDate);
            Controls.Add(dateStartDate);
            Name = "ApptSummaryForm";
            Text = "ApptSummaryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateStartDate;
        private DateTimePicker dateEndDate;
        private ComboBox cboService;
        private ListBox listBox1;
        private Button btnRun;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}