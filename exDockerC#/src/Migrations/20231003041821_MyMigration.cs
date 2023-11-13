using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LabSchool.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Codigo);
                });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Codigo", "DataDeNascimento", "Email", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(1979, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "manu@gmail.com", "Bart Simpson" },
                    { 2, new DateTime(1981, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "JonasManu@gmail.com", "Lisa Simpson" },
                    { 3, new DateTime(1965, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "manuzinho@gmail.com", "Marge Simpson" },
                    { 4, new DateTime(1981, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "EuMesmo@gmail.com", "Milhouse Van Houten" },
                    { 5, new DateTime(1975, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "manu@gmail.com", "Nelson Muntz" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");
        }
    }
}
