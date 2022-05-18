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
        [Required]
        public string Nombre { get; set; } = null!;
        [Required]
        public string Contrasena { get; set; } = null!;
        [Required]
        public string Dui { get; set; } = null!;
        [Required]
        public string Celular { get; set; } = null!;
        [Required]
        public string? Correo { get; set; }
        [Required]
        public int IdestadoUsuario { get; set; }
        [Required]
        public int IdtipoUsuario { get; set; }

        public virtual EstadoUsuario oEstadoUsuario { get; set; } = null!;
        public virtual TipoUsuario oTipoUsuario { get; set; } = null!;
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
