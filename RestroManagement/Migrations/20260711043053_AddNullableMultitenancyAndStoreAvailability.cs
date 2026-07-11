using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestroManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableMultitenancyAndStoreAvailability : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MerchantId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MerchantId",
                table: "Fooditems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StoreFoodItemAvailabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreFoodItemAvailabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StoreFoodItemAvailabilities_Fooditems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "Fooditems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreFoodItemAvailabilities_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "UniqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_MerchantId",
                table: "Orders",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreId",
                table: "Orders",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Fooditems_MerchantId",
                table: "Fooditems",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreFoodItemAvailabilities_FoodItemId",
                table: "StoreFoodItemAvailabilities",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreFoodItemAvailabilities_StoreId",
                table: "StoreFoodItemAvailabilities",
                column: "StoreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fooditems_Merchants_MerchantId",
                table: "Fooditems",
                column: "MerchantId",
                principalTable: "Merchants",
                principalColumn: "UniqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Merchants_MerchantId",
                table: "Orders",
                column: "MerchantId",
                principalTable: "Merchants",
                principalColumn: "UniqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "UniqueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fooditems_Merchants_MerchantId",
                table: "Fooditems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Merchants_MerchantId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "StoreFoodItemAvailabilities");

            migrationBuilder.DropIndex(
                name: "IX_Orders_MerchantId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StoreId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Fooditems_MerchantId",
                table: "Fooditems");

            migrationBuilder.DropColumn(
                name: "MerchantId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MerchantId",
                table: "Fooditems");
        }
    }
}
