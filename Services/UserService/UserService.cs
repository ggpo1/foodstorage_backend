using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models;

namespace FoodStorage_Backend.Services.UserService
{
    public class UserService : IUserService
    {
        public Task<List<User>> GetUsers()
        {
            return Task.Run(() => MyDb.db.Users.ToList());
        }

        public Task<User> GetUserByID(int userID)
        {
            return Task.Run(() => MyDb.db.Users.FirstOrDefault(elem => elem.UserID == userID));
        }

        public Task<User> AddUser(User user)
        {
            MyDb.db.Users.Add(user);
            MyDb.db.SaveChanges();
            return Task.Run(() => user);
        }
    }
}
