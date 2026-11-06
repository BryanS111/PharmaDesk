using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    [Table("Presentaciones")]
    public class PresentacionesEntity
    {
        [Key]
        public int ID_Presentacion { get; set; }

        [Required]
        public int ID_Producto { get; set; }

        [Required]
        [StringLength(50)]
        public string Presentacion { get; set; } = string.Empty;

        [Required]
        public int Unidades_Equivalentes { get; set; }

        [Required]
        public decimal Precio_Venta { get; set; }

        [Required]
        public int ID_Estado { get; set; }
    }
}
