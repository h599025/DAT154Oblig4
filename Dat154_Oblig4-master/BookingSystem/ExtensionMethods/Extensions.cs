
using BookingSystem.Models;

namespace BookingSystem.ExtensionMethods
{
    public static class Extensions
    {
        public static int CalculateRoomPrize(this Room room)
        {
            return room.Size switch
            {
                RoomSize.small => 300 + Math.Min(0, (room.Beds - 1)) * 200,
                RoomSize.medium => 600 + Math.Min(0, (room.Beds - 2)) * 200,
                RoomSize.large => 1200 + Math.Min(0, (room.Beds - 2)) * 200,
                _ => 0,
            };
        }

        public static bool IsRoomAvailable(this Booking booking, DateTime startDate, DateTime endDate)
        {

            return !((startDate.CompareTo(booking.Checkindate) >= 0 && startDate.CompareTo(booking.Checkoutdate) < 0)
                      || (endDate.CompareTo(booking.Checkindate) > 0 && endDate.CompareTo(booking.Checkoutdate) <= 0)
                      || (booking.Checkindate.CompareTo(startDate) >= 0 && booking.Checkindate.CompareTo(endDate) < 0));
        }
    }
    /* 
        Value	            Description
        Less than zero	    This instance is earlier than value.
        Zero	            This instance is the same as value.
        Greater than zero	This instance is later than value. 

     */

}
