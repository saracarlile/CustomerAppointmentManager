using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppointmentManager
{
    public class LoginRecord
    {
        public int UserID { get; set; }
        public string UserName { get; set; } 
        public DateTime Date { get; set; }

        // parameterless constructor sets members to default values
        public LoginRecord() : this(0, string.Empty, DateTime.UtcNow) { }


        // overloaded constructor sets members to parameter values
        public LoginRecord(int userID, string userName, DateTime date) 
        {
            UserID = userID;
            UserName = userName;
            Date = date;
        }
        
    }
}
