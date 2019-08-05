using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;
using FoodStorage_Backend.Services.FStorageService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FStorageController
    {
        IFStorageService service;

        public FStorageController(IFStorageService service)
        {
            this.service = service;
        }

        #region Get data methods
        [HttpGet]
        public async Task<List<FStorage>> GetFStorages()
        {
            return await service.GetFStorages();
        }

        [HttpGet]
        [Route("getfstoragebyid")]
        public async Task<FStorage> GetFStorageByID(int fstorageID)
        {
            return await service.GetFStorageByID(fstorageID);
        }

        [HttpGet]
        [Route("getroomfstorages")]
        public async Task<List<FStorage>> GetRoomFStorages(int roomID)
        {
            return await service.GetRoomFStorages(roomID);
        }

        [HttpGet]
        [Route("getroombyfstorageid")]
        public async Task<Room> GetRoomByFStorageID(int fstorageID)
        {
            return await service.GetRoomByFStorageID(fstorageID);
        }

        [HttpGet]
        [Route("getapartmentbyfstorageid")]
        public async Task<Apartment> GetApartmentByFStorageID(int fstorageID)
        {
            return await service.GetApartmentByFStorageID(fstorageID);
        }

        [HttpGet]
        [Route("getuserbyfstorageid")]
        public async Task<User> GetUserByFStorageID(int fstorageID)
        {
            return await service.GetUserByFStorageID(fstorageID);
        }

        #endregion
        #region Post data methods
        [HttpPost]
        public async Task<FStorage> AddFStorage([FromBody] FStorage fstorage)
        {
            return await service.AddFStorage(fstorage);
        }
        #endregion
    }
}
