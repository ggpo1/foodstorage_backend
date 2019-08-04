using FoodStorage_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserByID(int userID);
        Task<User> AddUser(User user);
    }
}
