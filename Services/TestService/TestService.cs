using FoodStorage_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.TestService
{
    public class TestService : ITestService
    {
        public Task<List<User>> GetTestObject()
        {
            return Task.Run(() => MyDb.db.Users.ToList());
        }
    }
}
