using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaDesk.DataAccess.Migrations;

public partial class RemovePricesFromProduct : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "Precio_Compra_Unidad",
            table: "Producto");

        migrationBuilder.DropColumn(
            name: "Precio_Venta_Unidad",
            table: "Producto");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<decimal>(
            name: "Precio_Compra_Unidad",
            table: "Producto",
            type: "decimal(18,2)",
            precision: 18,
            scale: 2,
            nullable: false,
            defaultValue: 0m);

        migrationBuilder.AddColumn<decimal>(
            name: "Precio_Venta_Unidad",
            table: "Producto",
            type: "decimal(18,2)",
            precision: 18,
            scale: 2,
            nullable: false,
            defaultValue: 0m);
    }
}
