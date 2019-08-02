using FoodStorage_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.TestService
{
    public interface ITestService
    {
        Task<List<User>> GetTestObject();
    }
}
