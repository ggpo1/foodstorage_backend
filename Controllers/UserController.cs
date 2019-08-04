using FoodStorage_Backend.Models;
using FoodStorage_Backend.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }

        #region Get data methods
        [HttpGet]
        public async Task<List<User>> GetUsers()
        {
            return await service.GetUsers();
        }

        [HttpGet]
        [Route("getuserbyid")]
        public async Task<User> GetUserByID(int userID)
        {
            return await service.GetUserByID(userID);
        }
        #endregion
        #region Post data methods
        [HttpPost]
        public async Task<User> AppUser([FromBody]User apartment)
        {
            return await service.AddUser(apartment);
        }
        #endregion
    }
}
