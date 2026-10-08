using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaDesk.Entity
{
    internal class Category
    {
        [Key]
        public int iD_Categoria;

        private string categoria;
        [StringLength(80)]

        public int ID_Estado {  get; set; }
        [ForeignKey(nameof(ID_Estado))]
        
        public int Estado { get; set; }

        public int ID_Categoria { get => iD_Categoria; set => iD_Categoria = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
