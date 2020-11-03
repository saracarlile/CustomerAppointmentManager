namespace CustomerAppointmentManager
{
    partial class EditAppointmentForm
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
            this.components = new System.ComponentModel.Container();
            this.editApptTitleLbl = new System.Windows.Forms.Label();
            this.apptIDLabel = new System.Windows.Forms.Label();
            this.appointmentIDTextBox = new System.Windows.Forms.TextBox();
            this.custIDLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.appointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u069LrDataSet = new CustomerAppointmentManager.U069LrDataSet();
            this.appointmentTypeLbl = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startlbl = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endlbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.currentTimeZonelbl = new System.Windows.Forms.Label();
            this.currentTimeZoneValue = new System.Windows.Forms.Label();
            this.schedulelbl = new System.Windows.Forms.Label();
            this.overlappinglabel = new System.Windows.Forms.Label();
            this.customerTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.customerTableAdapter();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerIDComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // editApptTitleLbl
            // 
            this.editApptTitleLbl.AutoSize = true;
            this.editApptTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editApptTitleLbl.Location = new System.Drawing.Point(13, 13);
            this.editApptTitleLbl.Name = "editApptTitleLbl";
            this.editApptTitleLbl.Size = new System.Drawing.Size(148, 20);
            this.editApptTitleLbl.TabIndex = 0;
            this.editApptTitleLbl.Text = "Edit Appointment";
            // 
            // apptIDLabel
            // 
            this.apptIDLabel.AutoSize = true;
            this.apptIDLabel.Location = new System.Drawing.Point(12, 56);
            this.apptIDLabel.Name = "apptIDLabel";
            this.apptIDLabel.Size = new System.Drawing.Size(99, 16);
            this.apptIDLabel.TabIndex = 1;
            this.apptIDLabel.Text = "Appointment ID";
            // 
            // appointmentIDTextBox
            // 
            this.appointmentIDTextBox.Location = new System.Drawing.Point(151, 53);
            this.appointmentIDTextBox.Name = "appointmentIDTextBox";
            this.appointmentIDTextBox.ReadOnly = true;
            this.appointmentIDTextBox.Size = new System.Drawing.Size(142, 22);
            this.appointmentIDTextBox.TabIndex = 2;
            // 
            // custIDLabel
            // 
            this.custIDLabel.AutoSize = true;
            this.custIDLabel.Location = new System.Drawing.Point(12, 102);
            this.custIDLabel.Name = "custIDLabel";
            this.custIDLabel.Size = new System.Drawing.Size(84, 16);
            this.custIDLabel.TabIndex = 4;
            this.custIDLabel.Text = "Customer ID ";
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(14, 151);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(105, 16);
            this.customerName.TabIndex = 6;
            this.customerName.Text = "Customer Name";
            // 
            // appointmentTypeComboBox
            // 
            this.appointmentTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.customerBindingSource, "customerName", true));
            this.appointmentTypeComboBox.FormattingEnabled = true;
            this.appointmentTypeComboBox.Items.AddRange(new object[] {
            "Scrum",
            "Presentation",
            "Planning",
            "Wrap-Up"});
            this.appointmentTypeComboBox.Location = new System.Drawing.Point(151, 199);
            this.appointmentTypeComboBox.Name = "appointmentTypeComboBox";
            this.appointmentTypeComboBox.Size = new System.Drawing.Size(217, 24);
            this.appointmentTypeComboBox.TabIndex = 7;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.u069LrDataSet;
            // 
            // u069LrDataSet
            // 
            this.u069LrDataSet.DataSetName = "U069LrDataSet";
            this.u069LrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentTypeLbl
            // 
            this.appointmentTypeLbl.AutoSize = true;
            this.appointmentTypeLbl.Location = new System.Drawing.Point(12, 207);
            this.appointmentTypeLbl.Name = "appointmentTypeLbl";
            this.appointmentTypeLbl.Size = new System.Drawing.Size(118, 16);
            this.appointmentTypeLbl.TabIndex = 8;
            this.appointmentTypeLbl.Text = "Appointment Type";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(151, 254);
            this.startDateTimePicker.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(337, 22);
            this.startDateTimePicker.TabIndex = 9;
            // 
            // startlbl
            // 
            this.startlbl.AutoSize = true;
            this.startlbl.Location = new System.Drawing.Point(14, 254);
            this.startlbl.Name = "startlbl";
            this.startlbl.Size = new System.Drawing.Size(35, 16);
            this.startlbl.TabIndex = 10;
            this.startlbl.Text = "Start";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(151, 307);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(337, 22);
            this.endDateTimePicker.TabIndex = 11;
            // 
            // endlbl
            // 
            this.endlbl.AutoSize = true;
            this.endlbl.Location = new System.Drawing.Point(17, 313);
            this.endlbl.Name = "endlbl";
            this.endlbl.Size = new System.Drawing.Size(32, 16);
            this.endlbl.TabIndex = 12;
            this.endlbl.Text = "End";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(15, 374);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(113, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(177, 374);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 23);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // currentTimeZonelbl
            // 
            this.currentTimeZonelbl.AutoSize = true;
            this.currentTimeZonelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeZonelbl.Location = new System.Drawing.Point(7, 486);
            this.currentTimeZonelbl.Name = "currentTimeZonelbl";
            this.currentTimeZonelbl.Size = new System.Drawing.Size(121, 16);
            this.currentTimeZonelbl.TabIndex = 15;
            this.currentTimeZonelbl.Text = "Current Time Zone:";
            // 
            // currentTimeZoneValue
            // 
            this.currentTimeZoneValue.AutoSize = true;
            this.currentTimeZoneValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeZoneValue.Location = new System.Drawing.Point(134, 486);
            this.currentTimeZoneValue.Name = "currentTimeZoneValue";
            this.currentTimeZoneValue.Size = new System.Drawing.Size(145, 16);
            this.currentTimeZoneValue.TabIndex = 16;
            this.currentTimeZoneValue.Text = "currentTimeZoneValue";
            // 
            // schedulelbl
            // 
            this.schedulelbl.AutoSize = true;
            this.schedulelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schedulelbl.Location = new System.Drawing.Point(7, 427);
            this.schedulelbl.Name = "schedulelbl";
            this.schedulelbl.Size = new System.Drawing.Size(421, 16);
            this.schedulelbl.TabIndex = 17;
            this.schedulelbl.Text = "Appointments can only be scheduled from 8am to 5pm your local time.";
            // 
            // overlappinglabel
            // 
            this.overlappinglabel.AutoSize = true;
            this.overlappinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overlappinglabel.Location = new System.Drawing.Point(7, 456);
            this.overlappinglabel.Name = "overlappinglabel";
            this.overlappinglabel.Size = new System.Drawing.Size(425, 16);
            this.overlappinglabel.TabIndex = 18;
            this.overlappinglabel.Text = "You cannot schedule appointments that overlap existing appointments.";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(151, 146);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(217, 22);
            this.customerNameTextBox.TabIndex = 19;
            // 
            // customerIDComboBox
            // 
            this.customerIDComboBox.FormattingEnabled = true;
            this.customerIDComboBox.Location = new System.Drawing.Point(151, 102);
            this.customerIDComboBox.Name = "customerIDComboBox";
            this.customerIDComboBox.Size = new System.Drawing.Size(142, 24);
            this.customerIDComboBox.TabIndex = 20;
            this.customerIDComboBox.SelectedValueChanged += new System.EventHandler(this.customerIDComboBox_SelectedValueChanged);
            // 
            // EditAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.customerIDComboBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.overlappinglabel);
            this.Controls.Add(this.schedulelbl);
            this.Controls.Add(this.currentTimeZoneValue);
            this.Controls.Add(this.currentTimeZonelbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.endlbl);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startlbl);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.appointmentTypeLbl);
            this.Controls.Add(this.appointmentTypeComboBox);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.custIDLabel);
            this.Controls.Add(this.appointmentIDTextBox);
            this.Controls.Add(this.apptIDLabel);
            this.Controls.Add(this.editApptTitleLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditAppointmentForm";
            this.Text = "Edit Appointment";
            this.Load += new System.EventHandler(this.EditAppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editApptTitleLbl;
        private System.Windows.Forms.Label apptIDLabel;
        private System.Windows.Forms.TextBox appointmentIDTextBox;
        private System.Windows.Forms.Label custIDLabel;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.ComboBox appointmentTypeComboBox;
        private System.Windows.Forms.Label appointmentTypeLbl;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label startlbl;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label endlbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label currentTimeZonelbl;
        private System.Windows.Forms.Label currentTimeZoneValue;
        private System.Windows.Forms.Label schedulelbl;
        private System.Windows.Forms.Label overlappinglabel;
        private U069LrDataSet u069LrDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private U069LrDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.ComboBox customerIDComboBox;
    }
}