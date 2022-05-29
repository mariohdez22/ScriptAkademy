using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ScriptAkademy.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Productos = new HashSet<Producto>();
        }

        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "La contraseña es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        public string Contrasena { get; set; } = null!;

        [Required(ErrorMessage = "El dui es obligatorio")]
        [StringLength(9, ErrorMessage = "El {0} debe de ser de {2} y maximo {1} caracteres", MinimumLength = 10)]
        public string Dui { get; set; } = null!;

        [Required(ErrorMessage = "El celular es obligatorio")]
        [StringLength(8, ErrorMessage = "El {0} debe de ser de {2} y maximo {1} caracteres", MinimumLength = 9)]
        public string Celular { get; set; } = null!;

        [Required(ErrorMessage = "El Correo es obligatorio")]
        [StringLength(50, ErrorMessage = "El {0} debe de ser de al menos {2} y maximo {1} caracteres", MinimumLength = 10)]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El estado de usuario es obligatorio")]
        public int IdestadoUsuario { get; set; }

        [Required(ErrorMessage = "El tipo de usuario es obligatorio")]
        public int IdtipoUsuario { get; set; }

        public virtual EstadoUsuario oEstadoUsuario { get; set; } = null!;
        public virtual TipoUsuario oTipoUsuario { get; set; } = null!;
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
