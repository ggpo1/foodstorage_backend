using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Models.DataBase
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int ApartmentID { get; set; }
        public virtual Apartment Apartment { get; set; }
    }
}
