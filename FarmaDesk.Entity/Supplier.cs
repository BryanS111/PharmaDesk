using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaDesk.Entity
{
    public class Supplier
    {
        [Key]
        public int ID_Proveedor { get; set; }

        [Required]
        [StringLength(200)]
        public string Proveedor { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Correo { get; set; }

        [Required]
        [StringLength(300)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string NIT { get; set; }

        [StringLength(20)]
        public string NRC { get; set; }

        [Required]
        public int ID_Estado { get; set; }

        [ForeignKey("ID_Estado")]
        public virtual State Estado { get; set; }
    }
}
