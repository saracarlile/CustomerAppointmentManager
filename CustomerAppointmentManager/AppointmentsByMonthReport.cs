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
using System.Globalization;

namespace CustomerAppointmentManager
{
    public partial class AppointmentsByMonthReport : Form
    {

        DatabaseConnection con = new DatabaseConnection();

        private List<Appointment> appointments = new List<Appointment>();
        public List<Appointment> Appointments { get { return appointments; } set { appointments = value; } }

        string[] Months = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        

        public AppointmentsByMonthReport()
        {
            InitializeComponent();
            GetAppointmentList();
            report();

        }


        public void report()
        {

            reportTextBox.Text = "Report: number of appointments per month by type.\n\n\n";
               

            foreach (string month in Months)
            {
                
                int numPlanning = 0;
                int numPresentation = 0;
                int numScrum = 0;
                int numWrapUp = 0;

                foreach (Appointment appt in Appointments)
                {
                    if( month == appt.Start.ToString("MMMM", CultureInfo.InvariantCulture))
                    {
                        if(appt.Type == "Planning")
                        {
                            numPlanning++;
                        }
                        if(appt.Type == "Presentation")
                        {
                            numPresentation++;
                        }
                        if(appt.Type == "Scrum")
                        {
                            numScrum++;
                        }
                        if(appt.Type == "Wrap-Up")
                        {
                            numWrapUp++;
                        }
                    } 
                }
                if (numPlanning != 0 || numPresentation != 0 || numScrum != 0 || numWrapUp != 0)
                {
                    reportTextBox.Text = reportTextBox.Text + month + "\r\n\n";
                    reportTextBox.Text = reportTextBox.Text +
                    "\tPlanning    \t\t" + numPlanning + "\r\n" +
                    "\tPresentation\t\t" + numPresentation + "\r\n" +
                    "\tScrum      \t\t" + numScrum + "\r\n" +
                    "\tWrap-Up    \t\t" + numWrapUp + "\r\n\n";
                    reportTextBox.Select(0, 0);

                }

            }



        }



        private void AppointmentsByMonthReport_Load(object sender, EventArgs e)
        {

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

        private void returnToList_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsListScreen reportsListScreen = new ReportsListScreen();
            reportsListScreen.Show();
        }
    }
}
