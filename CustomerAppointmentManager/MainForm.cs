using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAppointmentManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void customersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersForm customersForm = new CustomersForm();
            customersForm.Show();
        }

        private void appointmentsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentsListScreen appointmentsListScreen = new AppointmentsListScreen();
            appointmentsListScreen.Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsListScreen reportsListScreen = new ReportsListScreen();
            reportsListScreen.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calendarScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.Show();
        }
    }
}
