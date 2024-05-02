using System;
using System.Collections.Generic;
using BookingSystem.ExtensionMethods;
using BookingSystem.Models;


namespace BookingSystem.Models
{
    public partial class Room
    {
        public Room()
        {
            
        }

        public Room (int numberOfBeds, RoomSize roomSize)
        {
            Beds = numberOfBeds;
            Size = roomSize;
            Price = Extensions.CalculateRoomPrize(this);
            Bookings = new HashSet<Booking>();
        }

        public int Roomnr { get; set; }
        public int Beds { get; set; }
        public RoomSize Size { get; set; }
        public int? Price { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }

       
    }
    public enum RoomSize
    {
        small,
        medium,
        large
    }
}
