using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.RoomService
{
    public interface IRoomService
    {
        Task<List<Room>> GetRooms();
        Task<Room> GetRoomByID(int roomID);
        Task<List<Room>> GetApartmentRooms(int apartmentID);
        Task<Room> AddRoom(Room room);
        Task<Apartment> GetApartmentByRoomID(int roomID);
        Task<User> GetUserByRoomID(int roomID);
    }
}
