using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.FStorageStillageService
{
    public interface IFStorageStillageService
    {
        Task<List<FStorageStillage>> GetFSStillages();
        Task<FStorageStillage> GetFStorageStillageByID(int fstorageStillageID);
        Task<List<FStorageStillage>> GetFStorageStillages(int fstorageID);
        Task<FStorage> GetFStorageByStillageID(int fstorageStillageID);
        Task<Room> GetRoomByFStorageStillageID(int fstorageStillageID);
        Task<Apartment> GetApartmentByFStorageStillageID(int fstorageStillageID);
        Task<User> GetUserByFStorageStillageID(int fstorageStillageID);
        Task<FStorageStillage> AddFStorageStillage(FStorageStillage fStorageStillage);
        Task<FStorageStillage> UpdateFStorageStillage(FStorageStillage fStorageStillage);
    }
}
