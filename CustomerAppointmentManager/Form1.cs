using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace CustomerAppointmentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u069LrDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.u069LrDataSet.customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            DataTable dt = new DataTable();

            connectionString = ConfigurationManager.ConnectionStrings["MyMySqlKey"].ConnectionString;
            MySqlConnection conToMySQL = new MySqlConnection(connectionString);
            conToMySQL.Open();
            MySqlCommand cmdToMySQL = new MySqlCommand(txtMain.Text, conToMySQL);
            MySqlDataAdapter adaptToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);
            adaptToMySQL.Fill(dt);
            conToMySQL.Close();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.u069LrDataSet);

        }

        private void customerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
