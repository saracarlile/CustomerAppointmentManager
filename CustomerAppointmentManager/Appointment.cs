using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppointmentManager
{
    public class Appointment
    { 
        public int AppointmentID { get; set; }

        public int CustomerID { get; set; }

        public int UserID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Contact { get; set; }

        public string Type { get; set; }

        public string URL { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpdate { get; set; }

        // parameterless constructor sets members to default values

        public Appointment() : this(0, 0, 0, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, DateTime.UtcNow, DateTime.UtcNow, DateTime.UtcNow, string.Empty, DateTime.UtcNow) { }


        // overloaded constructor sets members to parameter values
        public Appointment(int appointmentId, int customerId, int userId, string title, string description, string location, string contact, string type, string url, DateTime start, DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate )
        {

            AppointmentID = appointmentId;
            CustomerID = customerId;
            UserID = userId;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            URL = url;
            Start = start;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;

        }

        //https://stackoverflow.com/questions/36995639/get-object-information-of-selected-listbox-item cast as type appointment from listbox selectedItem


        //overloaded constructor sets some properties of Appointment to "not needed"

        public Appointment(int appointmentId, int customerId, int userId, string type, DateTime start, DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate)
        {
            AppointmentID = appointmentId;
            CustomerID = customerId;
            UserID = userId;
            Title = "not needed";
            Description = "not needed";
            Location = "not needed";
            Contact = "not needed";
            Type = type;
            Start = start;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
        }

    }
}
