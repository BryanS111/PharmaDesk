using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    [Table("Categoria")]
    public class CategoriaEntity
    {
        [Key]
        public int ID_Categoria { get; set; }

        [Required]
        [StringLength(100)]
        public string Categoria { get; set; } = string.Empty;

        [StringLength(200)]
        public string? Descripcion { get; set; }

        [Required]
        public int ID_Estado { get; set; }

        [ForeignKey(nameof(ID_Estado))]
        public virtual EstadoEntity Estado { get; set; } = null!;
    }
}
