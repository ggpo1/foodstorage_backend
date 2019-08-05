using FoodStorage_Backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.FSSTypeService
{
    public interface IFSSTypeService
    {
        Task<List<FStorageStillageType>> GetFSSTypes();
        Task<FStorageStillageType> AddFStorageStillageType(FStorageStillageType fStorageStillageType);
        Task<FStorageStillageType> UpdateFStorageStillageType(FStorageStillageType fStorageStillageType);
    }
}
