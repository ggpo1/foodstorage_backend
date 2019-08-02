﻿// <auto-generated />
using FoodStorage_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodStorage_Backend.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20190802134840_Models_Reletions")]
    partial class Models_Reletions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.Apartment", b =>
                {
                    b.Property<int>("ApartmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApartmentAddress");

                    b.Property<string>("ApartmentName");

                    b.Property<int>("UserID");

                    b.HasKey("ApartmentID");

                    b.HasIndex("UserID");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.FStorage", b =>
                {
                    b.Property<int>("FStorageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FStorageName");

                    b.Property<int>("RoomID");

                    b.HasKey("FStorageID");

                    b.HasIndex("RoomID");

                    b.ToTable("FStorages");
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.FStorageStillage", b =>
                {
                    b.Property<int>("FStorageStillageID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FStorageID");

                    b.Property<int>("FStorageStillageTypeID");

                    b.HasKey("FStorageStillageID");

                    b.HasIndex("FStorageID");

                    b.HasIndex("FStorageStillageTypeID");

                    b.ToTable("FStorageStillages");
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.FStorageStillageProduct", b =>
                {
                    b.Property<int>("FStorageStillageProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FStorageStillageID");

                    b.Property<int>("FStorageStillageProductCount");

                    b.Property<int>("ProductID");

                    b.HasKey("FStorageStillageProductID");

                    b.HasIndex("FStorageStillageID");

                    b.HasIndex("ProductID");

                    b.ToTable("StorageStillageProducts");
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.FStorageStillageType", b =>
                {
                    b.Property<int>("FStorageStillageTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FStorageStillageTypeName");

                    b.HasKey("FStorageStillageTypeID");

                    b.ToTable("FStorageStillageTypes");
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName");

                    b.Property<int>("ProductTypeID");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductTypeID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.ProductType", b =>
                {
                    b.Property<int>("ProductTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductTypeName");

                    b.HasKey("ProductTypeID");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApartmentID");

                    b.Property<string>("RoomName");

                    b.HasKey("RoomID");

                    b.HasIndex("ApartmentID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserName");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.Apartment", b =>
                {
                    b.HasOne("FoodStorage_Backend.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.FStorage", b =>
                {
                    b.HasOne("FoodStorage_Backend.Models.DataBase.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.FStorageStillage", b =>
                {
                    b.HasOne("FoodStorage_Backend.Models.DataBase.FStorage", "FStorage")
                        .WithMany()
                        .HasForeignKey("FStorageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodStorage_Backend.Models.DataBase.FStorageStillageType", "FStorageStillageType")
                        .WithMany()
                        .HasForeignKey("FStorageStillageTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.FStorageStillageProduct", b =>
                {
                    b.HasOne("FoodStorage_Backend.Models.DataBase.FStorageStillage", "FStorageStillage")
                        .WithMany()
                        .HasForeignKey("FStorageStillageID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodStorage_Backend.Models.DataBase.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.Product", b =>
                {
                    b.HasOne("FoodStorage_Backend.Models.DataBase.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodStorage_Backend.Models.DataBase.Room", b =>
                {
                    b.HasOne("FoodStorage_Backend.Models.DataBase.Apartment", "Apartment")
                        .WithMany()
                        .HasForeignKey("ApartmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
