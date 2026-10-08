using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaDesk.Entity
{
    public class User
    {
        [Key]
        public int ID_Usuario { get; set; }

        [Required]
        public int ID_Rol { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(255)]
        public string Clave { get; set; }

        [Required]
        public int ID_Estado { get; set; }

        [ForeignKey("ID_Rol")]
        public virtual Role Rol { get; set; }

        [ForeignKey("ID_Estado")]
        public virtual State Estado { get; set; }
    }
}
