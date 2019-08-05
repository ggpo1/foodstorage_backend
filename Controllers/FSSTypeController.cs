using FoodStorage_Backend.Models.DataBase;
using FoodStorage_Backend.Services.FSSTypeService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FSSTypeController
    {
        IFSSTypeService service;

        public FSSTypeController(IFSSTypeService service)
        {
            this.service = service;
        }

        #region Get data methods
        [HttpGet]
        public async Task<List<FStorageStillageType>> GetFSSTypes()
        {
            return await service.GetFSSTypes();
        }
        #endregion
        #region Post data methods
        [HttpPost]
        public async Task<FStorageStillageType> AddFSSType([FromBody]FStorageStillageType stillageType)
        {
            return await service.AddFStorageStillageType(stillageType);
        }
        [HttpPatch]
        public async Task<FStorageStillageType> UpdateFSSType([FromBody]FStorageStillageType stillageType)
        {
            return await service.UpdateFStorageStillageType(stillageType);
        }
        #endregion
    }
}
