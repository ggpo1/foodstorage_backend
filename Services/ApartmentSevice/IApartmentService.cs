using FoodStorage_Backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.ApartmentSevice
{
    public interface IApartmentService
    {
        // Get apartments list
        Task<List<Apartment>> GetApartments();
    }
}
