using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CustomerAppointmentManager
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
           

            this.addressTableAdapter.Fill(this.u069LrDataSet.address);

            this.customerTableAdapter.Fill(this.u069LrDataSet.customer);

            // TODO: This line of code loads data into the 'u069LrDataSet.city' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.u069LrDataSet.city);

            string customerNameSelected = TrackSelected.SelectedCustomerName;

            customerBindingSource.Filter = "customerName = '" + customerNameSelected + "'";
            addressBindingSource.Filter = String.Format("addressId={0}", TrackSelected.SelectedAddressId);

            string cityNameAgainstAddress = FindCityName();
            cityComboBox.Text = cityNameAgainstAddress;
            countryTextBox.Text = FindCountry();
            cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.u069LrDataSet);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersForm customerForm = new CustomersForm();
            customerForm.Show();
        }

        public string FindCountry()
        {
            string findCountry = null;
            string city = cityComboBox.Text;

            DatabaseConnection con = new DatabaseConnection();

            con.Open();
            MySqlDataReader row;
            string query = "select * from country WHERE countryId in (select countryId from city where city =  '" + city + "')";
            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {
                    findCountry = row["country"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Country Query not working!", "Information");
            }

            return findCountry;
        }

        public string FindCityName()
        {
            string cityName = null;

            DatabaseConnection con = new DatabaseConnection();

            con.Open();
            MySqlDataReader row;
            string query = "select * from city WHERE cityId in (select cityID from address where addressId = " + TrackSelected.SelectedAddressId + ")";
            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {
                    cityName = row["city"].ToString();
                }
            }
            else
            {
                MessageBox.Show("City Query not working!", "Information");
            }

            return cityName;

        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cityComboBox.SelectedIndex >= 0)
            {
                string country = FindCountry();
                countryTextBox.Text = country;

            }

        }

        private bool allowSave()
        {
            bool allowSaveTest = true;

            if (string.IsNullOrWhiteSpace(custNameTextBox.Text) || string.IsNullOrWhiteSpace(add1TextBox1.Text) || string.IsNullOrWhiteSpace(postalCodeTxtBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                allowSaveTest = false;
            }

            if (cityComboBox.SelectedIndex < 0)
            {
                allowSaveTest = false;
            }

            return allowSaveTest;
        }

        private void custNameTextBox_TextChanged(object sender, EventArgs e)
        {
            saveCustomerButton.Enabled = allowSave();
        }

        private void add1TextBox1_TextChanged(object sender, EventArgs e)
        {
            saveCustomerButton.Enabled = allowSave();
        }

        private void postalCodeTxtBox_TextChanged(object sender, EventArgs e)
        {
            saveCustomerButton.Enabled = allowSave();
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            saveCustomerButton.Enabled = allowSave();
        }

        private void saveCustomerButton_Click(object sender, EventArgs e)
        {

            DatabaseConnection con = new DatabaseConnection();

            string custNameValue, add1Value, add2Value, postalCodeValue, phoneValue, city;
            int cityId = 0;
            int countryId = 0;


            custNameValue = custNameTextBox.Text;
            add1Value = add1TextBox1.Text;
            add2Value = add2TextBox2.Text;
            postalCodeValue = postalCodeTxtBox.Text;
            phoneValue = phoneTextBox.Text;
            DateTime updateDate = DateTime.UtcNow;


            con.Open();

            try
            {
                MySqlDataReader row;
                string query = "select countryId, cityId, city from city where city = '" + cityComboBox.Text + "'";
                row = con.ExecuteReader(query);


                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        cityId = Convert.ToInt32(row["cityId"]);
                        countryId = Convert.ToInt32(row["countryId"]);
                        city = row["city"].ToString();
                    }

                    U069LrDataSetTableAdapters.customerTableAdapter customerTableAdapter = new U069LrDataSetTableAdapters.customerTableAdapter();
                    customerTableAdapter.UpdateQuery(custNameValue, updateDate, CurrentOnlineUser.currentOnlineUserName, TrackSelected.SelectedCustomerId);



                    U069LrDataSetTableAdapters.addressTableAdapter addressTableAdapter = new U069LrDataSetTableAdapters.addressTableAdapter();
                    addressTableAdapter.UpdateQuery(add1Value, add2Value, cityId, postalCodeValue, phoneValue, updateDate, CurrentOnlineUser.currentOnlineUserName, TrackSelected.SelectedAddressId);

                }
                else
                {
                    MessageBox.Show("Customer Record not Saved!", "Information");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }


            con.Close();

            this.Hide();
            CustomersForm customerForm = new CustomersForm();
            customerForm.Show();

        }
    }
}
