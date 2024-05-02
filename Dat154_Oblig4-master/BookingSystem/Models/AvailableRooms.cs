namespace BookingSystem.Models
{
    public class AvailableRooms
    {
        public IEnumerable<Room> rooms { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public int roomNr { get; set; }
    }
}
