using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaDesk.Entity
{
    internal class State
    {
        [Key]
        public int ID_Estado {  get; set; }
        [Required]
        public string Estado { get; set; }

        //RELACIONES
        public int 
    }
}
