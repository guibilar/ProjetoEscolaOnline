using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineSchool.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carreiras",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carreiras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Documento = table.Column<string>(type: "varchar(14)", nullable: false),
                    TipoPessoa = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CarreiraId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: false),
                    CargaHoraria = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cursos_Carreiras_CarreiraId",
                        column: x => x.CarreiraId,
                        principalTable: "Carreiras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CursosPessoas",
                columns: table => new
                {
                    PessoaId = table.Column<Guid>(nullable: false),
                    CursoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursosPessoas", x => new { x.PessoaId, x.CursoId });
                    table.ForeignKey(
                        name: "FK_CursosPessoas_Pessoas_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Pessoas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CursosPessoas_Cursos_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MateriaisDeApoio",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CursoId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Link = table.Column<string>(type: "varchar(200)", nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MateriaisDeApoio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MateriaisDeApoio_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_CarreiraId",
                table: "Cursos",
                column: "CarreiraId");

            migrationBuilder.CreateIndex(
                name: "IX_CursosPessoas_CursoId",
                table: "CursosPessoas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_MateriaisDeApoio_CursoId",
                table: "MateriaisDeApoio",
                column: "CursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursosPessoas");

            migrationBuilder.DropTable(
                name: "MateriaisDeApoio");

            migrationBuilder.DropTable(
                name: "Pessoas");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Carreiras");
        }
    }
}
