using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.ApartmentSevice
{
    public interface IApartmentService
    {
        // Get info methods
        Task<List<Apartment>> GetApartments();
        Task<Apartment> GetApartmentByID(int apartmentID);
        Task<List<Apartment>> GetUserApartments(int userID);
        Task<User> GetUserByApartmentID(int apartmentID);

        // Add method
        Task<Apartment> AddApartment(Apartment apartment);

        // Update method
        Task<Apartment> UpdateApartment(Apartment apartment);
    }
}
