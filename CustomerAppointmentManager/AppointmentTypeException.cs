using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAppointmentManager
{
    public class AppointmentTypeException : Exception
    {
        public AppointmentTypeException()
        {
        }

        public AppointmentTypeException(string message) 
            : base (message)
        {
            MessageBox.Show(message.ToString());
        }

        public AppointmentTypeException(string message, Exception inner)
            : base (message, inner)
        {
            MessageBox.Show(message.ToString());
            MessageBox.Show(inner.ToString());
        }
    }
}
