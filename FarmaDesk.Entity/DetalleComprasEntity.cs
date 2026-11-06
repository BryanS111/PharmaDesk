using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    [Table("Detalle_Compras")]
    public class Detalle_ComprasEntity
    {
        [Key]
        public int ID_Detalle_Compra { get; set; }

        [Required]
        public int ID_Compra { get; set; }

        [Required]
        public int ID_Producto { get; set; }

        [Required]
        public int ID_Presentacion { get; set; }

        [Required]
        public int Cantidad_Por_Presentacion { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int Unidades_Totales { get; private set; }

        [Required]
        public decimal Precio_Compra { get; set; }

        [Required]
        public decimal Subtotal { get; set; }
    }
}
