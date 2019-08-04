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
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<FStorage> FStorages { get; set; }
        public virtual DbSet<FStorageStillage> FStorageStillages { get; set; }
        public virtual DbSet<FStorageStillageType> FStorageStillageTypes { get; set; } 
        public virtual DbSet<FStorageStillageProduct> StorageStillageProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // DESKTOP-4ELF06P
            // TVK49
            optionsBuilder.UseSqlServer("Server=DESKTOP-4ELF06P\\SQLEXPRESS;Database=FoodStorage;Trusted_Connection=True");
        }
    }
}
