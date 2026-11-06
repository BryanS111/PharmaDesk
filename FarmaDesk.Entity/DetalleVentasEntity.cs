using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    [Table("Detalle_Ventas")]
    public class Detalle_VentasEntity
    {
        [Key]
        public int ID_Detalle_Venta { get; set; }

        [Required]
        public int ID_Venta { get; set; }

        [Required]
        public int ID_Producto { get; set; }

        [Required]
        public int ID_Presentacion { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public int Unidades_Totales { get; set; }

        [Required]
        public decimal Precio_Unitario { get; set; }

        [Required]
        public decimal Subtotal { get; set; }
    }
}
