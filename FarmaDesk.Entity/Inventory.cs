using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    [Table("Inventario")]
    public class InventarioEntity
    {
        [Key]
        public int ID_Inventario { get; set; }

        [Required]
        public int ID_Producto { get; set; }

        [Required]
        public int Stock_Unidades { get; set; }

        [Required]
        public DateTime Fecha_Actualizacion { get; set; }
    }
}
