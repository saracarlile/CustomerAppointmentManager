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


    public partial class ReportByUser : Form
    {


        DatabaseConnection con = new DatabaseConnection();

        private List<Appointment> appointments = new List<Appointment>();
        public List<Appointment> Appointments { get { return appointments; } set { appointments = value; } }

        private List<User> users = new List<User>();

        public List<User> Users { get { return users; } set { users = value; } }

        public ReportByUser()
        {
            InitializeComponent();
        }

        private void ReportByUser_Load(object sender, EventArgs e)
        {
            GetAppointmentList();
            getUsers();
            report();
        }

        private void report()
        {

            reportRichTextBox.Text = "Report: appointment list by user.\n\n\n";

            foreach (User user in Users)
            {
                int appointmentId;
                int customerId;
                int userId;
                string type;
                DateTime start;
                DateTime end;

                reportRichTextBox.Text = reportRichTextBox.Text + "User ID: " + user.UserID.ToString() + "\r\n\n";
                reportRichTextBox.Text = reportRichTextBox.Text + "User Name: " + user.UserName + "\r\n\n";

                foreach (Appointment appt in Appointments)
                {
                    appointmentId = appt.AppointmentID;
                    customerId = appt.CustomerID;
                    userId = appt.UserID;
                    type = appt.Type;
                    start = appt.Start;
                    end = appt.End;


                    if(user.UserID == appt.UserID)
                    {
                        reportRichTextBox.Text = reportRichTextBox.Text + "\tAppointment ID: " + appointmentId.ToString() + ", Customer ID: " + customerId.ToString() + ", Type: " +
                          type + ", Start: " + start.ToLocalTime().ToString() + ", End: " + end.ToLocalTime().ToString() + "\r\n\n"; 

                    }

                }

            }

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

        private void getUsers()
        {
            int userID = 0;
            string userName = "";

            con.Open();
            string query = "select * from user";
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while(row.Read())
                {
                    userID = Convert.ToInt32(row["userId"]);
                    userName = (row["userName"]).ToString();

                    User user = new User(userID, userName);
                    Users.Add(user);
                }
            }
            con.Close();
        }

        private void reportsListScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsListScreen reportsListScreen = new ReportsListScreen();
            reportsListScreen.Show();
        }
    }
}

