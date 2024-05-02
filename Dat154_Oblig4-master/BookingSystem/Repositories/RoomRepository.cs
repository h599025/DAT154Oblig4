using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;

namespace BookingSystem.Repositories
{

    public interface IRoomRepository
    {
        public IEnumerable<Room> GetAllRooms();
        public Room getRoomByRoomNumber(int number);
    }


    public class RoomRepository : IRoomRepository
    {
        private dat154Context dx = new();
        public IEnumerable<Room> GetAllRooms()
        {
            return dx.Rooms.Include(r => r.Bookings).AsNoTracking().AsEnumerable();
        }

        public Room getRoomByRoomNumber(int number)
        {
            return dx.Rooms.Find(number);
        }
    }
}
