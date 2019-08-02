using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models;
using FoodStorage_Backend.Services.TestService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodStorage_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        ITestService service;
        public TestController(ITestService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<User>> GetTest()
        {
            return await service.GetTestObject();
        }
    }
}