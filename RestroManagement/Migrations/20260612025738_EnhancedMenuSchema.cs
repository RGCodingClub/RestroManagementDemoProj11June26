using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestroManagement.Migrations
{
    /// <inheritdoc />
    public partial class EnhancedMenuSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNonVeg",
                table: "Fooditems");

            migrationBuilder.DropColumn(
                name: "PricePerUnity",
                table: "Fooditems");

            migrationBuilder.AddColumn<int>(
                name: "FoodItemPortionId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                table: "OrderItems",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "DietaryPreference",
                table: "Fooditems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Fooditems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriceCalculationMethod",
                table: "Fooditems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FoodItemPortions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    BaseQuantity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemPortions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodItemPortions_Fooditems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "Fooditems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodItemCategories",
                columns: table => new
                {
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemCategories", x => new { x.FoodItemId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_FoodItemCategories_Fooditems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "Fooditems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodItemCategories_MenuCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MenuCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FoodItemPortionId",
                table: "OrderItems",
                column: "FoodItemPortionId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemCategories_CategoryId",
                table: "FoodItemCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemPortions_FoodItemId",
                table: "FoodItemPortions",
                column: "FoodItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_FoodItemPortions_FoodItemPortionId",
                table: "OrderItems",
                column: "FoodItemPortionId",
                principalTable: "FoodItemPortions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_FoodItemPortions_FoodItemPortionId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "FoodItemCategories");

            migrationBuilder.DropTable(
                name: "FoodItemPortions");

            migrationBuilder.DropTable(
                name: "MenuCategories");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_FoodItemPortionId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "FoodItemPortionId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "DietaryPreference",
                table: "Fooditems");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Fooditems");

            migrationBuilder.DropColumn(
                name: "PriceCalculationMethod",
                table: "Fooditems");

            migrationBuilder.AddColumn<bool>(
                name: "IsNonVeg",
                table: "Fooditems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "PricePerUnity",
                table: "Fooditems",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
