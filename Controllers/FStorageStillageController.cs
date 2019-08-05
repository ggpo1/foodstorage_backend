using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;
using FoodStorage_Backend.Services.FStorageStillageService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FStorageStillageController
    {
        IFStorageStillageService service;

        public FStorageStillageController(IFStorageStillageService service)
        {
            this.service = service;
        }

        #region Get data methods
        [HttpGet]
        public async Task<List<FStorageStillage>> GetFSStillages()
        {
            return await service.GetFSStillages();
        }

        [HttpGet]
        [Route("GetFStorageStillageByID")]
        public async Task<FStorageStillage> GetFStorageStillageByID(int fstorageStillageID)
        {
            return await service.GetFStorageStillageByID(fstorageStillageID);
        }

        [HttpGet]
        [Route("GetFStorageStillages")]
        public async Task<List<FStorageStillage>> GetFStorageStillages(int fstorageID)
        {
            return await service.GetFStorageStillages(fstorageID);
        }

        [HttpGet]
        [Route("GetFStorageByStillageID")]
        public async Task<FStorage> GetFStorageByStillageID(int fstorageStillageID)
        {
            return await service.GetFStorageByStillageID(fstorageStillageID);
        }

        [HttpGet]
        [Route("GetRoomByFStorageStillageID")]
        public async Task<Room> GetRoomByFStorageStillageID(int fstorageStillageID)
        {
            return await service.GetRoomByFStorageStillageID(fstorageStillageID);
        }

        [HttpGet]
        [Route("GetApartmentByFStorageStillageID")]
        public async Task<Apartment> GetApartmentByFStorageStillageID(int fstorageStillageID)
        {
            return await service.GetApartmentByFStorageStillageID(fstorageStillageID);
        }

        [HttpGet]
        [Route("GetUserByFStorageStillageID")]
        public async Task<User> GetUserByFStorageStillageID(int fstorageStillageID)
        {
            return await service.GetUserByFStorageStillageID(fstorageStillageID);
        }
        #endregion

        #region Post data methods
        [HttpPost]
        public async Task<FStorageStillage> AddFStorageStillage([FromBody]FStorageStillage fStorageStillage)
        {
            return await service.AddFStorageStillage(fStorageStillage);
        }

        [HttpPatch]
        public async Task<FStorageStillage> UpdateFStorageStillage([FromBody]FStorageStillage fStorageStillage)
        {
            return await service.UpdateFStorageStillage(fStorageStillage);
        }
        #endregion
    }
}
