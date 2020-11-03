namespace CustomerAppointmentManager
{
    partial class EditCustomer
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
            this.custNameTextBox = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u069LrDataSet = new CustomerAppointmentManager.U069LrDataSet();
            this.title = new System.Windows.Forms.Label();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.add1TextBox1 = new System.Windows.Forms.TextBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add2TextBox2 = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.add1label = new System.Windows.Forms.Label();
            this.add2label = new System.Windows.Forms.Label();
            this.Citylabel = new System.Windows.Forms.Label();
            this.countrylabel = new System.Windows.Forms.Label();
            this.phonelabel = new System.Windows.Forms.Label();
            this.saveCustomerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new CustomerAppointmentManager.U069LrDataSetTableAdapters.TableAdapterManager();
            this.addressTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.addressTableAdapter();
            this.postallbl = new System.Windows.Forms.Label();
            this.postalCodeTxtBox = new System.Windows.Forms.TextBox();
            this.cityTableAdapter = new CustomerAppointmentManager.U069LrDataSetTableAdapters.cityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // custNameTextBox
            // 
            this.custNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "customerName", true));
            this.custNameTextBox.Location = new System.Drawing.Point(178, 81);
            this.custNameTextBox.Name = "custNameTextBox";
            this.custNameTextBox.Size = new System.Drawing.Size(242, 22);
            this.custNameTextBox.TabIndex = 0;
            this.custNameTextBox.TextChanged += new System.EventHandler(this.custNameTextBox_TextChanged);
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
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(33, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(184, 16);
            this.title.TabIndex = 1;
            this.title.Text = "Edit Customer Information";
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(33, 87);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(105, 16);
            this.custNameLabel.TabIndex = 2;
            this.custNameLabel.Text = "Customer Name";
            // 
            // add1TextBox1
            // 
            this.add1TextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "address", true));
            this.add1TextBox1.Location = new System.Drawing.Point(178, 133);
            this.add1TextBox1.Name = "add1TextBox1";
            this.add1TextBox1.Size = new System.Drawing.Size(242, 22);
            this.add1TextBox1.TabIndex = 3;
            this.add1TextBox1.TextChanged += new System.EventHandler(this.add1TextBox1_TextChanged);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataMember = "address";
            this.addressBindingSource.DataSource = this.u069LrDataSet;
            // 
            // add2TextBox2
            // 
            this.add2TextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "address2", true));
            this.add2TextBox2.Location = new System.Drawing.Point(178, 179);
            this.add2TextBox2.Name = "add2TextBox2";
            this.add2TextBox2.Size = new System.Drawing.Size(242, 22);
            this.add2TextBox2.TabIndex = 4;
            // 
            // cityComboBox
            // 
            this.cityComboBox.DataSource = this.cityBindingSource;
            this.cityComboBox.DisplayMember = "city";
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(178, 224);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(242, 24);
            this.cityComboBox.TabIndex = 5;
            this.cityComboBox.ValueMember = "cityId";
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "city";
            this.cityBindingSource.DataSource = this.u069LrDataSet;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(178, 279);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.ReadOnly = true;
            this.countryTextBox.Size = new System.Drawing.Size(242, 22);
            this.countryTextBox.TabIndex = 6;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(178, 358);
            this.phoneTextBox.MaxLength = 15;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(242, 22);
            this.phoneTextBox.TabIndex = 7;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // add1label
            // 
            this.add1label.AutoSize = true;
            this.add1label.Location = new System.Drawing.Point(33, 139);
            this.add1label.Name = "add1label";
            this.add1label.Size = new System.Drawing.Size(69, 16);
            this.add1label.TabIndex = 8;
            this.add1label.Text = "Address 1";
            // 
            // add2label
            // 
            this.add2label.AutoSize = true;
            this.add2label.Location = new System.Drawing.Point(36, 187);
            this.add2label.Name = "add2label";
            this.add2label.Size = new System.Drawing.Size(69, 16);
            this.add2label.TabIndex = 9;
            this.add2label.Text = "Address 2";
            // 
            // Citylabel
            // 
            this.Citylabel.AutoSize = true;
            this.Citylabel.Location = new System.Drawing.Point(36, 234);
            this.Citylabel.Name = "Citylabel";
            this.Citylabel.Size = new System.Drawing.Size(30, 16);
            this.Citylabel.TabIndex = 10;
            this.Citylabel.Text = "City";
            // 
            // countrylabel
            // 
            this.countrylabel.AutoSize = true;
            this.countrylabel.Location = new System.Drawing.Point(36, 285);
            this.countrylabel.Name = "countrylabel";
            this.countrylabel.Size = new System.Drawing.Size(53, 16);
            this.countrylabel.TabIndex = 11;
            this.countrylabel.Text = "Country";
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.Location = new System.Drawing.Point(36, 364);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(47, 16);
            this.phonelabel.TabIndex = 12;
            this.phonelabel.Text = "Phone";
            // 
            // saveCustomerButton
            // 
            this.saveCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCustomerButton.Location = new System.Drawing.Point(36, 409);
            this.saveCustomerButton.Name = "saveCustomerButton";
            this.saveCustomerButton.Size = new System.Drawing.Size(75, 23);
            this.saveCustomerButton.TabIndex = 13;
            this.saveCustomerButton.Text = "Save";
            this.saveCustomerButton.UseVisualStyleBackColor = true;
            this.saveCustomerButton.Click += new System.EventHandler(this.saveCustomerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(142, 409);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
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
            // addressTableAdapter
            // 
            this.addressTableAdapter.ClearBeforeFill = true;
            // 
            // postallbl
            // 
            this.postallbl.AutoSize = true;
            this.postallbl.Location = new System.Drawing.Point(36, 323);
            this.postallbl.Name = "postallbl";
            this.postallbl.Size = new System.Drawing.Size(82, 16);
            this.postallbl.TabIndex = 15;
            this.postallbl.Text = "Postal Code";
            // 
            // postalCodeTxtBox
            // 
            this.postalCodeTxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBindingSource, "postalCode", true));
            this.postalCodeTxtBox.Location = new System.Drawing.Point(178, 318);
            this.postalCodeTxtBox.MaxLength = 11;
            this.postalCodeTxtBox.Name = "postalCodeTxtBox";
            this.postalCodeTxtBox.Size = new System.Drawing.Size(242, 22);
            this.postalCodeTxtBox.TabIndex = 16;
            this.postalCodeTxtBox.TextChanged += new System.EventHandler(this.postalCodeTxtBox_TextChanged);
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.postalCodeTxtBox);
            this.Controls.Add(this.postallbl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveCustomerButton);
            this.Controls.Add(this.phonelabel);
            this.Controls.Add(this.countrylabel);
            this.Controls.Add(this.Citylabel);
            this.Controls.Add(this.add2label);
            this.Controls.Add(this.add1label);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.add2TextBox2);
            this.Controls.Add(this.add1TextBox1);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.custNameTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u069LrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox custNameTextBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.TextBox add1TextBox1;
        private System.Windows.Forms.TextBox add2TextBox2;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label add1label;
        private System.Windows.Forms.Label add2label;
        private System.Windows.Forms.Label Citylabel;
        private System.Windows.Forms.Label countrylabel;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.Button saveCustomerButton;
        private System.Windows.Forms.Button cancelButton;
        private U069LrDataSet u069LrDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private U069LrDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private U069LrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private U069LrDataSetTableAdapters.addressTableAdapter addressTableAdapter;
        private System.Windows.Forms.Label postallbl;
        private System.Windows.Forms.TextBox postalCodeTxtBox;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private U069LrDataSetTableAdapters.cityTableAdapter cityTableAdapter;
    }
}