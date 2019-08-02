using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Models.DataBase
{
    public class FStorageStillageProduct
    {
        public int FStorageStillageProductID { get; set; }
        public int ProductID { get; set; }
        public int FStorageStillageID { get; set; }
        public int FStorageStillageProductCount { get; set; }
        public Product Product { get; set; }
        public FStorageStillage FStorageStillage { get; set; }
    }
}
