namespace CustomerAppointmentManager
{
    partial class AppointmentsBeforeNoon
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
            this.apptlbl = new System.Windows.Forms.Label();
            this.reportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.returnToReportsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apptlbl
            // 
            this.apptlbl.AutoSize = true;
            this.apptlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptlbl.Location = new System.Drawing.Point(42, 13);
            this.apptlbl.Name = "apptlbl";
            this.apptlbl.Size = new System.Drawing.Size(512, 20);
            this.apptlbl.TabIndex = 0;
            this.apptlbl.Text = "View a listing of appointments that start before 12pm (any day)";
            // 
            // reportRichTextBox
            // 
            this.reportRichTextBox.Location = new System.Drawing.Point(46, 49);
            this.reportRichTextBox.Name = "reportRichTextBox";
            this.reportRichTextBox.ReadOnly = true;
            this.reportRichTextBox.Size = new System.Drawing.Size(782, 481);
            this.reportRichTextBox.TabIndex = 1;
            this.reportRichTextBox.Text = "";
            // 
            // returnToReportsList
            // 
            this.returnToReportsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToReportsList.Location = new System.Drawing.Point(573, 13);
            this.returnToReportsList.Name = "returnToReportsList";
            this.returnToReportsList.Size = new System.Drawing.Size(255, 23);
            this.returnToReportsList.TabIndex = 2;
            this.returnToReportsList.Text = "Return to Reports List";
            this.returnToReportsList.UseVisualStyleBackColor = true;
            this.returnToReportsList.Click += new System.EventHandler(this.returnToReportsList_Click);
            // 
            // AppointmentsBeforeNoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.returnToReportsList);
            this.Controls.Add(this.reportRichTextBox);
            this.Controls.Add(this.apptlbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AppointmentsBeforeNoon";
            this.Text = "Appointments Before Noon";
            this.Load += new System.EventHandler(this.AppointmentsBeforeNoon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label apptlbl;
        private System.Windows.Forms.RichTextBox reportRichTextBox;
        private System.Windows.Forms.Button returnToReportsList;
    }
}