using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace CustomerAppointmentManager
{
    public partial class AddNewCustomerForm : Form
    {

        public AddNewCustomerForm()
        {
            InitializeComponent();
        }

        private void AddNewCustomerForm_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the 'u069LrDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.u069LrDataSet.customer);
            // TODO: This line of code loads data into the 'u069LrDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.u069LrDataSet.customer);
            this.countryTableAdapter.Fill(this.u069LrDataSet.country);
            this.cityTableAdapter.Fill(this.u069LrDataSet.city);

            cityComboBox.SelectedIndex = -1;
            cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            saveCustomerButton.Enabled = allowSave();
            

        }

        private bool allowSave()
        {
            bool allowSaveTest = true;

            if (string.IsNullOrWhiteSpace(custNameTextBox.Text) || string.IsNullOrWhiteSpace(address1TextBox.Text) || string.IsNullOrWhiteSpace(postalCodeTextBox.Text) ||
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

        private void address1TextBox_TextChanged(object sender, EventArgs e)
        {
            saveCustomerButton.Enabled = allowSave();
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveCustomerButton.Enabled = allowSave();

            if (cityComboBox.SelectedIndex >= 0 )
            {
                string country = FindCountry();
                countryTextBox.Text = country;
            
            }
  
        }

        private void postalCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            saveCustomerButton.Enabled = allowSave();
        }



        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            saveCustomerButton.Enabled = allowSave();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersForm customerForm = new CustomersForm();
            customerForm.Show();
        }

        private void saveCustomerButton_Click(object sender, EventArgs e)
        {

            int findNxtAddId = findNtextAddressID();
            DatabaseConnection con = new DatabaseConnection();

            string custNameValue, add1Value, add2Value, postalCodeValue, phoneValue, city;
            int cityId = 0;
            int countryId = 0;

            custNameValue = custNameTextBox.Text;
            add1Value = address1TextBox.Text;
            add2Value = address2textBox.Text;
            postalCodeValue = postalCodeTextBox.Text;
            phoneValue = phoneTextBox.Text;
            DateTime creaetDate = DateTime.UtcNow;
       
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


                    U069LrDataSetTableAdapters.addressTableAdapter addressTableAdapter = new U069LrDataSetTableAdapters.addressTableAdapter();
                    addressTableAdapter.InsertQuery(findNxtAddId, add1Value, add2Value, cityId, postalCodeValue, phoneValue, creaetDate, CurrentOnlineUser.currentOnlineUserName, creaetDate, CurrentOnlineUser.currentOnlineUserName);


                    U069LrDataSetTableAdapters.customerTableAdapter customerTableAdapter = new U069LrDataSetTableAdapters.customerTableAdapter();
                    customerTableAdapter.InsertQuery(custNameValue, findNxtAddId, 1, creaetDate, CurrentOnlineUser.currentOnlineUserName, creaetDate, CurrentOnlineUser.currentOnlineUserName);


                }
                else
                {
                    MessageBox.Show("Customer Record not Saved!", "Information");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Information");
            }


            con.Close();

            this.Hide();
            CustomersForm customerForm = new CustomersForm();
            customerForm.Show();
        }

        public int findNtextAddressID()
        {
            int nextAddressID = 0;
              
            DatabaseConnection con = new DatabaseConnection();

            con.Open();
            MySqlDataReader row;
            string query = "SELECT MAX(addressId) FROM address";
            row = con.ExecuteReader(query);

            if (row.HasRows)
            {
                while (row.Read())
                {
                    nextAddressID = Convert.ToInt32(row[0]);
                }
            }


            return nextAddressID + 1;
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

            return findCountry;
        }




    }


}

