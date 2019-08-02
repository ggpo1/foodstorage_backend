using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Models.DataBase
{
    public class FStorageStillage
    {
        public int FStorageStillageID { get; set; }
        public int FStorageStillageTypeID { get; set; }
        public int FStorageID { get; set; }
        public virtual FStorage FStorage { get; set; }
        public virtual FStorageStillageType FStorageStillageType { get; set; }
    }
}
