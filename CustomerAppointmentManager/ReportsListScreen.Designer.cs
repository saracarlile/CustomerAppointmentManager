namespace CustomerAppointmentManager
{
    partial class ReportsListScreen
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
            this.subtitle2lbl = new System.Windows.Forms.Label();
            this.appByMonthScreen = new System.Windows.Forms.Button();
            this.apptsByConsultant = new System.Windows.Forms.Button();
            this.appointmentsBeforeNoon = new System.Windows.Forms.Button();
            this.mainScreenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.Location = new System.Drawing.Point(35, 13);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(169, 20);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "Reports List Screen";
            // 
            // subtitle2lbl
            // 
            this.subtitle2lbl.AutoSize = true;
            this.subtitle2lbl.Location = new System.Drawing.Point(39, 50);
            this.subtitle2lbl.Name = "subtitle2lbl";
            this.subtitle2lbl.Size = new System.Drawing.Size(252, 16);
            this.subtitle2lbl.TabIndex = 1;
            this.subtitle2lbl.Text = "Click on a button below to launch a report.";
            // 
            // appByMonthScreen
            // 
            this.appByMonthScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appByMonthScreen.Location = new System.Drawing.Point(39, 117);
            this.appByMonthScreen.Name = "appByMonthScreen";
            this.appByMonthScreen.Size = new System.Drawing.Size(291, 23);
            this.appByMonthScreen.TabIndex = 2;
            this.appByMonthScreen.Text = "Appointments By Month";
            this.appByMonthScreen.UseVisualStyleBackColor = true;
            this.appByMonthScreen.Click += new System.EventHandler(this.appByMonthScreen_Click);
            // 
            // apptsByConsultant
            // 
            this.apptsByConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptsByConsultant.Location = new System.Drawing.Point(39, 187);
            this.apptsByConsultant.Name = "apptsByConsultant";
            this.apptsByConsultant.Size = new System.Drawing.Size(291, 23);
            this.apptsByConsultant.TabIndex = 3;
            this.apptsByConsultant.Text = "Appointments By Consultant";
            this.apptsByConsultant.UseVisualStyleBackColor = true;
            this.apptsByConsultant.Click += new System.EventHandler(this.apptsByConsultant_Click);
            // 
            // appointmentsBeforeNoon
            // 
            this.appointmentsBeforeNoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsBeforeNoon.Location = new System.Drawing.Point(39, 257);
            this.appointmentsBeforeNoon.Name = "appointmentsBeforeNoon";
            this.appointmentsBeforeNoon.Size = new System.Drawing.Size(288, 23);
            this.appointmentsBeforeNoon.TabIndex = 4;
            this.appointmentsBeforeNoon.Text = "Appointments Before Noon";
            this.appointmentsBeforeNoon.UseVisualStyleBackColor = true;
            this.appointmentsBeforeNoon.Click += new System.EventHandler(this.appointmentsBeforeNoon_Click);
            // 
            // mainScreenBtn
            // 
            this.mainScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenBtn.Location = new System.Drawing.Point(39, 412);
            this.mainScreenBtn.Name = "mainScreenBtn";
            this.mainScreenBtn.Size = new System.Drawing.Size(192, 23);
            this.mainScreenBtn.TabIndex = 5;
            this.mainScreenBtn.Text = "Return to Main Screen";
            this.mainScreenBtn.UseVisualStyleBackColor = true;
            this.mainScreenBtn.Click += new System.EventHandler(this.mainScreenBtn_Click);
            // 
            // ReportsListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.mainScreenBtn);
            this.Controls.Add(this.appointmentsBeforeNoon);
            this.Controls.Add(this.apptsByConsultant);
            this.Controls.Add(this.appByMonthScreen);
            this.Controls.Add(this.subtitle2lbl);
            this.Controls.Add(this.titlelbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsListScreen";
            this.Text = "Reports Screen";
            this.Load += new System.EventHandler(this.ReportsListScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label subtitle2lbl;
        private System.Windows.Forms.Button appByMonthScreen;
        private System.Windows.Forms.Button apptsByConsultant;
        private System.Windows.Forms.Button appointmentsBeforeNoon;
        private System.Windows.Forms.Button mainScreenBtn;
    }
}