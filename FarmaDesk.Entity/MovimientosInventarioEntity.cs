using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    [Table("Movimientos_Inventario")]
    public class Movimientos_InventarioEntity
    {
        [Key]
        public int ID_Movimiento { get; set; }

        [Required]
        public int ID_Producto { get; set; }

        [Required]
        [StringLength(20)]
        public string Tipo { get; set; } = string.Empty;

        [Required]
        public int Cantidad_Unidades { get; set; }

        public int? ID_Compra { get; set; }

        public int? ID_Venta { get; set; }

        [Required]
        public int ID_Usuario { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [StringLength(250)]
        public string? Observacion { get; set; }
    }
}
