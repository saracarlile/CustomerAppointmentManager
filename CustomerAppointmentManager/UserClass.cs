using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppointmentManager
{
    public class User
    {

        public int UserID;

        public string UserName;

        public User(int userId, string userName)
        {
            UserID = userId;
            UserName = userName;
        }
    }

}
