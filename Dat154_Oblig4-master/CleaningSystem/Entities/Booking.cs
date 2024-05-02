using System;
using System.Collections.Generic;

namespace CleaningSystem
{
    public partial class Booking
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public int Roomnr { get; set; }
        public DateTime Checkindate { get; set; }
        public DateTime Checkoutdate { get; set; }

        public virtual Room RoomnrNavigation { get; set; } = null!;
    }
}
