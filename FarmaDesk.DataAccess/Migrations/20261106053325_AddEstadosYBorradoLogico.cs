using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmaDesk.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddEstadosYBorradoLogico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID_Estado",
                table: "Rol",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "ID_Estado",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "ID_Estado",
                table: "Categoria",
                type: "int",
                nullable: false,
                defaultValue: 1);
            migrationBuilder.CreateIndex(
                name: "IX_Rol_ID_Estado",
                table: "Rol",
                column: "ID_Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ID_Estado",
                table: "Cliente",
                column: "ID_Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_ID_Estado",
                table: "Categoria",
                column: "ID_Estado");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_Estado_ID_Estado",
                table: "Categoria",
                column: "ID_Estado",
                principalTable: "Estado",
                principalColumn: "ID_Estado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Estado_ID_Estado",
                table: "Cliente",
                column: "ID_Estado",
                principalTable: "Estado",
                principalColumn: "ID_Estado",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rol_Estado_ID_Estado",
                table: "Rol",
                column: "ID_Estado",
                principalTable: "Estado",
                principalColumn: "ID_Estado",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_Estado_ID_Estado",
                table: "Categoria");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Estado_ID_Estado",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Rol_Estado_ID_Estado",
                table: "Rol");

            migrationBuilder.DropIndex(
                name: "IX_Rol_ID_Estado",
                table: "Rol");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_ID_Estado",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Categoria_ID_Estado",
                table: "Categoria");


            migrationBuilder.DropColumn(
                name: "ID_Estado",
                table: "Rol");

            migrationBuilder.DropColumn(
                name: "ID_Estado",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "ID_Estado",
                table: "Categoria");
        }
    }
}


