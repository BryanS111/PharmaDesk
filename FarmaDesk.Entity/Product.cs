using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    [Table("Producto")]
    public class ProductoEntity
    {
        [Key]
        public int ID_Producto { get; set; }

        [Required]
        public int ID_Categoria { get; set; }

        [Required]
        [StringLength(150)]
        public string Producto { get; set; } = string.Empty;

        [StringLength(250)]
        public string? Descripcion { get; set; }

        [Required]
        public decimal Precio_Compra_Unidad { get; set; }

        [Required]
        public decimal Precio_Venta_Unidad { get; set; }

        [Required]
        public int Stock_Minimo { get; set; }

        [Required]
        public int ID_Estado { get; set; }
    }
}
