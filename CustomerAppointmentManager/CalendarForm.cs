﻿using System;
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
    public partial class CalendarForm : Form
    {

        DatabaseConnection con = new DatabaseConnection();
        private BindingList<Appointment> appointments = new BindingList<Appointment>();
        public BindingList<Appointment> Appointments { get { return appointments; } set { appointments = value; } }
        public CalendarForm()
        {
            InitializeComponent();
            formatDataGridView(AppointmentsDataGridView);
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {

            AppointmentsDataGridView.DataSource = Appointments;
            byMonthRadioButton.Checked = true;
            viewAppointmentsTitle.Text = "View appointments for the current month";
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

        private void GetAppointmentListMonth()
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

                    if(newAppointment.Start.Month == DateTime.Now.Month)
                    {
                        Appointments.Add(newAppointment);
                    }

                    

                }
            }
            else
            {
                MessageBox.Show("No appointments found for this month!", "Information");
            }

            con.Close();
        }

        private void byWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(byWeekRadioButton.Checked == true)
            {
                Appointments.Clear();
                viewAppointmentsTitle.Text = "View appointments for the current week";
                GetAppointmentListWeek();
            }
        }

        public void GetAppointmentListWeek()
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



                    DateTime timeNow = DateTime.Now;
                    DateTime timeCompare = timeNow.AddDays(7);


                    Appointment newAppointment = new Appointment(apptId, custId, userId, type, start, end, createDate, createdBy, lastUpdate);

                

                    if (newAppointment.Start >= timeNow && newAppointment.Start <= timeCompare )
                    {
                        Appointments.Add(newAppointment);
                    }

                }
            }
            else
            {
                MessageBox.Show("No appointments found for week!", "Information");
            }

            con.Close();
        }

        private void byMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (byMonthRadioButton.Checked == true)
            {
                Appointments.Clear();
                viewAppointmentsTitle.Text = "View appointments for the current month";
                GetAppointmentListMonth();
            }
        }

        private void mainScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
    
}
