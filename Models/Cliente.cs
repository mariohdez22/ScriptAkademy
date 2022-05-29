using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScriptAkademy.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Venta = new HashSet<Venta>();
        }

        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El correo es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 10)]
        public string Correo { get; set; } = null!;

        [Required(ErrorMessage = "La contraseña es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string? Contrasena { get; set; }

        public virtual ICollection<Venta> Venta { get; set; }
    }
}
