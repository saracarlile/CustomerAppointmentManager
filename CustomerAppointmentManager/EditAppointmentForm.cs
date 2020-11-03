using System;
using System.ComponentModel;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CustomerAppointmentManager
{
    public partial class EditAppointmentForm : Form
    {

        int passedAppointmentID;
        DatabaseConnection con = new DatabaseConnection();
        private BindingList<Appointment> appointments = new BindingList<Appointment>();
        public BindingList<Appointment> Appointments { get { return appointments; } set { appointments = value; } }

        public delegate bool IsValidType(string type);
        IsValidType isValidAppointmentType = st => st == "Scrum" || st == "Presentation" || st == "Planning" || st == "Wrap-Up";
        //create lambda expression to check if Appointment type is valid (should only be one of four values) -- if false custom AppointmentTypeException exception is thrown see line 216
        //lambda expresssion makes code readable and the intention of the isValidAppointmentType function clear


        public EditAppointmentForm(int apptID)
        {
            InitializeComponent();
            passedAppointmentID = apptID;

        }

        private void EditAppointmentForm_Load(object sender, EventArgs e)
        {

            populateCustomersComboBox();
            GetAppointment();
            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "MM'/'dd'/'yyyy hh':'mm tt";
            currentTimeZoneValue.Text = TimeZoneInfo.Local.ToString();
            customerIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            appointmentTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GetAppointmentList();

       
        }

        private void GetAppointment()
        {
            int apptId = passedAppointmentID;
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
            string query = "select appointmentId, customerId, userId, type, start, end, createDate, createdBy, lastUpdate, lastUpdateBy from appointment where appointmentId = " + passedAppointmentID;
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
                    startUTC = Convert.ToDateTime((row["start"]));
                    endUTC = Convert.ToDateTime((row["end"]));
                    createdBy = (row["createdBy"]).ToString();
                    lastUpdate = Convert.ToDateTime((row["lastUpdate"]));
                    start = ConvertFromUTCLocalTime(startUTC);
                    end = ConvertFromUTCLocalTime(endUTC);

                    Appointment editAppointment = new Appointment(apptId, custId, userId, type, start, end, createDate, createdBy, lastUpdate);

                    appointmentIDTextBox.Text = editAppointment.AppointmentID.ToString();
                    customerIDComboBox.Text = editAppointment.CustomerID.ToString();
                    customerNameTextBox.Text = lookupCustomerById(editAppointment.CustomerID);
                    appointmentTypeComboBox.Text = editAppointment.Type;
                    startDateTimePicker.Text = editAppointment.Start.ToString();
                    endDateTimePicker.Text = editAppointment.End.ToString();



                }
            }
            else
            {
                MessageBox.Show("Error loading appointment or no appointment found!", "Information");
            }
            con.Close();

        }

        public DateTime ConvertFromUTCLocalTime(DateTime utcDate)
        {
            DateTime convertedDate = DateTime.UtcNow;
 

            TimeZoneInfo systemTimeZone = TimeZoneInfo.Local;

            try
            {
                convertedDate = TimeZoneInfo.ConvertTimeFromUtc(utcDate, systemTimeZone);
                return convertedDate;
            }
            catch (ArgumentException e)
            {
                MessageBox.Show(e.Message, "Information");
                //an argument provided to the method TimeZoneInfo.ConvertTimeFromUtc is not valid
            }
            return convertedDate;
        }

        private string lookupCustomerById(int customerID)
        {

            string returnedCustomerName = "";
            con.Open();
            string query = "select * from customer where customerId = " + customerID;
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    returnedCustomerName = (row["customerName"]).ToString();
                }
            }
            else
            {
                MessageBox.Show("Error looking up by customer ID!", "Information");
                
            }

            con.Close();
            return returnedCustomerName;
            
        }

        private void populateCustomersComboBox()
        {
            string custNameToAdd = "";
            int customerID;
  
            con.Open();
            string query = "select * from customer";
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    custNameToAdd = (row["customerName"]).ToString();
                    customerID = Convert.ToInt32(row["customerId"]);

                    customerIDComboBox.Items.Add(customerID);

                }
            }
            else
            {
                MessageBox.Show("No customers found!", "Information");
                return;
            }

            con.Close();
            return;
        }


    


        private void saveBtn_Click(object sender, EventArgs e)
        {
            int appointmentId = Int32.Parse(appointmentIDTextBox.Text);
            int customerId = Int32.Parse(customerIDComboBox.Text);


            string appointmentType = appointmentTypeComboBox.Text;
            DateTime startTimeDateLocal = startDateTimePicker.Value;
            DateTime endTimeDateLocal = endDateTimePicker.Value;

         

            DateTime startTimeUTC = TimeZoneInfo.ConvertTimeToUtc(startTimeDateLocal, TimeZoneInfo.Local);
            DateTime endTimeUTC = TimeZoneInfo.ConvertTimeToUtc(endTimeDateLocal, TimeZoneInfo.Local);

            string startTimeUTCstring = startTimeUTC.ToString("yyyy-M-dd HH:mm:ss");
            string endTimeUTCstring = endTimeUTC.ToString("yyyy-M-dd HH:mm:ss");


            try
            {
                appointmentType = getAppointmentType();
            }
            catch (AppointmentTypeException appointmentTypeException)
            {
                Console.WriteLine("\n" + appointmentTypeException.Message);
                return;
            }
            try
            {
                checkCustomerName();
            }
            catch (CustomerIDDoesNotMatchException customerIdDoesNotMatchException)
            {
                Console.WriteLine("\n" + customerIdDoesNotMatchException.Message);
                return;
            }
            try
            {
                if (outsideBusinessHoursCheck());
            }
            catch (AppointmentSchedulingException outsideBusinessHoursException)
            {
                Console.WriteLine("\n" + outsideBusinessHoursException.Message);
                return;
            }
            try
            {
                if (!overLappingAppointmentsCheck());
            }
            catch (AppointmentSchedulingException appointmentOverlappingException)
            {
                Console.WriteLine("\n" + appointmentOverlappingException.Message);
                return;
            }

            con.Open();
            string query = "update appointment set type = '" + appointmentType + "', customerID=" + customerId  + ", start= '" + startTimeUTCstring + "', end= '" +  endTimeUTCstring  + "'where appointmentId=" + appointmentId;

            MySqlDataReader row;
            row = con.ExecuteReader(query);
           

            con.Close();


            this.Hide();
            AppointmentsListScreen appointmentsListScreen = new AppointmentsListScreen();
            appointmentsListScreen.Show();


        }

       
       

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            AppointmentsListScreen appointmentsListScreen = new AppointmentsListScreen();
            appointmentsListScreen.Show();
        }

        public string getAppointmentType()
        {
            string type = appointmentTypeComboBox.Text;

            //use of lambda expression isValidApopintmentType -- lambda 
            if (!isValidAppointmentType(type))
            {
                throw new AppointmentTypeException("Selected Appointment Type not valid!");
            }
            else
            {
                return type;
            }
        }

        public bool checkCustomerName()
        {
            //check if customer name is valid for customer Id against appoinemtnet
            bool testCustomerNameCheck = false;
            string custNameForm = customerNameTextBox.Text;
            int custIdForm = Int32.Parse(customerIDComboBox.Text);
            string custNameReturned;
            int custIdReturned;
            con.Open();
            string query = "select * from customer where customerId = " + custIdForm ;
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                    custNameReturned = (row["customerName"]).ToString();
                    custIdReturned = Convert.ToInt32(row["customerId"]);

                    if(custNameReturned != custNameForm)
                    {
                        throw new CustomerIDDoesNotMatchException("Customer name does not match customer ID on customers table!");
                    }
                    else
                    {
                        testCustomerNameCheck = true;
                    }
                }
            }
            con.Close();
            return testCustomerNameCheck;
            
        }


        public bool outsideBusinessHoursCheck()
        {
            bool outsideBusinessHours = false;
            DateTime startTime = startDateTimePicker.Value;
            DateTime endTime = endDateTimePicker.Value;

            if (startTime.Hour < 8 || startTime.Hour > 17)
            {
                
                outsideBusinessHours = true;
                throw new AppointmentSchedulingException("Cannot schedule appointment before 8am or after 5pm!");
            }
            if (endTime.Hour < 8 || endTime.Hour > 17)
            {
                outsideBusinessHours = true;
                throw new AppointmentSchedulingException("Cannot schedule appointment before 8am or after 5pm!");
            }

            return outsideBusinessHours;

        }

        public bool overLappingAppointmentsCheck()
        {
            bool overlappingAppointment = false;
            DateTime startTimeNew = startDateTimePicker.Value;
            DateTime endTimeNew = endDateTimePicker.Value;
            DateTime endTimeApptLocal;
            DateTime startTimeApptLocal;


            foreach (var appointment in Appointments)
            {

                if (appointment.AppointmentID != Int32.Parse(appointmentIDTextBox.Text))
                {

                    DateTime start = Convert.ToDateTime(appointment.Start);
                    DateTime end = Convert.ToDateTime(appointment.End);

                    startTimeApptLocal = TimeZone.CurrentTimeZone.ToLocalTime(start);
                    endTimeApptLocal = TimeZone.CurrentTimeZone.ToLocalTime(end);

                    
                    overlappingAppointment = startTimeNew < endTimeApptLocal && endTimeNew > startTimeApptLocal;

                    if (overlappingAppointment)
                    {
                        throw new AppointmentSchedulingException("Cannot schedule overlapping appointments!");
                    }
                }

                

            }
            return overlappingAppointment;

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
                    startUTC = Convert.ToDateTime((row["start"]));
                    endUTC = Convert.ToDateTime((row["end"]));
                    createdBy = (row["createdBy"]).ToString();
                    lastUpdate = Convert.ToDateTime((row["lastUpdate"]));
                    start = ConvertFromUTCLocalTime(startUTC);
                    end = ConvertFromUTCLocalTime(endUTC);

                    Appointment newAppointment = new Appointment(apptId, custId, userId, type, start, end, createDate, createdBy, lastUpdate);
                    Appointments.Add(newAppointment);

                }
            }
            else
            {
                MessageBox.Show("Error loading appointments or no appointments found!", "Information");
            }

        }



        private void customerIDComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            string custName;
            int id = Convert.ToInt32(customerIDComboBox.SelectedItem);


            con.Open();
            string query = "select * from customer where customerId = " +  id;
            MySqlDataReader row;
            row = con.ExecuteReader(query);
            if (row.HasRows)
            {
                while (row.Read())
                {
                   custName = (row["customerName"]).ToString();
                   customerNameTextBox.Text = custName;

                }
            }
            else
            {
                MessageBox.Show("Error loading customers!", "Information");
            }

            
        }
    }
}
