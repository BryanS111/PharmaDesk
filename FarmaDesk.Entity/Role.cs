using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmaDesk.Entity
{
    public class Role
    {
        [Key]
        public int ID_Rol {  get; set; }

        [Required]
        [StringLength(50)]
        public string Rol { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [Required]
        public int ID_Estado { get; set; }

        [ForeignKey(nameof(ID_Estado))]
        public virtual EstadoEntity Estado { get; set; } = null!;
    }
}
