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
    public partial class AppointmentsBeforeNoon : Form
    {

       

        DatabaseConnection con = new DatabaseConnection();

        private List<Appointment> appointments = new List<Appointment>();
        public List<Appointment> Appointments { get { return appointments; } set { appointments = value; } }

        delegate bool IsBeforeNoon(int hour);
        // delete declared for use in lambda expression



        public AppointmentsBeforeNoon()
        {
            InitializeComponent();
        }

        private void AppointmentsBeforeNoon_Load(object sender, EventArgs e)
        {
            GetAppointmentList();
            report();
        }


        private void report()
        {
            reportRichTextBox.Text = "Report: appointments that start before 12pm (any day).\n\n\n";

            foreach (Appointment appt in Appointments)
            {

                IsBeforeNoon isBeforeNoon = startTime => startTime < 12;
                //lambda expresssion helps as a short-hand clear way to check if hour is before noon

                int appointmentId = appt.AppointmentID;
                int customerId = appt.CustomerID;
                int userId = appt.UserID;
                string type = appt.Type;
                DateTime start = appt.Start;
                DateTime end = appt.End;

                if (isBeforeNoon(appt.Start.ToLocalTime().Hour))
                {
                    reportRichTextBox.Text = reportRichTextBox.Text + "\tAppointment ID: " + appointmentId.ToString() + ", Customer ID: " + customerId.ToString() + ", Type: " +
                          type + ", Start: " + start.ToLocalTime().ToString() + "\r\n\n";
                }
            }

        }

        private void returnToReportsList_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsListScreen reportsListScreen = new ReportsListScreen();
            reportsListScreen.Show();
            
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
    }
}
