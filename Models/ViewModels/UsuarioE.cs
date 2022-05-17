using Microsoft.AspNetCore.Mvc.Rendering;

namespace ScriptAkademy.Models.ViewModels
{
    public class UsuarioE
    {

        public Usuario oUsuario { get; set; }

        public List<SelectListItem> listaEstado { get; set; }

        public List<SelectListItem> listaTipo { get; set; }

    }
}
