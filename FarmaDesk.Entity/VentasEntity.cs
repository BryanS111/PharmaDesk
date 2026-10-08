using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    [Table("Ventas")]
    public class VentasEntity
    {
        [Key]
        public int ID_Venta { get; set; }

        public int? ID_Cliente { get; set; }

        [Required]
        public int ID_Usuario { get; set; }

        [Required]
        public int ID_Caja { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public decimal Descuento { get; set; }
    }
}
