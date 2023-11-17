using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_APU_FlowerShop2023.Migrations
{
    /// <inheritdoc />
    public partial class newSurveyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SurveyTable",
                columns: table => new
                {
                    Survey_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Student_ID = table.Column<int>(type: "int", nullable: false),
                    SurveyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Q1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Q3 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Q4 = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Q5 = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyTable", x => x.Survey_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SurveyTable");
        }
    }
}
