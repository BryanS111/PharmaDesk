using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaDesk.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    ID_Categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.ID_Categoria);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ID_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ID_Cliente);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    ID_Estado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.ID_Estado);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    ID_Rol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.ID_Rol);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    ID_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Categoria = table.Column<int>(type: "int", nullable: false),
                    Producto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Precio_Compra_Unidad = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Precio_Venta_Unidad = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Stock_Minimo = table.Column<int>(type: "int", nullable: false),
                    ID_Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.ID_Producto);
                    table.ForeignKey(
                        name: "FK_Producto_Categoria_ID_Categoria",
                        column: x => x.ID_Categoria,
                        principalTable: "Categoria",
                        principalColumn: "ID_Categoria",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producto_Estado_ID_Estado",
                        column: x => x.ID_Estado,
                        principalTable: "Estado",
                        principalColumn: "ID_Estado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    ID_Proveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Proveedor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    NIT = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NRC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ID_Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.ID_Proveedor);
                    table.ForeignKey(
                        name: "FK_Proveedor_Estado_ID_Estado",
                        column: x => x.ID_Estado,
                        principalTable: "Estado",
                        principalColumn: "ID_Estado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Rol = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ID_Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID_Usuario);
                    table.ForeignKey(
                        name: "FK_Usuario_Estado_ID_Estado",
                        column: x => x.ID_Estado,
                        principalTable: "Estado",
                        principalColumn: "ID_Estado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_ID_Rol",
                        column: x => x.ID_Rol,
                        principalTable: "Rol",
                        principalColumn: "ID_Rol",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    ID_Inventario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    Stock_Unidades = table.Column<int>(type: "int", nullable: false),
                    Fecha_Actualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.ID_Inventario);
                    table.ForeignKey(
                        name: "FK_Inventario_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presentaciones",
                columns: table => new
                {
                    ID_Presentacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    Presentacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Unidades_Equivalentes = table.Column<int>(type: "int", nullable: false),
                    Precio_Venta = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ID_Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentaciones", x => x.ID_Presentacion);
                    table.ForeignKey(
                        name: "FK_Presentaciones_Estado_ID_Estado",
                        column: x => x.ID_Estado,
                        principalTable: "Estado",
                        principalColumn: "ID_Estado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Presentaciones_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Caja",
                columns: table => new
                {
                    ID_Caja = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Usuario = table.Column<int>(type: "int", nullable: false),
                    Fecha_Apertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Cierre = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Monto_Inicial = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Monto_Final = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    ID_Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caja", x => x.ID_Caja);
                    table.ForeignKey(
                        name: "FK_Caja_Estado_ID_Estado",
                        column: x => x.ID_Estado,
                        principalTable: "Estado",
                        principalColumn: "ID_Estado",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Caja_Usuario_ID_Usuario",
                        column: x => x.ID_Usuario,
                        principalTable: "Usuario",
                        principalColumn: "ID_Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    ID_Compra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Proveedor = table.Column<int>(type: "int", nullable: false),
                    ID_Usuario = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.ID_Compra);
                    table.ForeignKey(
                        name: "FK_Compras_Proveedor_ID_Proveedor",
                        column: x => x.ID_Proveedor,
                        principalTable: "Proveedor",
                        principalColumn: "ID_Proveedor",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Compras_Usuario_ID_Usuario",
                        column: x => x.ID_Usuario,
                        principalTable: "Usuario",
                        principalColumn: "ID_Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    ID_Venta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Cliente = table.Column<int>(type: "int", nullable: true),
                    ID_Usuario = table.Column<int>(type: "int", nullable: false),
                    ID_Caja = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Descuento = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.ID_Venta);
                    table.ForeignKey(
                        name: "FK_Ventas_Caja_ID_Caja",
                        column: x => x.ID_Caja,
                        principalTable: "Caja",
                        principalColumn: "ID_Caja",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ventas_Cliente_ID_Cliente",
                        column: x => x.ID_Cliente,
                        principalTable: "Cliente",
                        principalColumn: "ID_Cliente",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Ventas_Usuario_ID_Usuario",
                        column: x => x.ID_Usuario,
                        principalTable: "Usuario",
                        principalColumn: "ID_Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_Compras",
                columns: table => new
                {
                    ID_Detalle_Compra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Compra = table.Column<int>(type: "int", nullable: false),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    ID_Presentacion = table.Column<int>(type: "int", nullable: false),
                    Cantidad_Por_Presentacion = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Unidades_Totales = table.Column<int>(type: "int", nullable: false, computedColumnSql: "[Cantidad_Por_Presentacion] * [Cantidad]"),
                    Precio_Compra = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_Compras", x => x.ID_Detalle_Compra);
                    table.ForeignKey(
                        name: "FK_Detalle_Compras_Compras_ID_Compra",
                        column: x => x.ID_Compra,
                        principalTable: "Compras",
                        principalColumn: "ID_Compra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalle_Compras_Presentaciones_ID_Presentacion",
                        column: x => x.ID_Presentacion,
                        principalTable: "Presentaciones",
                        principalColumn: "ID_Presentacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_Compras_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle_Ventas",
                columns: table => new
                {
                    ID_Detalle_Venta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Venta = table.Column<int>(type: "int", nullable: false),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    ID_Presentacion = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Unidades_Totales = table.Column<int>(type: "int", nullable: false),
                    Precio_Unitario = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle_Ventas", x => x.ID_Detalle_Venta);
                    table.ForeignKey(
                        name: "FK_Detalle_Ventas_Presentaciones_ID_Presentacion",
                        column: x => x.ID_Presentacion,
                        principalTable: "Presentaciones",
                        principalColumn: "ID_Presentacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_Ventas_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_Ventas_Ventas_ID_Venta",
                        column: x => x.ID_Venta,
                        principalTable: "Ventas",
                        principalColumn: "ID_Venta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movimientos_Inventario",
                columns: table => new
                {
                    ID_Movimiento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Producto = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cantidad_Unidades = table.Column<int>(type: "int", nullable: false),
                    ID_Compra = table.Column<int>(type: "int", nullable: true),
                    ID_Venta = table.Column<int>(type: "int", nullable: true),
                    ID_Usuario = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos_Inventario", x => x.ID_Movimiento);
                    table.ForeignKey(
                        name: "FK_Movimientos_Inventario_Compras_ID_Compra",
                        column: x => x.ID_Compra,
                        principalTable: "Compras",
                        principalColumn: "ID_Compra");
                    table.ForeignKey(
                        name: "FK_Movimientos_Inventario_Producto_ID_Producto",
                        column: x => x.ID_Producto,
                        principalTable: "Producto",
                        principalColumn: "ID_Producto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movimientos_Inventario_Usuario_ID_Usuario",
                        column: x => x.ID_Usuario,
                        principalTable: "Usuario",
                        principalColumn: "ID_Usuario",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movimientos_Inventario_Ventas_ID_Venta",
                        column: x => x.ID_Venta,
                        principalTable: "Ventas",
                        principalColumn: "ID_Venta");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caja_ID_Estado",
                table: "Caja",
                column: "ID_Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Caja_ID_Usuario",
                table: "Caja",
                column: "ID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ID_Proveedor",
                table: "Compras",
                column: "ID_Proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ID_Usuario",
                table: "Compras",
                column: "ID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Compras_ID_Compra",
                table: "Detalle_Compras",
                column: "ID_Compra");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Compras_ID_Presentacion",
                table: "Detalle_Compras",
                column: "ID_Presentacion");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Compras_ID_Producto",
                table: "Detalle_Compras",
                column: "ID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Ventas_ID_Presentacion",
                table: "Detalle_Ventas",
                column: "ID_Presentacion");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Ventas_ID_Producto",
                table: "Detalle_Ventas",
                column: "ID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_Ventas_ID_Venta",
                table: "Detalle_Ventas",
                column: "ID_Venta");

            migrationBuilder.CreateIndex(
                name: "IX_Inventario_ID_Producto",
                table: "Inventario",
                column: "ID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_Inventario_ID_Compra",
                table: "Movimientos_Inventario",
                column: "ID_Compra");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_Inventario_ID_Producto",
                table: "Movimientos_Inventario",
                column: "ID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_Inventario_ID_Usuario",
                table: "Movimientos_Inventario",
                column: "ID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_Inventario_ID_Venta",
                table: "Movimientos_Inventario",
                column: "ID_Venta");

            migrationBuilder.CreateIndex(
                name: "IX_Presentaciones_ID_Estado",
                table: "Presentaciones",
                column: "ID_Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Presentaciones_ID_Producto",
                table: "Presentaciones",
                column: "ID_Producto");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_Categoria",
                table: "Producto",
                column: "ID_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Producto_ID_Estado",
                table: "Producto",
                column: "ID_Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedor_ID_Estado",
                table: "Proveedor",
                column: "ID_Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ID_Estado",
                table: "Usuario",
                column: "ID_Estado");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_ID_Rol",
                table: "Usuario",
                column: "ID_Rol");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ID_Caja",
                table: "Ventas",
                column: "ID_Caja");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ID_Cliente",
                table: "Ventas",
                column: "ID_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ID_Usuario",
                table: "Ventas",
                column: "ID_Usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle_Compras");

            migrationBuilder.DropTable(
                name: "Detalle_Ventas");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "Movimientos_Inventario");

            migrationBuilder.DropTable(
                name: "Presentaciones");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Caja");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
