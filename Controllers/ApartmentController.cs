﻿using FoodStorage_Backend.Models.DataBase;
using FoodStorage_Backend.Services.ApartmentSevice;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController
    {
        IApartmentService service;

        public ApartmentController(IApartmentService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<List<Apartment>> GetApartments()
        {
            return await service.GetApartments();
        }

        [HttpGet]
        [Route("getapartmentsbyid")]
        public async Task<Apartment> GetApartmentByID(int apartmentID)
        {
            return await service.GetApartmentByID(apartmentID);
        }

        [HttpGet]
        [Route("getuserapartments")]
        public async Task<List<Apartment>> GetUserApartments(int userID)
        {
            return await service.GetUserApartments(userID);
        }
    }
}
