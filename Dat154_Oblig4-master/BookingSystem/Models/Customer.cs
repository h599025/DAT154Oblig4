using System;
using System.Collections.Generic;
using BookingSystem.Models;


namespace BookingSystem.Models
{
    public partial class Customer
    {

        public string Email { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Booking> Bookings { get; set; }

        public Customer() { }

        public Customer(string emailAddress, string name, string password)
        {
            Email = emailAddress;
            Name = name;
            Password = password;
        }
    }
}
