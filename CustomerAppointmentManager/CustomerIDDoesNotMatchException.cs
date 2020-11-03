using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAppointmentManager
{
    public class CustomerIDDoesNotMatchException : Exception
    {

        public CustomerIDDoesNotMatchException()
        {
        }

        public CustomerIDDoesNotMatchException(string message)
            : base(message)
        {
            MessageBox.Show(message.ToString());
        }

        public CustomerIDDoesNotMatchException(string message, Exception inner)
            : base(message, inner)
        {
            MessageBox.Show(message.ToString());
            MessageBox.Show(inner.ToString());
        }
    }
}
