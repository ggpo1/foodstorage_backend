using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodStorage_Backend.Migrations
{
    public partial class Models_Reletions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_StorageStillageProducts_FStorageStillageID",
                table: "StorageStillageProducts",
                column: "FStorageStillageID");

            migrationBuilder.CreateIndex(
                name: "IX_StorageStillageProducts_ProductID",
                table: "StorageStillageProducts",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ApartmentID",
                table: "Rooms",
                column: "ApartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeID",
                table: "Products",
                column: "ProductTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_FStorageStillages_FStorageID",
                table: "FStorageStillages",
                column: "FStorageID");

            migrationBuilder.CreateIndex(
                name: "IX_FStorageStillages_FStorageStillageTypeID",
                table: "FStorageStillages",
                column: "FStorageStillageTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_FStorages_RoomID",
                table: "FStorages",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_UserID",
                table: "Apartments",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Users_UserID",
                table: "Apartments",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FStorages_Rooms_RoomID",
                table: "FStorages",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FStorageStillages_FStorages_FStorageID",
                table: "FStorageStillages",
                column: "FStorageID",
                principalTable: "FStorages",
                principalColumn: "FStorageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FStorageStillages_FStorageStillageTypes_FStorageStillageTypeID",
                table: "FStorageStillages",
                column: "FStorageStillageTypeID",
                principalTable: "FStorageStillageTypes",
                principalColumn: "FStorageStillageTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeID",
                table: "Products",
                column: "ProductTypeID",
                principalTable: "ProductTypes",
                principalColumn: "ProductTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Apartments_ApartmentID",
                table: "Rooms",
                column: "ApartmentID",
                principalTable: "Apartments",
                principalColumn: "ApartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StorageStillageProducts_FStorageStillages_FStorageStillageID",
                table: "StorageStillageProducts",
                column: "FStorageStillageID",
                principalTable: "FStorageStillages",
                principalColumn: "FStorageStillageID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StorageStillageProducts_Products_ProductID",
                table: "StorageStillageProducts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Users_UserID",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_FStorages_Rooms_RoomID",
                table: "FStorages");

            migrationBuilder.DropForeignKey(
                name: "FK_FStorageStillages_FStorages_FStorageID",
                table: "FStorageStillages");

            migrationBuilder.DropForeignKey(
                name: "FK_FStorageStillages_FStorageStillageTypes_FStorageStillageTypeID",
                table: "FStorageStillages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeID",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Apartments_ApartmentID",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageStillageProducts_FStorageStillages_FStorageStillageID",
                table: "StorageStillageProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_StorageStillageProducts_Products_ProductID",
                table: "StorageStillageProducts");

            migrationBuilder.DropIndex(
                name: "IX_StorageStillageProducts_FStorageStillageID",
                table: "StorageStillageProducts");

            migrationBuilder.DropIndex(
                name: "IX_StorageStillageProducts_ProductID",
                table: "StorageStillageProducts");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_ApartmentID",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypeID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_FStorageStillages_FStorageID",
                table: "FStorageStillages");

            migrationBuilder.DropIndex(
                name: "IX_FStorageStillages_FStorageStillageTypeID",
                table: "FStorageStillages");

            migrationBuilder.DropIndex(
                name: "IX_FStorages_RoomID",
                table: "FStorages");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_UserID",
                table: "Apartments");
        }
    }
}
