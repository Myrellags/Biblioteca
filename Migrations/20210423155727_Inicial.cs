using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autores",
                columns: table => new
                {
                    AutorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoGeneroAutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Saidas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autores", x => x.AutorID);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaID);
                });

            migrationBuilder.CreateTable(
                name: "Editoras",
                columns: table => new
                {
                    EditoraID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Morada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoras", x => x.EditoraID);
                });

            migrationBuilder.CreateTable(
                name: "Utentes",
                columns: table => new
                {
                    UtenteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telemovel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Morada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtdEmprestimos = table.Column<int>(type: "int", nullable: false),
                    UltimoEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LivrosDevolver = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utentes", x => x.UtenteID);
                });

            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    LivroID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutorID1 = table.Column<int>(type: "int", nullable: true),
                    EditoraID1 = table.Column<int>(type: "int", nullable: true),
                    CategoriaID1 = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataEdicao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.LivroID);
                    table.ForeignKey(
                        name: "FK_Livros_Autores_AutorID1",
                        column: x => x.AutorID1,
                        principalTable: "Autores",
                        principalColumn: "AutorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Livros_Categorias_CategoriaID1",
                        column: x => x.CategoriaID1,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Livros_Editoras_EditoraID1",
                        column: x => x.EditoraID1,
                        principalTable: "Editoras",
                        principalColumn: "EditoraID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Controles",
                columns: table => new
                {
                    ControleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LivroID1 = table.Column<int>(type: "int", nullable: true),
                    CategoriaID1 = table.Column<int>(type: "int", nullable: true),
                    EditoraID1 = table.Column<int>(type: "int", nullable: true),
                    AutorID = table.Column<int>(type: "int", nullable: true),
                    UtenteID1 = table.Column<int>(type: "int", nullable: true),
                    DataSaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Controles", x => x.ControleID);
                    table.ForeignKey(
                        name: "FK_Controles_Autores_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Autores",
                        principalColumn: "AutorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Controles_Categorias_CategoriaID1",
                        column: x => x.CategoriaID1,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Controles_Editoras_EditoraID1",
                        column: x => x.EditoraID1,
                        principalTable: "Editoras",
                        principalColumn: "EditoraID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Controles_Livros_LivroID1",
                        column: x => x.LivroID1,
                        principalTable: "Livros",
                        principalColumn: "LivroID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Controles_Utentes_UtenteID1",
                        column: x => x.UtenteID1,
                        principalTable: "Utentes",
                        principalColumn: "UtenteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Controles_AutorID",
                table: "Controles",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Controles_CategoriaID1",
                table: "Controles",
                column: "CategoriaID1");

            migrationBuilder.CreateIndex(
                name: "IX_Controles_EditoraID1",
                table: "Controles",
                column: "EditoraID1");

            migrationBuilder.CreateIndex(
                name: "IX_Controles_LivroID1",
                table: "Controles",
                column: "LivroID1");

            migrationBuilder.CreateIndex(
                name: "IX_Controles_UtenteID1",
                table: "Controles",
                column: "UtenteID1");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_AutorID1",
                table: "Livros",
                column: "AutorID1");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_CategoriaID1",
                table: "Livros",
                column: "CategoriaID1");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_EditoraID1",
                table: "Livros",
                column: "EditoraID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Controles");

            migrationBuilder.DropTable(
                name: "Livros");

            migrationBuilder.DropTable(
                name: "Utentes");

            migrationBuilder.DropTable(
                name: "Autores");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Editoras");
        }
    }
}
