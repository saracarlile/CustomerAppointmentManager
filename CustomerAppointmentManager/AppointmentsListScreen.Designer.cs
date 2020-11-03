namespace CustomerAppointmentManager
{
    partial class AppointmentsListScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AppointmentsListLabel = new System.Windows.Forms.Label();
            this.AppointmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.apptIDcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIdCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u069LrDataSet = new CustomerAppointmentManager.U069LrDataSet();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.appointmentTableAdapter();
            this.currentTimeZoneLabel = new System.Windows.Forms.Label();
            this.currentTimeZoneLabelValue = new System.Windows.Forms.Label();
            this.newApptBtn = new System.Windows.Forms.Button();
            this.editApptBtn = new System.Windows.Forms.Button();
            this.deleteApptBtn = new System.Windows.Forms.Button();
            this.mainFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentsListLabel
            // 
            this.AppointmentsListLabel.AutoSize = true;
            this.AppointmentsListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsListLabel.Location = new System.Drawing.Point(12, 29);
            this.AppointmentsListLabel.Name = "AppointmentsListLabel";
            this.AppointmentsListLabel.Size = new System.Drawing.Size(137, 20);
            this.AppointmentsListLabel.TabIndex = 0;
            this.AppointmentsListLabel.Text = "Appointments List";
            // 
            // AppointmentsDataGridView
            // 
            this.AppointmentsDataGridView.AllowUserToAddRows = false;
            this.AppointmentsDataGridView.AllowUserToDeleteRows = false;
            this.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apptIDcol,
            this.custIdCol,
            this.UserIdCol,
            this.TypeCol,
            this.StartCol,
            this.EndCol,
            this.CreatedByCol});
            this.AppointmentsDataGridView.Location = new System.Drawing.Point(12, 69);
            this.AppointmentsDataGridView.Name = "AppointmentsDataGridView";
            this.AppointmentsDataGridView.ReadOnly = true;
            this.AppointmentsDataGridView.Size = new System.Drawing.Size(860, 258);
            this.AppointmentsDataGridView.TabIndex = 1;
            this.AppointmentsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDataGridView_CellClick);
            // 
            // apptIDcol
            // 
            this.apptIDcol.DataPropertyName = "appointmentId";
            this.apptIDcol.HeaderText = "Appointment ID";
            this.apptIDcol.Name = "apptIDcol";
            this.apptIDcol.ReadOnly = true;
            // 
            // custIdCol
            // 
            this.custIdCol.DataPropertyName = "customerId";
            this.custIdCol.HeaderText = "Customer ID";
            this.custIdCol.Name = "custIdCol";
            this.custIdCol.ReadOnly = true;
            // 
            // UserIdCol
            // 
            this.UserIdCol.DataPropertyName = "userId";
            this.UserIdCol.HeaderText = "User ID";
            this.UserIdCol.Name = "UserIdCol";
            this.UserIdCol.ReadOnly = true;
            // 
            // TypeCol
            // 
            this.TypeCol.DataPropertyName = "type";
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.ReadOnly = true;
            // 
            // StartCol
            // 
            this.StartCol.DataPropertyName = "start";
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.StartCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.StartCol.HeaderText = "Start";
            this.StartCol.Name = "StartCol";
            this.StartCol.ReadOnly = true;
            // 
            // EndCol
            // 
            this.EndCol.DataPropertyName = "end";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.EndCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.EndCol.HeaderText = "End";
            this.EndCol.Name = "EndCol";
            this.EndCol.ReadOnly = true;
            // 
            // CreatedByCol
            // 
            this.CreatedByCol.DataPropertyName = "createdBy";
            this.CreatedByCol.HeaderText = "Created By";
            this.CreatedByCol.Name = "CreatedByCol";
            this.CreatedByCol.ReadOnly = true;
            // 
            // u069LrDataSet
            // 
            this.u069LrDataSet.DataSetName = "U069LrDataSet";
            this.u069LrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.u069LrDataSet;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // currentTimeZoneLabel
            // 
            this.currentTimeZoneLabel.AutoSize = true;
            this.currentTimeZoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeZoneLabel.Location = new System.Drawing.Point(12, 343);
            this.currentTimeZoneLabel.Name = "currentTimeZoneLabel";
            this.currentTimeZoneLabel.Size = new System.Drawing.Size(121, 16);
            this.currentTimeZoneLabel.TabIndex = 2;
            this.currentTimeZoneLabel.Text = "Current Time Zone:";
            // 
            // currentTimeZoneLabelValue
            // 
            this.currentTimeZoneLabelValue.AutoSize = true;
            this.currentTimeZoneLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeZoneLabelValue.Location = new System.Drawing.Point(139, 343);
            this.currentTimeZoneLabelValue.Name = "currentTimeZoneLabelValue";
            this.currentTimeZoneLabelValue.Size = new System.Drawing.Size(111, 16);
            this.currentTimeZoneLabelValue.TabIndex = 3;
            this.currentTimeZoneLabelValue.Text = "Time Zone Value";
            // 
            // newApptBtn
            // 
            this.newApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newApptBtn.Location = new System.Drawing.Point(16, 389);
            this.newApptBtn.Name = "newApptBtn";
            this.newApptBtn.Size = new System.Drawing.Size(234, 23);
            this.newApptBtn.TabIndex = 4;
            this.newApptBtn.Text = "Create  New Appointment";
            this.newApptBtn.UseVisualStyleBackColor = true;
            this.newApptBtn.Click += new System.EventHandler(this.newApptBtn_Click);
            // 
            // editApptBtn
            // 
            this.editApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editApptBtn.Location = new System.Drawing.Point(16, 431);
            this.editApptBtn.Name = "editApptBtn";
            this.editApptBtn.Size = new System.Drawing.Size(234, 23);
            this.editApptBtn.TabIndex = 5;
            this.editApptBtn.Text = "Edit Existing Appointment";
            this.editApptBtn.UseVisualStyleBackColor = true;
            this.editApptBtn.Click += new System.EventHandler(this.editApptBtn_Click);
            // 
            // deleteApptBtn
            // 
            this.deleteApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApptBtn.Location = new System.Drawing.Point(16, 480);
            this.deleteApptBtn.Name = "deleteApptBtn";
            this.deleteApptBtn.Size = new System.Drawing.Size(234, 23);
            this.deleteApptBtn.TabIndex = 6;
            this.deleteApptBtn.Text = "Delete Appointment";
            this.deleteApptBtn.UseVisualStyleBackColor = true;
            this.deleteApptBtn.Click += new System.EventHandler(this.deleteApptBtn_Click);
            // 
            // mainFormButton
            // 
            this.mainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFormButton.Location = new System.Drawing.Point(449, 388);
            this.mainFormButton.Name = "mainFormButton";
            this.mainFormButton.Size = new System.Drawing.Size(200, 23);
            this.mainFormButton.TabIndex = 7;
            this.mainFormButton.Text = "Return to Main Screen";
            this.mainFormButton.UseVisualStyleBackColor = true;
            this.mainFormButton.Click += new System.EventHandler(this.mainFormButton_Click);
            // 
            // AppointmentsListScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 664);
            this.Controls.Add(this.mainFormButton);
            this.Controls.Add(this.deleteApptBtn);
            this.Controls.Add(this.editApptBtn);
            this.Controls.Add(this.newApptBtn);
            this.Controls.Add(this.currentTimeZoneLabelValue);
            this.Controls.Add(this.currentTimeZoneLabel);
            this.Controls.Add(this.AppointmentsDataGridView);
            this.Controls.Add(this.AppointmentsListLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppointmentsListScreen";
            this.Text = "AppointmentsListScreen";
            this.Load += new System.EventHandler(this.AppointmentsListScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppointmentsListLabel;
        private System.Windows.Forms.DataGridView AppointmentsDataGridView;
        private U069LrDataSet u069LrDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private U069LrDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptIDcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIdCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedByCol;
        private System.Windows.Forms.Label currentTimeZoneLabel;
        private System.Windows.Forms.Label currentTimeZoneLabelValue;
        private System.Windows.Forms.Button newApptBtn;
        private System.Windows.Forms.Button editApptBtn;
        private System.Windows.Forms.Button deleteApptBtn;
        private System.Windows.Forms.Button mainFormButton;
    }
}