namespace CustomerAppointmentManager
{
    partial class CustomersForm
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
            System.Windows.Forms.Label addressIdLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label countryIdLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label cityIdLabel;
            System.Windows.Forms.Label cityLabel;
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u069LrDataSet = new CustomerAppointmentManager.U069LrDataSet();
            this.customerTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new CustomerAppointmentManager.U069LrDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new CustomerAppointmentManager.U069LrDataSetTableAdapters.TableAdapterManager();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.EditCustomerBtn = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.addressTableAdapter();
            this.addressIdTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.cityTableAdapter();
            this.countryIdTextBox = new System.Windows.Forms.TextBox();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.countryTableAdapter();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.cityIdTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.returnToMainScreenBtn = new System.Windows.Forms.Button();
            this.titleCustomersScreen = new System.Windows.Forms.Label();
            addressIdLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            countryIdLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            cityIdLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressIdLabel
            // 
            addressIdLabel.AutoSize = true;
            addressIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressIdLabel.Location = new System.Drawing.Point(109, 640);
            addressIdLabel.Name = "addressIdLabel";
            addressIdLabel.Size = new System.Drawing.Size(59, 13);
            addressIdLabel.TabIndex = 3;
            addressIdLabel.Text = "Address ID";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(86, 354);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(69, 16);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address 1";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(86, 397);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(69, 16);
            address2Label.TabIndex = 7;
            address2Label.Text = "Address 2";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(86, 440);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(82, 16);
            postalCodeLabel.TabIndex = 11;
            postalCodeLabel.Text = "Postal Code";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(86, 486);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(47, 16);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone";
            // 
            // countryIdLabel
            // 
            countryIdLabel.AutoSize = true;
            countryIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryIdLabel.Location = new System.Drawing.Point(354, 640);
            countryIdLabel.Name = "countryIdLabel";
            countryIdLabel.Size = new System.Drawing.Size(57, 13);
            countryIdLabel.TabIndex = 27;
            countryIdLabel.Text = "Country ID";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(86, 569);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(53, 16);
            countryLabel.TabIndex = 32;
            countryLabel.Text = "Country";
            // 
            // cityIdLabel
            // 
            cityIdLabel.AutoSize = true;
            cityIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityIdLabel.Location = new System.Drawing.Point(241, 636);
            cityIdLabel.Name = "cityIdLabel";
            cityIdLabel.Size = new System.Drawing.Size(38, 13);
            cityIdLabel.TabIndex = 9;
            cityIdLabel.Text = "City ID";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(86, 528);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(30, 16);
            cityLabel.TabIndex = 25;
            cityLabel.Text = "City";
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
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.appointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = CustomerAppointmentManager.U069LrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.addressTableAdapter = null;
            this.tableAdapterManager1.appointmentTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.cityTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.countryTableAdapter = null;
            this.tableAdapterManager1.customerTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CustomerAppointmentManager.U069LrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.userTableAdapter = null;
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerBtn.Location = new System.Drawing.Point(703, 83);
            this.addCustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(143, 28);
            this.addCustomerBtn.TabIndex = 1;
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // EditCustomerBtn
            // 
            this.EditCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCustomerBtn.Location = new System.Drawing.Point(703, 133);
            this.EditCustomerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditCustomerBtn.Name = "EditCustomerBtn";
            this.EditCustomerBtn.Size = new System.Drawing.Size(143, 28);
            this.EditCustomerBtn.TabIndex = 2;
            this.EditCustomerBtn.Text = "Edit Customer";
            this.EditCustomerBtn.UseVisualStyleBackColor = true;
            this.EditCustomerBtn.Click += new System.EventHandler(this.EditCustomerBtn_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(23, 74);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(662, 212);
            this.customerDataGridView.TabIndex = 2;
            this.customerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "customerId";
            this.dataGridViewTextBoxColumn1.HeaderText = "customerId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "customerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "addressId";
            this.dataGridViewTextBoxColumn3.HeaderText = "addressId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "createDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "createDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "createdBy";
            this.dataGridViewTextBoxColumn5.HeaderText = "createdBy";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "address";
            this.addressBindingSource.DataSource = this.u069LrDataSet;
            // 
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // addressIdTextBox
            // 
            this.addressIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "addressId", true));
            this.addressIdTextBox.Location = new System.Drawing.Point(174, 631);
            this.addressIdTextBox.Name = "addressIdTextBox";
            this.addressIdTextBox.ReadOnly = true;
            this.addressIdTextBox.Size = new System.Drawing.Size(52, 22);
            this.addressIdTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(221, 348);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(200, 22);
            this.addressTextBox.TabIndex = 6;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(221, 391);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.ReadOnly = true;
            this.address2TextBox.Size = new System.Drawing.Size(200, 22);
            this.address2TextBox.TabIndex = 8;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "postalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(221, 440);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.ReadOnly = true;
            this.postalCodeTextBox.Size = new System.Drawing.Size(200, 22);
            this.postalCodeTextBox.TabIndex = 12;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(221, 483);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.phoneTextBox.TabIndex = 14;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "city";
            this.cityBindingSource.DataSource = this.u069LrDataSet;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // countryIdTextBox
            // 
            this.countryIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "countryId", true));
            this.countryIdTextBox.Location = new System.Drawing.Point(426, 631);
            this.countryIdTextBox.Name = "countryIdTextBox";
            this.countryIdTextBox.ReadOnly = true;
            this.countryIdTextBox.Size = new System.Drawing.Size(52, 22);
            this.countryIdTextBox.TabIndex = 28;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "country";
            this.countryBindingSource.DataSource = this.u069LrDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.countryBindingSource, "country", true));
            this.countryTextBox.Location = new System.Drawing.Point(221, 563);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(200, 22);
            this.countryTextBox.TabIndex = 33;
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomerButton.Location = new System.Drawing.Point(703, 188);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(148, 28);
            this.deleteCustomerButton.TabIndex = 44;
            this.deleteCustomerButton.Text = "Delete Customer";
            this.deleteCustomerButton.UseVisualStyleBackColor = true;
            this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
            // 
            // cityIdTextBox
            // 
            this.cityIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "cityId", true));
            this.cityIdTextBox.Location = new System.Drawing.Point(296, 631);
            this.cityIdTextBox.Name = "cityIdTextBox";
            this.cityIdTextBox.ReadOnly = true;
            this.cityIdTextBox.Size = new System.Drawing.Size(52, 22);
            this.cityIdTextBox.TabIndex = 10;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(221, 522);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(200, 22);
            this.cityTextBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Customer Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(221, 308);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.ReadOnly = true;
            this.customerNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.customerNameTextBox.TabIndex = 46;
            // 
            // returnToMainScreenBtn
            // 
            this.returnToMainScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainScreenBtn.Location = new System.Drawing.Point(525, 311);
            this.returnToMainScreenBtn.Name = "returnToMainScreenBtn";
            this.returnToMainScreenBtn.Size = new System.Drawing.Size(237, 28);
            this.returnToMainScreenBtn.TabIndex = 47;
            this.returnToMainScreenBtn.Text = "Return to Main Screen";
            this.returnToMainScreenBtn.UseVisualStyleBackColor = true;
            this.returnToMainScreenBtn.Click += new System.EventHandler(this.returnToMainScreenBtn_Click);
            // 
            // titleCustomersScreen
            // 
            this.titleCustomersScreen.AutoSize = true;
            this.titleCustomersScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCustomersScreen.Location = new System.Drawing.Point(20, 35);
            this.titleCustomersScreen.Name = "titleCustomersScreen";
            this.titleCustomersScreen.Size = new System.Drawing.Size(191, 20);
            this.titleCustomersScreen.TabIndex = 48;
            this.titleCustomersScreen.Text = "Customers List Screen";
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 664);
            this.Controls.Add(this.titleCustomersScreen);
            this.Controls.Add(this.returnToMainScreenBtn);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteCustomerButton);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryIdLabel);
            this.Controls.Add(this.countryIdTextBox);
            this.Controls.Add(addressIdLabel);
            this.Controls.Add(this.addressIdTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(cityIdLabel);
            this.Controls.Add(this.cityIdTextBox);
            this.Controls.Add(postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.EditCustomerBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private U069LrDataSet u069LrDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private U069LrDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private U069LrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private U069LrDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button EditCustomerBtn;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private U069LrDataSetTableAdapters.addressTableAdapter addressTableAdapter;
        private System.Windows.Forms.TextBox addressIdTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private U069LrDataSetTableAdapters.cityTableAdapter cityTableAdapter;
        private System.Windows.Forms.TextBox countryIdTextBox;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private U069LrDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.TextBox cityIdTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Button returnToMainScreenBtn;
        private System.Windows.Forms.Label titleCustomersScreen;
    }
}