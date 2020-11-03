using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CustomerAppointmentManager
{
    public partial class CustomersForm : Form
    {

        public CustomersForm()
        {
            InitializeComponent();

           
;
        }

        int indexCustomer;
        DatabaseConnection con = new DatabaseConnection();

        private void CustomersForm_Load(object sender, EventArgs e)
        {

            formatDataGridView(customerDataGridView);

            this.countryTableAdapter.Fill(this.u069LrDataSet.country);

            this.cityTableAdapter.Fill(this.u069LrDataSet.city);

            this.cityTableAdapter.Fill(this.u069LrDataSet.city);

            this.customerTableAdapter.Fill(this.u069LrDataSet.customer);

            this.addressTableAdapter.Fill(this.u069LrDataSet.address);

            if (customerDataGridView.Rows.Count != 0)
            {
                string lookupAddressId = Convert.ToString(customerDataGridView.Rows[0].Cells[2].Value);
                addressBindingSource.Filter = String.Format("addressId={0}", lookupAddressId);
            }

            indexCustomer = -1;

            string currentCustName = Convert.ToString(customerDataGridView.Rows[0].Cells[1].Value);
            customerNameTextBox.Text = currentCustName;
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewCustomerForm addNewCustomerForm = new AddNewCustomerForm();
            addNewCustomerForm.Show(); 
        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            indexCustomer = e.RowIndex;
            if (indexCustomer > -1)
            {
                customerDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                customerDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

                string lookupAddressId = Convert.ToString(customerDataGridView.Rows[indexCustomer].Cells[2].Value);
                addressBindingSource.Filter = String.Format("addressId={0}", lookupAddressId);
                string lookupCityId = cityIdTextBox.Text;
                cityBindingSource.Filter = String.Format("cityId={0}", lookupCityId);
                string lookupCountryId = countryIdTextBox.Text;
                countryBindingSource.Filter = String.Format("countryId={0}", lookupCountryId);


                TrackSelected.SelectedCustomerName = (string)customerDataGridView.Rows[indexCustomer].Cells[1].Value;

                TrackSelected.SelectedAddressId = Int32.Parse(addressIdTextBox.Text);

                TrackSelected.SelectedCustomerId = (int)customerDataGridView.Rows[indexCustomer].Cells[0].Value;

                customerNameTextBox.Text = (string)customerDataGridView.Rows[indexCustomer].Cells[1].Value;

            }
        }

        private void EditCustomerBtn_Click(object sender, EventArgs e)
        {

            if (indexCustomer > -1)
            {
                this.Hide();
                EditCustomer editCustomer = new EditCustomer();
                editCustomer.Show();
            }
            else
            {
                MessageBox.Show("Please select a Customer from the grid to edit!", "Information");
            }    
        }

        private void formatDataGridView(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = d.DefaultCellStyle.BackColor;
            d.DefaultCellStyle.SelectionForeColor = d.DefaultCellStyle.ForeColor;
            d.RowHeadersVisible = false;
            d.AutoGenerateColumns = false;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            d.ReadOnly = true;
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {

            if ( indexCustomer > -1)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this Customer?",
                                     "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)

                {

                    try
                    {
                        if (!customerHasAppt(TrackSelected.SelectedCustomerId));
                    }
                    catch (CustomerDeletionException customerDeletionException)
                    {
                        Console.WriteLine("/n" + customerDeletionException.Message);
                        return;
                    }

                    U069LrDataSetTableAdapters.customerTableAdapter customerTableAdapter = new U069LrDataSetTableAdapters.customerTableAdapter();
                    customerTableAdapter.DeleteQuery(TrackSelected.SelectedCustomerId);

                    U069LrDataSetTableAdapters.addressTableAdapter addressTableAdapter = new U069LrDataSetTableAdapters.addressTableAdapter();
                    addressTableAdapter.DeleteQuery(TrackSelected.SelectedAddressId);

                    
                }
                else
                {
                    MessageBox.Show("Customer deletion cancelled.");
                }                   
            }
            else
            {
                MessageBox.Show("Please select a Customer to delete.");
            }
            indexCustomer = -1;
            formatDataGridView(customerDataGridView);
            this.customerTableAdapter.Fill(this.u069LrDataSet.customer);
            
        }


        public bool customerHasAppt(int custId)
        {
            bool hasAppt = false;
            con.Open();
            string query = "select * from appointment where customerId =" + custId;
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                throw new CustomerDeletionException("Cannot delete a customer who has an existing appointment! Please delete appointment first.");
            }
            else
            {
                return hasAppt;
            }
           
        }
        
        private void returnToMainScreenBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
