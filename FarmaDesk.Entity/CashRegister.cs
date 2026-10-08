using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaDesk.Entity
{
    public class CashRegister
    {
        [Key]
        public int ID_Caja { get; set; }

        [Required]
        public int ID_Usuario { get; set; }

        [Required]
        public DateTime Fecha_Apertura { get; set; }

        public DateTime? Fecha_Cierre { get; set; }

        [Required]
        public decimal Monto_Inicial { get; set; }

        public decimal? Monto_Final { get; set; }

        [Required]
        public int ID_Estado { get; set; }

        [ForeignKey("ID_Usuario")]
        public virtual User User { get; set; }

        [ForeignKey("ID_Estado")]
        public virtual State Estado { get; set; }
    }
}
