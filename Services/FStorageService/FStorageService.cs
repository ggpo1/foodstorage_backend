using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;

namespace FoodStorage_Backend.Services.FStorageService
{
    public class FStorageService : IFStorageService
    {
        public Task<FStorage> AddFStorage(FStorage fstorage)
        {
            MyDb.db.FStorages.Add(fstorage);
            MyDb.db.SaveChanges();
            return Task.Run(() => fstorage);
        }

        public Task<Room> GetRoomByFStorageID(int fstorageID)
        {
            return Task.Run(() => MyDb.db.FStorages.FirstOrDefault(elem => elem.FStorageID == fstorageID).Room);
        }

        public Task<FStorage> GetFStorageByID(int fstorageID)
        {
            return Task.Run(() => MyDb.db.FStorages.FirstOrDefault(elem => elem.FStorageID == fstorageID));
        }

        public Task<List<FStorage>> GetFStorages()
        {
            return Task.Run(() => MyDb.db.FStorages.ToList());
        }

        public Task<List<FStorage>> GetRoomFStorages(int roomID)
        {
            return Task.Run(() => MyDb.db.FStorages.Where(elem => elem.RoomID == roomID).ToList());
        }

        public Task<User> GetUserByFStorageID(int fstorageID)
        {
            return Task.Run(() => MyDb.db.FStorages.FirstOrDefault(elem => elem.FStorageID == fstorageID).Room.Apartment.User);
        }

        public Task<Apartment> GetApartmentByFStorageID(int fstorageID)
        {
            return Task.Run(() => MyDb.db.FStorages.FirstOrDefault(elem => elem.FStorageID == fstorageID).Room.Apartment);
        }

    }
}
