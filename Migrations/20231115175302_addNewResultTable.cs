using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_APU_FlowerShop2023.Migrations
{
    /// <inheritdoc />
    public partial class addNewResultTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResultTable",
                columns: table => new
                {
                    Result_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_ID = table.Column<int>(type: "int", nullable: false),
                    Teacher_ID = table.Column<int>(type: "int", nullable: false),
                    Subject_ID = table.Column<int>(type: "int", nullable: false),
                    Marks = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultTable", x => x.Result_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResultTable");
        }
    }
}
