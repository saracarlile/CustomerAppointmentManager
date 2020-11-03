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
    public partial class AppointmentsListScreen : Form
    {


        DatabaseConnection con = new DatabaseConnection();
        private BindingList<Appointment> appointments = new BindingList<Appointment>();
        public BindingList<Appointment> Appointments { get { return appointments; } set { appointments = value; } }
        int indexAppointment = -1;
        int selectedAppointmentID;

        public AppointmentsListScreen()
        {
            InitializeComponent();
            formatDataGridView(AppointmentsDataGridView);


        }



        private void formatDataGridView(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = d.DefaultCellStyle.BackColor;
            d.DefaultCellStyle.SelectionForeColor = d.DefaultCellStyle.ForeColor;
            d.RowHeadersVisible = false;
            d.AutoGenerateColumns = false;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void GetAppointmentList()
        {
            int apptId = 0;
            int custId = 0;
            int userId = 0;
            string type = "type";
            DateTime start = DateTime.UtcNow;
            DateTime end = DateTime.UtcNow;
            DateTime startUTC = DateTime.UtcNow;
            DateTime endUTC = DateTime.UtcNow;
            DateTime createDate = DateTime.UtcNow;
            string createdBy = "test";
            DateTime lastUpdate = DateTime.UtcNow;



            con.Open();
            string query = "select appointmentId, customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy from appointment";
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    apptId = Convert.ToInt32(row["appointmentId"]);
                    custId = Convert.ToInt32(row["customerId"]);
                    userId = Convert.ToInt32(row["userId"]);
                    type = (row["type"]).ToString();
                    startUTC = Convert.ToDateTime(row["start"]);
                    endUTC = Convert.ToDateTime(row["end"]);
                    createdBy = (row["createdBy"]).ToString();
                    lastUpdate = Convert.ToDateTime((row["lastUpdate"]));
                    start = TimeZone.CurrentTimeZone.ToLocalTime(startUTC);
                    end = TimeZone.CurrentTimeZone.ToLocalTime(endUTC);



                    Appointment newAppointment = new Appointment(apptId, custId, userId, type, start, end, createDate, createdBy, lastUpdate);
                    Appointments.Add(newAppointment);

                }
            }
            else
            {
                MessageBox.Show("Error loading appointments or no appointments found!", "Information");
            }

            con.Close();
        }




        private void AppointmentsListScreen_Load(object sender, EventArgs e)
        {
            currentTimeZoneLabelValue.Text = TimeZoneInfo.Local.ToString();
            GetAppointmentList();
            AppointmentsDataGridView.DataSource = Appointments;


        }

        private void AppointmentsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexAppointment = e.RowIndex;
            if (indexAppointment > -1)
            {
                AppointmentsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
                AppointmentsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

                foreach (DataGridViewRow row in this.AppointmentsDataGridView.SelectedRows)
                {
                    Appointment selectedAppointment = new Appointment();

                    selectedAppointment = row.DataBoundItem as Appointment;

                    selectedAppointmentID = selectedAppointment.AppointmentID;//pass ID to edit screen


                }
            }
        }

        private void editApptBtn_Click(object sender, EventArgs e)
        {

            if (indexAppointment > -1)
            {

                this.Hide();
                EditAppointmentForm editAppointmentForm = new EditAppointmentForm(selectedAppointmentID);
                editAppointmentForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.", "Information");
            }
        }

        private void newApptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();
            addAppointmentForm.Show();
        }

        private void deleteApptBtn_Click(object sender, EventArgs e)
        {

            if (indexAppointment > -1)
            {
                //selectedAppointmentID

                var confirmResult = MessageBox.Show("Are you sure you want to delete this Apointment?",
                                       "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)

                {
                    con.Open();
                    string query = "delete from appointment where appointmentId =" + selectedAppointmentID;
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);

                    con.Close();

                    indexAppointment = -1;
                    formatDataGridView(AppointmentsDataGridView);


                    Appointments.Clear();
                    GetAppointmentList();


                }
                else
                {
                    MessageBox.Show("Customer deletion cancelled.");
                }

            }
            else
            {
                MessageBox.Show("Please select an appointment to delete!", "Information");
            }

        }

        private void mainFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
