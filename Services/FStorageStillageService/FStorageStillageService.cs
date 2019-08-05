using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;

namespace FoodStorage_Backend.Services.FStorageStillageService
{
    public class FStorageStillageService : IFStorageStillageService
    {
        public Task<List<FStorageStillage>> GetFSStillages()
        {
            return Task.Run(() => MyDb.db.FStorageStillages.ToList());
        }

        public Task<FStorageStillage> GetFStorageStillageByID(int fstorageStillageID)
        {
            return Task.Run(() => MyDb.db.FStorageStillages.FirstOrDefault(elem => elem.FStorageStillageID == fstorageStillageID));
        }

        public Task<List<FStorageStillage>> GetFStorageStillages(int fstorageID)
        {
            return Task.Run(() => MyDb.db.FStorageStillages.Where(elem => elem.FStorageID == fstorageID).ToList());
        }

        public Task<FStorageStillage> AddFStorageStillage(FStorageStillage fStorageStillage)
        {
            MyDb.db.FStorageStillages.Add(fStorageStillage);
            MyDb.db.SaveChanges();
            return Task.Run(() => fStorageStillage);
        }

        public Task<FStorageStillage> UpdateFStorageStillage(FStorageStillage fStorageStillage)
        {
            throw new NotImplementedException();
        }

        public Task<Apartment> GetApartmentByFStorageStillageID(int fstorageStillageID)
        {
            return Task.Run(() => MyDb.db.FStorageStillages.FirstOrDefault(elem => elem.FStorageStillageID == fstorageStillageID).FStorage.Room.Apartment);
        }

        public Task<FStorage> GetFStorageByStillageID(int fstorageStillageID)
        {
            return Task.Run(() => MyDb.db.FStorageStillages.FirstOrDefault(elem => elem.FStorageStillageID == fstorageStillageID).FStorage);
        }      

        public Task<Room> GetRoomByFStorageStillageID(int fstorageStillageID)
        {
            return Task.Run(() => MyDb.db.FStorageStillages.FirstOrDefault(elem => elem.FStorageStillageID == fstorageStillageID).FStorage.Room);
        }

        public Task<User> GetUserByFStorageStillageID(int fstorageStillageID)
        {
            return Task.Run(() => MyDb.db.FStorageStillages.FirstOrDefault(elem => elem.FStorageStillageID == fstorageStillageID).FStorage.Room.Apartment.User);
        }

    }
}
