namespace CustomerAppointmentManager
{
    partial class AddAppointmentForm
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
            this.addTitleLbl = new System.Windows.Forms.Label();
            this.appointmentIdlbl = new System.Windows.Forms.Label();
            this.appointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDLbl = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.Appointmentlbl = new System.Windows.Forms.Label();
            this.appointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.startLbl = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endlbl = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.schedulelbl = new System.Windows.Forms.Label();
            this.schedlbl = new System.Windows.Forms.Label();
            this.currentTimeZonelbl = new System.Windows.Forms.Label();
            this.currentTimeZoneValue = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerIDComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addTitleLbl
            // 
            this.addTitleLbl.AutoSize = true;
            this.addTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTitleLbl.Location = new System.Drawing.Point(38, 25);
            this.addTitleLbl.Name = "addTitleLbl";
            this.addTitleLbl.Size = new System.Drawing.Size(187, 20);
            this.addTitleLbl.TabIndex = 0;
            this.addTitleLbl.Text = "Add New Appointment";
            // 
            // appointmentIdlbl
            // 
            this.appointmentIdlbl.AutoSize = true;
            this.appointmentIdlbl.Location = new System.Drawing.Point(42, 66);
            this.appointmentIdlbl.Name = "appointmentIdlbl";
            this.appointmentIdlbl.Size = new System.Drawing.Size(99, 16);
            this.appointmentIdlbl.TabIndex = 1;
            this.appointmentIdlbl.Text = "Appointment ID";
            // 
            // appointmentIDTextBox
            // 
            this.appointmentIDTextBox.Location = new System.Drawing.Point(185, 60);
            this.appointmentIDTextBox.Name = "appointmentIDTextBox";
            this.appointmentIDTextBox.ReadOnly = true;
            this.appointmentIDTextBox.Size = new System.Drawing.Size(132, 22);
            this.appointmentIDTextBox.TabIndex = 2;
            // 
            // CustomerIDLbl
            // 
            this.CustomerIDLbl.AutoSize = true;
            this.CustomerIDLbl.Location = new System.Drawing.Point(42, 107);
            this.CustomerIDLbl.Name = "CustomerIDLbl";
            this.CustomerIDLbl.Size = new System.Drawing.Size(81, 16);
            this.CustomerIDLbl.TabIndex = 3;
            this.CustomerIDLbl.Text = "Customer ID";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(42, 159);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(105, 16);
            this.customerName.TabIndex = 5;
            this.customerName.Text = "Customer Name";
            // 
            // Appointmentlbl
            // 
            this.Appointmentlbl.AutoSize = true;
            this.Appointmentlbl.Location = new System.Drawing.Point(42, 224);
            this.Appointmentlbl.Name = "Appointmentlbl";
            this.Appointmentlbl.Size = new System.Drawing.Size(118, 16);
            this.Appointmentlbl.TabIndex = 7;
            this.Appointmentlbl.Text = "Appointment Type";
            // 
            // appointmentTypeComboBox
            // 
            this.appointmentTypeComboBox.FormattingEnabled = true;
            this.appointmentTypeComboBox.Items.AddRange(new object[] {
            "Scrum",
            "Presentation",
            "Planning",
            "Wrap-Up"});
            this.appointmentTypeComboBox.Location = new System.Drawing.Point(185, 216);
            this.appointmentTypeComboBox.Name = "appointmentTypeComboBox";
            this.appointmentTypeComboBox.Size = new System.Drawing.Size(253, 24);
            this.appointmentTypeComboBox.TabIndex = 8;
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Location = new System.Drawing.Point(42, 277);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(35, 16);
            this.startLbl.TabIndex = 9;
            this.startLbl.Text = "Start";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(185, 272);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(341, 22);
            this.startDateTimePicker.TabIndex = 10;
            // 
            // endlbl
            // 
            this.endlbl.AutoSize = true;
            this.endlbl.Location = new System.Drawing.Point(45, 326);
            this.endlbl.Name = "endlbl";
            this.endlbl.Size = new System.Drawing.Size(32, 16);
            this.endlbl.TabIndex = 11;
            this.endlbl.Text = "End";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(185, 326);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(341, 22);
            this.endDateTimePicker.TabIndex = 12;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(42, 398);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(130, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(222, 398);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(164, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // schedulelbl
            // 
            this.schedulelbl.AutoSize = true;
            this.schedulelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulelbl.Location = new System.Drawing.Point(45, 454);
            this.schedulelbl.Name = "schedulelbl";
            this.schedulelbl.Size = new System.Drawing.Size(421, 16);
            this.schedulelbl.TabIndex = 15;
            this.schedulelbl.Text = "Appointments can only be scheduled from 8am to 5pm your local time.";
            // 
            // schedlbl
            // 
            this.schedlbl.AutoSize = true;
            this.schedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedlbl.Location = new System.Drawing.Point(48, 485);
            this.schedlbl.Name = "schedlbl";
            this.schedlbl.Size = new System.Drawing.Size(425, 16);
            this.schedlbl.TabIndex = 16;
            this.schedlbl.Text = "You cannot schedule appointments that overlap existing appointments.";
            // 
            // currentTimeZonelbl
            // 
            this.currentTimeZonelbl.AutoSize = true;
            this.currentTimeZonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeZonelbl.Location = new System.Drawing.Point(51, 518);
            this.currentTimeZonelbl.Name = "currentTimeZonelbl";
            this.currentTimeZonelbl.Size = new System.Drawing.Size(121, 16);
            this.currentTimeZonelbl.TabIndex = 17;
            this.currentTimeZonelbl.Text = "Current Time Zone:";
            // 
            // currentTimeZoneValue
            // 
            this.currentTimeZoneValue.AutoSize = true;
            this.currentTimeZoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeZoneValue.Location = new System.Drawing.Point(185, 520);
            this.currentTimeZoneValue.Name = "currentTimeZoneValue";
            this.currentTimeZoneValue.Size = new System.Drawing.Size(145, 16);
            this.currentTimeZoneValue.TabIndex = 18;
            this.currentTimeZoneValue.Text = "currentTimeZoneValue";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(188, 159);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(250, 22);
            this.customerNameTextBox.TabIndex = 19;
            // 
            // customerIDComboBox
            // 
            this.customerIDComboBox.FormattingEnabled = true;
            this.customerIDComboBox.Location = new System.Drawing.Point(185, 107);
            this.customerIDComboBox.Name = "customerIDComboBox";
            this.customerIDComboBox.Size = new System.Drawing.Size(145, 24);
            this.customerIDComboBox.TabIndex = 20;
            this.customerIDComboBox.SelectedValueChanged += new System.EventHandler(this.customerIDComboBox_SelectedValueChanged);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.customerIDComboBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.currentTimeZoneValue);
            this.Controls.Add(this.currentTimeZonelbl);
            this.Controls.Add(this.schedlbl);
            this.Controls.Add(this.schedulelbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.endlbl);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.appointmentTypeComboBox);
            this.Controls.Add(this.Appointmentlbl);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.CustomerIDLbl);
            this.Controls.Add(this.appointmentIDTextBox);
            this.Controls.Add(this.appointmentIdlbl);
            this.Controls.Add(this.addTitleLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAppointmentForm";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addTitleLbl;
        private System.Windows.Forms.Label appointmentIdlbl;
        private System.Windows.Forms.TextBox appointmentIDTextBox;
        private System.Windows.Forms.Label CustomerIDLbl;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label Appointmentlbl;
        private System.Windows.Forms.ComboBox appointmentTypeComboBox;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label endlbl;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label schedulelbl;
        private System.Windows.Forms.Label schedlbl;
        private System.Windows.Forms.Label currentTimeZonelbl;
        private System.Windows.Forms.Label currentTimeZoneValue;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.ComboBox customerIDComboBox;
    }
}