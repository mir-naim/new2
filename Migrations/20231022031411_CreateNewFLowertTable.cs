using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_APU_FlowerShop2023.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewFLowertTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "flowerType",
                table: "FlowerTable",
                newName: "FlowerType");

            migrationBuilder.RenameColumn(
                name: "flowerPrice",
                table: "FlowerTable",
                newName: "FlowerPrice");

            migrationBuilder.RenameColumn(
                name: "flowerName",
                table: "FlowerTable",
                newName: "FlowerName");

            migrationBuilder.RenameColumn(
                name: "flowerID",
                table: "FlowerTable",
                newName: "FlowerID");

            migrationBuilder.RenameColumn(
                name: "flowerProduceDate",
                table: "FlowerTable",
                newName: "FlowerProducedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FlowerType",
                table: "FlowerTable",
                newName: "flowerType");

            migrationBuilder.RenameColumn(
                name: "FlowerPrice",
                table: "FlowerTable",
                newName: "flowerPrice");

            migrationBuilder.RenameColumn(
                name: "FlowerName",
                table: "FlowerTable",
                newName: "flowerName");

            migrationBuilder.RenameColumn(
                name: "FlowerID",
                table: "FlowerTable",
                newName: "flowerID");

            migrationBuilder.RenameColumn(
                name: "FlowerProducedDate",
                table: "FlowerTable",
                newName: "flowerProduceDate");
        }
    }
}
