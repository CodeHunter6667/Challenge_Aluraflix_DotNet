using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aluraflix.Migrations
{
    public partial class EntidadeCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CategoriaId",
                table: "tb_videos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "tb_categorias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_categorias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tb_videos_CategoriaId",
                table: "tb_videos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_videos_tb_categorias_CategoriaId",
                table: "tb_videos",
                column: "CategoriaId",
                principalTable: "tb_categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_videos_tb_categorias_CategoriaId",
                table: "tb_videos");

            migrationBuilder.DropTable(
                name: "tb_categorias");

            migrationBuilder.DropIndex(
                name: "IX_tb_videos_CategoriaId",
                table: "tb_videos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "tb_videos");
        }
    }
}
