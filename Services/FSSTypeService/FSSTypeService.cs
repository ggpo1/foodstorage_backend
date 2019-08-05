using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;

namespace FoodStorage_Backend.Services.FSSTypeService
{
    public class FSSTypeService : IFSSTypeService
    {
        public Task<FStorageStillageType> AddFStorageStillageType(FStorageStillageType fStorageStillageType)
        {
            MyDb.db.FStorageStillageTypes.Add(fStorageStillageType);
            MyDb.db.SaveChanges();
            return Task.Run(() => fStorageStillageType);
        }

        public Task<List<FStorageStillageType>> GetFSSTypes()
        {
            return Task.Run(() => MyDb.db.FStorageStillageTypes.ToList());
        }

        public Task<FStorageStillageType> UpdateFStorageStillageType(FStorageStillageType fStorageStillageType)
        {
            throw new NotImplementedException();
        }
    }
}
