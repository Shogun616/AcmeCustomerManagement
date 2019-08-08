using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int EmailAddress { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }

        public void ValidateEmail()
        {
            // -- Send an email receipt --
            // If the user requested a receipt
            // Get the customer data
            // Ensure a valid email address was provided.
            // If not,
            // request an email address from the user.
        }
    }
}
