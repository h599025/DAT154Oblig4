using System;
using System.Collections.Generic;

namespace CleaningSystem
{
    public partial class Room
    {
        public Room()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Roomnr { get; set; }
        public int Beds { get; set; }
        public int Size { get; set; }
        public int? Price { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
