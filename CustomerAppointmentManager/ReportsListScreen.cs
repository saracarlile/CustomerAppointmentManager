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
    public partial class ReportsListScreen : Form
    {
        public ReportsListScreen()
        {
            InitializeComponent();
        }

        private void mainScreenBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void appByMonthScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentsByMonthReport appointmentsByMonthReport = new AppointmentsByMonthReport();
            appointmentsByMonthReport.Show();
        }

        private void apptsByConsultant_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportByUser reportByUser = new ReportByUser();
            reportByUser.Show();
        }

        private void ReportsListScreen_Load(object sender, EventArgs e)
        {

        }

        private void appointmentsBeforeNoon_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentsBeforeNoon appointmentsBeforeNoon = new AppointmentsBeforeNoon();
            appointmentsBeforeNoon.Show();
        }
    }
}
