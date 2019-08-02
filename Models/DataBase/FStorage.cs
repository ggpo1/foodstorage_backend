using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Models.DataBase
{
    public class FStorage
    {
        public int FStorageID { get; set; }
        public string FStorageName { get; set; }
        public int RoomID { get; set; }
        public virtual Room Room { get; set; }
    }
}
