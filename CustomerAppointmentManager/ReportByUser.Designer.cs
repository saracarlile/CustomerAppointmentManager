namespace CustomerAppointmentManager
{
    partial class ReportByUser
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
            this.titlelbl = new System.Windows.Forms.Label();
            this.reportRichTextBox = new System.Windows.Forms.RichTextBox();
            this.reportsListScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(25, 26);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(245, 20);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "View appointments by Consultant";
            // 
            // reportRichTextBox
            // 
            this.reportRichTextBox.Location = new System.Drawing.Point(29, 67);
            this.reportRichTextBox.Name = "reportRichTextBox";
            this.reportRichTextBox.ReadOnly = true;
            this.reportRichTextBox.Size = new System.Drawing.Size(814, 471);
            this.reportRichTextBox.TabIndex = 1;
            this.reportRichTextBox.Text = "";
            // 
            // reportsListScreen
            // 
            this.reportsListScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsListScreen.Location = new System.Drawing.Point(401, 26);
            this.reportsListScreen.Name = "reportsListScreen";
            this.reportsListScreen.Size = new System.Drawing.Size(231, 23);
            this.reportsListScreen.TabIndex = 2;
            this.reportsListScreen.Text = "Return to Reports List Screen";
            this.reportsListScreen.UseVisualStyleBackColor = true;
            this.reportsListScreen.Click += new System.EventHandler(this.reportsListScreen_Click);
            // 
            // ReportByUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.reportsListScreen);
            this.Controls.Add(this.reportRichTextBox);
            this.Controls.Add(this.titlelbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportByUser";
            this.Text = "Report By Consultant";
            this.Load += new System.EventHandler(this.ReportByUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.RichTextBox reportRichTextBox;
        private System.Windows.Forms.Button reportsListScreen;
    }
}