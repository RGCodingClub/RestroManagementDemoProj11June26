using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestroManagement.Migrations
{
    /// <inheritdoc />
    public partial class MultiImageSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Fooditems");

            migrationBuilder.CreateTable(
                name: "FoodItemImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodItemImages_Fooditems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "Fooditems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemImages_FoodItemId",
                table: "FoodItemImages",
                column: "FoodItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodItemImages");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Fooditems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
