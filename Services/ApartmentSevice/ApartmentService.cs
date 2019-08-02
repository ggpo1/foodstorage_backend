using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;

namespace FoodStorage_Backend.Services.ApartmentSevice
{
    public class ApartmentService : IApartmentService
    {
        public Task<List<Apartment>> GetApartments()
        {
            return Task.Run(() => MyDb.db.Apartments.ToList());
        }
    }
}
