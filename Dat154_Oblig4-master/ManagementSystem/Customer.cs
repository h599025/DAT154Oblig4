using System;
using System.Collections.Generic;

namespace ManagementSystem
{
    public partial class Customer
    {
        public Customer()
        {
            Bookings = new HashSet<Booking>();
        }

        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
