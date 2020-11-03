using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;

namespace CustomerAppointmentManager
{
    public class FifteenMinutePrompt
    {
        

        private static BindingList<Appointment> appointments = new BindingList<Appointment>();
        public static BindingList<Appointment> Appointments { get { return appointments; } set { appointments = value; } }

        private static void GetAppointmentList()
        {

            DatabaseConnection con = new DatabaseConnection();
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

        public static void checkSchedule()
        {

            GetAppointmentList();

            DateTime timeNow = DateTime.Now;
            DateTime timeCompare = timeNow.AddMinutes(16);
            DateTime startAppt;

            foreach (Appointment appt in Appointments)
            {

                if(appt.UserID == Convert.ToInt32(CurrentOnlineUser.currentOnlineUserID))
                {
                    startAppt = appt.Start;

                    if (startAppt.ToLocalTime() > timeNow && startAppt.ToLocalTime() < timeCompare)
                    {
                       
                        MessageBox.Show("You have an appointment at " + appt.Start.ToLocalTime().ToString(), "Information");
                    }
                }
               

            }

        }
    }
}
