using System.ComponentModel.DataAnnotations;

namespace FarmaDesk.Entity
{
    public class Product
    {
        [Key]
        public int ID_Producto { get; set; }

        [Required]
        [StringLength(150)]
        public string Producto {  get; set; }
        [Required]
        public decimal Precio { get; set; }

        public string Descripcion { get; set; }
        public decimal Precio_Compra_Unidad { get; set; }


    }
}
