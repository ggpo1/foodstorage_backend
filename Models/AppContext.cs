using FoodStorage_Backend.Models.DataBase;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Models
{
    public class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<FStorage> FStorages { get; set; }
        public DbSet<FStorageStillage> FStorageStillages { get; set; }
        public DbSet<FStorageStillageType> FStorageStillageTypes { get; set; } 
        public DbSet<FStorageStillageProduct> StorageStillageProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TVK49\\SQLEXPRESS;Database=FoodStorage;Trusted_Connection=True");
        }
    }
}
