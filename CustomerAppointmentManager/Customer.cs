using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppointmentManager
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public int AddressID { get; set; }

        public int Active { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime LastUpdate { get; set; }

        public string LastUpdatedBy { get; set; }


        // parameterless constructor sets members to default values

        public Customer() : this(0, string.Empty, 0, 0, DateTime.UtcNow, string.Empty, DateTime.UtcNow, string.Empty) { }


        // overloaded constructor sets members to parameter values
        public Customer(int customerId, string customerName, int addressId, int active, DateTime createDate, string cretedBy, DateTime lastUpdate, string lastUpdatedBy)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            AddressID = addressId;
            Active = active;
            CreateDate = createDate;
            CreatedBy = cretedBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;
        }

    }
}
