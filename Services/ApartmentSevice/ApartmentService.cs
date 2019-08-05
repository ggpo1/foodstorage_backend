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
        public Task<Apartment> GetApartmentByID(int apartmentID)
        {
            return Task.Run(() => MyDb.db.Apartments.FirstOrDefault(elem => elem.ApartmentID == apartmentID));
        }

        public Task<List<Apartment>> GetUserApartments(int userID)
        {
            return Task.Run(() => MyDb.db.Apartments.Where(elem => elem.UserID == userID).ToList());
        }

        public Task<Apartment> AddApartment(Apartment apartment)
        {
            MyDb.db.Apartments.Add(apartment);
            MyDb.db.SaveChanges();
            return Task.Run(() => apartment);
        }

        public Task<Apartment> UpdateApartment(Apartment apartment)
        {
            MyDb.db.Update(apartment);
            MyDb.db.SaveChanges();
            return Task.Run(() => apartment);
        }

        public Task<User> GetUserByApartmentID(int apartmentID)
        {
            return Task.Run(() => MyDb.db.Apartments.FirstOrDefault(elem => elem.ApartmentID == apartmentID).User);
        }
    }
}
