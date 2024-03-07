using System.ComponentModel.DataAnnotations;

namespace pruevas_de_a_5.Models
{
    public class Producto
    {
        [Key]
        public int Cod_producto { get; set; }
        public string Nom_producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string Fecha_Elaboracio { get; set; }
        public string Fecha_Caducidad { get; set; }
        public int CodCategoria { get; set; }
        public string CodProveedor { get; set; }

    }
}
