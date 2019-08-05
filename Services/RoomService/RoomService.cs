using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;

namespace FoodStorage_Backend.Services.RoomService
{
    public class RoomService : IRoomService
    {
        public Task<Room> AddRoom(Room room)
        {
            MyDb.db.Rooms.Add(room);
            MyDb.db.SaveChanges();
            return Task.Run(() => room);
        }

        public Task<Apartment> GetApartmentByRoomID(int roomID)
        {
            return Task.Run(() => MyDb.db.Rooms.FirstOrDefault(elem => elem.RoomID == roomID).Apartment);
        }

        public Task<List<Room>> GetApartmentRooms(int apartmentID)
        {
            return Task.Run(() => MyDb.db.Rooms.Where(elem => elem.ApartmentID == apartmentID).ToList());
        }

        public Task<Room> GetRoomByID(int roomID)
        {
            return Task.Run(() => MyDb.db.Rooms.FirstOrDefault(elem => elem.RoomID == roomID));
        }

        public Task<List<Room>> GetRooms()
        {
            return Task.Run(() => MyDb.db.Rooms.ToList());
        }

        public Task<User> GetUserByRoomID(int roomID)
        {
            return Task.Run(() => MyDb.db.Rooms.FirstOrDefault(elem => elem.RoomID == roomID).Apartment.User);
        }
    }
}
