using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScriptAkademy.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdProductos { get; set; }

        [Required(ErrorMessage = "El nombre de producto es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "La descripcion es obligatorio")] 
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Descripcion { get; set; } = null!;

        [Required(ErrorMessage = "La cantidad es obligatoria")]
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 1)]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "La precio es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 1)]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "La estado es obligatorio")]
        public int IdestadoProducto { get; set; }

        [Required(ErrorMessage = "La estado es obligatorio")]
        public int IdtipoProducto { get; set; }

        [Required(ErrorMessage = "La estado es obligatorio")]
        public int IdUsuario { get; set; }

        public virtual Usuario oUsuariosP { get; set; } = null!;
        public virtual EstadoProducto oEstadoProducto { get; set; } = null!;
        public virtual TipoProducto oTipoProducto { get; set; } = null!;
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
