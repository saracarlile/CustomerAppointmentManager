namespace CustomerAppointmentManager
{
    partial class AppointmentsByMonthReport
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
            this.reportTextBox = new System.Windows.Forms.RichTextBox();
            this.returnToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(37, 28);
            this.titlelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(200, 20);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "Appointments By Month";
            // 
            // reportTextBox
            // 
            this.reportTextBox.Location = new System.Drawing.Point(41, 87);
            this.reportTextBox.Name = "reportTextBox";
            this.reportTextBox.ReadOnly = true;
            this.reportTextBox.Size = new System.Drawing.Size(776, 429);
            this.reportTextBox.TabIndex = 1;
            this.reportTextBox.Text = "";
            // 
            // returnToList
            // 
            this.returnToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToList.Location = new System.Drawing.Point(428, 28);
            this.returnToList.Name = "returnToList";
            this.returnToList.Size = new System.Drawing.Size(242, 23);
            this.returnToList.TabIndex = 2;
            this.returnToList.Text = "Return to Reports List Screen";
            this.returnToList.UseVisualStyleBackColor = true;
            this.returnToList.Click += new System.EventHandler(this.returnToList_Click);
            // 
            // AppointmentsByMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.returnToList);
            this.Controls.Add(this.reportTextBox);
            this.Controls.Add(this.titlelbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppointmentsByMonthReport";
            this.Text = "AppointmentsByMonthReport";
            this.Load += new System.EventHandler(this.AppointmentsByMonthReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.RichTextBox reportTextBox;
        private System.Windows.Forms.Button returnToList;
    }
}