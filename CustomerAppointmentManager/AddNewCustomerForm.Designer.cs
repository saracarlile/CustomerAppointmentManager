namespace CustomerAppointmentManager
{
    partial class AddNewCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.u069LrDataSet = new CustomerAppointmentManager.U069LrDataSet();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.cityTableAdapter();
            this.tableAdapterManager = new CustomerAppointmentManager.U069LrDataSetTableAdapters.TableAdapterManager();
            this.saveCustomerButton = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.countryTableAdapter();
            this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.customerTableAdapter();
            this.countrylabel = new System.Windows.Forms.Label();
            this.postalCodelabel = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.cityBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.city = new System.Windows.Forms.Label();
            this.add2label = new System.Windows.Forms.Label();
            this.address2textBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.add1label = new System.Windows.Forms.Label();
            this.custName = new System.Windows.Forms.Label();
            this.custNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Customer";
            // 
            // u069LrDataSet
            // 
            this.u069LrDataSet.DataSetName = "U069LrDataSet";
            this.u069LrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.appointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CustomerAppointmentManager.U069LrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // saveCustomerButton
            // 
            this.saveCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCustomerButton.Location = new System.Drawing.Point(27, 346);
            this.saveCustomerButton.Name = "saveCustomerButton";
            this.saveCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.saveCustomerButton.TabIndex = 14;
            this.saveCustomerButton.Text = "Save New Customer";
            this.saveCustomerButton.UseVisualStyleBackColor = true;
            this.saveCustomerButton.Click += new System.EventHandler(this.saveCustomerButton_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(141, 346);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataMember = "city";
            this.cityBindingSource1.DataSource = this.u069LrDataSet;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.u069LrDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // countrylabel
            // 
            this.countrylabel.AutoSize = true;
            this.countrylabel.Location = new System.Drawing.Point(24, 257);
            this.countrylabel.Name = "countrylabel";
            this.countrylabel.Size = new System.Drawing.Size(53, 16);
            this.countrylabel.TabIndex = 12;
            this.countrylabel.Text = "Country";
            // 
            // postalCodelabel
            // 
            this.postalCodelabel.AutoSize = true;
            this.postalCodelabel.Location = new System.Drawing.Point(24, 216);
            this.postalCodelabel.Name = "postalCodelabel";
            this.postalCodelabel.Size = new System.Drawing.Size(82, 16);
            this.postalCodelabel.TabIndex = 10;
            this.postalCodelabel.Text = "Postal Code";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(24, 299);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(47, 16);
            this.phonelbl.TabIndex = 16;
            this.phonelbl.Text = "Phone";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(167, 296);
            this.phoneTextBox.MaxLength = 15;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(247, 22);
            this.phoneTextBox.TabIndex = 17;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(167, 254);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(247, 22);
            this.countryTextBox.TabIndex = 20;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(167, 216);
            this.postalCodeTextBox.MaxLength = 11;
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(247, 22);
            this.postalCodeTextBox.TabIndex = 11;
            this.postalCodeTextBox.TextChanged += new System.EventHandler(this.postalCodeTextBox_TextChanged);
            // 
            // cityComboBox
            // 
            this.cityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cityBindingSource1, "city", true));
            this.cityComboBox.DataSource = this.cityBindingSource2;
            this.cityComboBox.DisplayMember = "city";
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(167, 178);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(247, 24);
            this.cityComboBox.TabIndex = 19;
            this.cityComboBox.ValueMember = "cityId";
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // cityBindingSource2
            // 
            this.cityBindingSource2.DataMember = "city";
            this.cityBindingSource2.DataSource = this.u069LrDataSet;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(24, 178);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(30, 16);
            this.city.TabIndex = 8;
            this.city.Text = "City";
            // 
            // add2label
            // 
            this.add2label.AutoSize = true;
            this.add2label.Location = new System.Drawing.Point(24, 139);
            this.add2label.Name = "add2label";
            this.add2label.Size = new System.Drawing.Size(69, 16);
            this.add2label.TabIndex = 5;
            this.add2label.Text = "Address 2";
            // 
            // address2textBox
            // 
            this.address2textBox.Location = new System.Drawing.Point(167, 139);
            this.address2textBox.Name = "address2textBox";
            this.address2textBox.Size = new System.Drawing.Size(247, 22);
            this.address2textBox.TabIndex = 6;
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(167, 99);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(247, 22);
            this.address1TextBox.TabIndex = 3;
            this.address1TextBox.TextChanged += new System.EventHandler(this.address1TextBox_TextChanged);
            // 
            // add1label
            // 
            this.add1label.AutoSize = true;
            this.add1label.Location = new System.Drawing.Point(24, 99);
            this.add1label.Name = "add1label";
            this.add1label.Size = new System.Drawing.Size(69, 16);
            this.add1label.TabIndex = 4;
            this.add1label.Text = "Address 1";
            // 
            // custName
            // 
            this.custName.AutoSize = true;
            this.custName.Location = new System.Drawing.Point(24, 63);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(105, 16);
            this.custName.TabIndex = 1;
            this.custName.Text = "Customer Name";
            // 
            // custNameTextBox
            // 
            this.custNameTextBox.Location = new System.Drawing.Point(167, 60);
            this.custNameTextBox.Name = "custNameTextBox";
            this.custNameTextBox.Size = new System.Drawing.Size(247, 22);
            this.custNameTextBox.TabIndex = 2;
            this.custNameTextBox.TextChanged += new System.EventHandler(this.custNameTextBox_TextChanged);
            // 
            // AddNewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveCustomerButton);
            this.Controls.Add(this.countrylabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.postalCodelabel);
            this.Controls.Add(this.city);
            this.Controls.Add(this.address2textBox);
            this.Controls.Add(this.add2label);
            this.Controls.Add(this.add1label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.custNameTextBox);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewCustomerForm";
            this.Text = "Add New Customer";
            this.Load += new System.EventHandler(this.AddNewCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private U069LrDataSet u069LrDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private U069LrDataSetTableAdapters.cityTableAdapter cityTableAdapter;
        private U069LrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button saveCustomerButton;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private U069LrDataSetTableAdapters.countryTableAdapter countryTableAdapter;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private U069LrDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label countrylabel;
        private System.Windows.Forms.Label postalCodelabel;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label add2label;
        private System.Windows.Forms.TextBox address2textBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.Label add1label;
        private System.Windows.Forms.Label custName;
        private System.Windows.Forms.TextBox custNameTextBox;
        private System.Windows.Forms.BindingSource cityBindingSource2;
    }
}