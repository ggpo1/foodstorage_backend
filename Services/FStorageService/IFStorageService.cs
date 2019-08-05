using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.FStorageService
{
    public interface IFStorageService
    {
        Task<List<FStorage>> GetFStorages();
        Task<FStorage> GetFStorageByID(int fstorageID);
        Task<List<FStorage>> GetRoomFStorages(int roomID);
        Task<FStorage> AddFStorage(FStorage fstorage);
        Task<Room> GetRoomByFStorageID(int fstorageID);
        Task<Apartment> GetApartmentByFStorageID(int fstorageID);
        Task<User> GetUserByFStorageID(int fstorageID);
    }
}
