using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Models.DataBase
{
    public class Apartment
    {
        public int ApartmentID { get; set; }
        public string ApartmentName { get; set; }
        public string ApartmentAddress { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
