using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    [Table("Compras")]
    public class ComprasEntity
    {
        [Key]
        public int ID_Compra { get; set; }

        [Required]
        public int ID_Proveedor { get; set; }

        [Required]
        public int ID_Usuario { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public decimal Total { get; set; }

        [StringLength(250)]
        public string? Observaciones { get; set; }
    }
}
