using System;
using System.Collections.Generic;

namespace BookingSystem.Models
{
    public partial class Booking
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public int Roomnr { get; set; }
        public DateTime Checkindate { get; set; }
        public DateTime Checkoutdate { get; set; }

        public virtual Room? RoomnrNavigation { get; set; }
        public virtual Customer? EmailNavigation { get; set; } 

        public Booking() { }
        public Booking(DateTime checkInDate, DateTime checkOutDate, int roomNumber, string emailAddress)
        {
            Checkindate = checkInDate;
            Checkoutdate = checkOutDate;
            Roomnr = roomNumber;
            Email = emailAddress;
        }
    }
}
