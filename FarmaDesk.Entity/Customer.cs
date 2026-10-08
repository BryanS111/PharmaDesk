using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaDesk.Entity
{
    public class Customer
    {
        [Key]
        public int ID_Cliente { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellido { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(20)]
        public string Documento { get; set; }

        [StringLength(200)]
        public string Direccion { get; set; }
    }
}
