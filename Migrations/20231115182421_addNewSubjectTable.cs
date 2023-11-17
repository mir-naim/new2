using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_APU_FlowerShop2023.Migrations
{
    /// <inheritdoc />
    public partial class addNewSubjectTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubjectTable",
                columns: table => new
                {
                    Subject_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTable", x => x.Subject_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectTable");
        }
    }
}
