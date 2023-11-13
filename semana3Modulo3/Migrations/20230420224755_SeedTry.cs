using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LabSchool.Migrations
{
    /// <inheritdoc />
    public partial class SeedTry : Migration
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
                    QtdAtendimento = table.Column<int>(type: "int", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nota = table.Column<float>(type: "real", nullable: false),
                    Nome = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", nullable: true),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Pedagogo",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QtdAtendimento = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedagogo", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experiencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormacaoAcademica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Codigo);
                });

            migrationBuilder.InsertData(
                table: "Aluno",
                columns: new[] { "Codigo", "CPF", "DataDeNascimento", "Nome", "Nota", "QtdAtendimento", "Situacao", "Telefone" },
                values: new object[,]
                {
                    { 1, "01234567890", new DateTime(1979, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bart Simpson", 3.5f, 0, "Irregular", "11-11111-1212" },
                    { 2, "01234566844", new DateTime(1981, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa Simpson", 10f, 0, "Ativo", "11-2222-1212" },
                    { 3, "01268785409", new DateTime(1965, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marge Simpson", 9f, 0, "Ativo", "12-7658-1292" },
                    { 4, "01268788888", new DateTime(1981, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milhouse Van Houten", 8f, 0, "Ativo", "12-7658-4444" },
                    { 5, "04444485409", new DateTime(1975, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nelson Muntz", 2f, 0, "Inativo", "14-7777-1292" }
                });

            migrationBuilder.InsertData(
                table: "Pedagogo",
                columns: new[] { "Codigo", "CPF", "DataDeNascimento", "Nome", "QtdAtendimento", "Telefone" },
                values: new object[,]
                {
                    { 1, "4053901190", new DateTime(2000, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Snow", 0, "11-67333-4454" },
                    { 2, "767659875965", new DateTime(1981, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sansa Stark", 0, "22-22333-3454" },
                    { 3, "09678646347", new DateTime(2001, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tyrion Lannister", 0, "33-77333-3454" },
                    { 4, "76768887905", new DateTime(2002, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sandor Clegane", 0, "44-22433-3004" }
                });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Codigo", "CPF", "DataDeNascimento", "Estado", "Experiencia", "FormacaoAcademica", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "4053901190", new DateTime(1982, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ativo", "FullStack", "Mestrado", "Walter White", "11-11111-1212" },
                    { 2, "4053909990", new DateTime(1997, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ativo", "BackEnd", "Graduação Incompleta", "Jesse Pinkman", "44-12311-1212" },
                    { 3, "8883901190", new DateTime(1984, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ativo", "FullStack", "Mestrado", "Hank Schrader", "11-99999-1212" },
                    { 4, "4012301190", new DateTime(1980, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inativo", "FullStack", "Doutorado", "Gustavo Fring", "11-11111-8888" },
                    { 5, "4053909990", new DateTime(1988, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ativo", "FullStack", "Mestrado", "Saul Goodman", "44-19999-1212" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_CPF",
                table: "Aluno",
                column: "CPF",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Pedagogo");

            migrationBuilder.DropTable(
                name: "Professor");
        }
    }
}
