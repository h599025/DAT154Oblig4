using BookingSystem.Models;
using BookingSystem.Repositories;
using BookingSystem.ExtensionMethods;

namespace BookingSystem.Services
{

    public interface IRoomService
    {
        public IEnumerable<Room> GetRooms();
        public IEnumerable<Room> GetAvailableRoomsInDateRangeWithRightOrMoreNumberOfBeds(DateTime startDate, DateTime endDate, int numberOfBeds);
    }
    public class RoomService : IRoomService
    {
        public RoomService(IRoomRepository roomRepository)
        {
            this.roomRepository = roomRepository;
        }
        private readonly IRoomRepository roomRepository;

        public IEnumerable<Room> GetAvailableRoomsInDateRangeWithRightOrMoreNumberOfBeds(DateTime startDate, DateTime endDate, int NumberOfBeds)
        {
            var rooms = GetRooms();

            var availableRooms = rooms.Where(r => 
                r.Beds >= NumberOfBeds && r.Bookings.All(b => b.IsRoomAvailable(startDate, endDate))
            );

            return availableRooms;

        }

        public IEnumerable<Room> GetRooms()
        {
            return roomRepository.GetAllRooms();
        }
    }

}
