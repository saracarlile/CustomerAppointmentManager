namespace CustomerAppointmentManager
{
    partial class CalendarForm
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
            this.viewAppointmentsTitle = new System.Windows.Forms.Label();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.ApptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CretBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportPanel = new System.Windows.Forms.Panel();
            this.byWeekRadioButton = new System.Windows.Forms.RadioButton();
            this.byMonthRadioButton = new System.Windows.Forms.RadioButton();
            this.mainScreenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            this.reportPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewAppointmentsTitle
            // 
            this.viewAppointmentsTitle.AutoSize = true;
            this.viewAppointmentsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAppointmentsTitle.Location = new System.Drawing.Point(23, 32);
            this.viewAppointmentsTitle.Name = "viewAppointmentsTitle";
            this.viewAppointmentsTitle.Size = new System.Drawing.Size(283, 20);
            this.viewAppointmentsTitle.TabIndex = 0;
            this.viewAppointmentsTitle.Text = "View Appointments Calendar Type";
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToAddRows = false;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApptID,
            this.CustID,
            this.UseID,
            this.Type,
            this.Start,
            this.End,
            this.CretBy});
            this.AppointmentsDataGridView.Location = new System.Drawing.Point(12, 64);
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            this.AppointmentsDataGridView.Size = new System.Drawing.Size(849, 299);
            this.AppointmentsDataGridView.TabIndex = 1;
            // 
            // ApptID
            // 
            this.ApptID.DataPropertyName = "appointmentId";
            this.ApptID.HeaderText = "Appointment ID";
            this.ApptID.Name = "ApptID";
            this.ApptID.ReadOnly = true;
            // 
            // CustID
            // 
            this.CustID.DataPropertyName = "customerId";
            this.CustID.HeaderText = "Customer ID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            // 
            // UseID
            // 
            this.UseID.DataPropertyName = "userId";
            this.UseID.HeaderText = "User ID";
            this.UseID.Name = "UseID";
            this.UseID.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Start
            // 
            this.Start.DataPropertyName = "start";
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            // 
            // End
            // 
            this.End.DataPropertyName = "end";
            this.End.HeaderText = "End";
            this.End.Name = "End";
            this.End.ReadOnly = true;
            // 
            // CretBy
            // 
            this.CretBy.DataPropertyName = "createdBy";
            this.CretBy.HeaderText = "Created By";
            this.CretBy.Name = "CretBy";
            this.CretBy.ReadOnly = true;
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.byWeekRadioButton);
            this.reportPanel.Controls.Add(this.byMonthRadioButton);
            this.reportPanel.Location = new System.Drawing.Point(12, 397);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(400, 100);
            this.reportPanel.TabIndex = 2;
            // 
            // byWeekRadioButton
            // 
            this.byWeekRadioButton.AutoSize = true;
            this.byWeekRadioButton.Location = new System.Drawing.Point(25, 60);
            this.byWeekRadioButton.Name = "byWeekRadioButton";
            this.byWeekRadioButton.Size = new System.Drawing.Size(323, 20);
            this.byWeekRadioButton.TabIndex = 1;
            this.byWeekRadioButton.Text = "View appointments for this week (next seven days)";
            this.byWeekRadioButton.UseVisualStyleBackColor = true;
            this.byWeekRadioButton.CheckedChanged += new System.EventHandler(this.byWeekRadioButton_CheckedChanged);
            // 
            // byMonthRadioButton
            // 
            this.byMonthRadioButton.AutoSize = true;
            this.byMonthRadioButton.Location = new System.Drawing.Point(25, 18);
            this.byMonthRadioButton.Name = "byMonthRadioButton";
            this.byMonthRadioButton.Size = new System.Drawing.Size(219, 20);
            this.byMonthRadioButton.TabIndex = 0;
            this.byMonthRadioButton.Text = "View appointments for this month";
            this.byMonthRadioButton.UseVisualStyleBackColor = true;
            this.byMonthRadioButton.CheckedChanged += new System.EventHandler(this.byMonthRadioButton_CheckedChanged);
            // 
            // mainScreenBtn
            // 
            this.mainScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenBtn.Location = new System.Drawing.Point(538, 411);
            this.mainScreenBtn.Name = "mainScreenBtn";
            this.mainScreenBtn.Size = new System.Drawing.Size(212, 23);
            this.mainScreenBtn.TabIndex = 3;
            this.mainScreenBtn.Text = "Return to Main Screen";
            this.mainScreenBtn.UseVisualStyleBackColor = true;
            this.mainScreenBtn.Click += new System.EventHandler(this.mainScreenBtn_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.mainScreenBtn);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.AppointmentsDataGridView);
            this.Controls.Add(this.viewAppointmentsTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalendarForm";
            this.Text = "Appointment Calendar";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            this.reportPanel.ResumeLayout(false);
            this.reportPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewAppointmentsTitle;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn End;
        private System.Windows.Forms.DataGridViewTextBoxColumn CretBy;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.RadioButton byWeekRadioButton;
        private System.Windows.Forms.RadioButton byMonthRadioButton;
        private System.Windows.Forms.Button mainScreenBtn;
    }
}