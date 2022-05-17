using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptAkademy.Models;
using ScriptAkademy.Models.ViewModels;
using System.Diagnostics;

namespace ScriptAkademy.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly ScriptAkademyContext _usuarios;

        public UsuariosController(ScriptAkademyContext usuarios)
        {
            _usuarios = usuarios;
        }

        public IActionResult Index()
        {
            List<Usuario> usuarios = _usuarios.Usuarios.Include(c => c.oEstadoUsuario).Include(c => c.oTipoUsuario).ToList();
                          
            return View(usuarios);
        }

        [HttpGet]
        public IActionResult Usuario_Detalle(int Idusuario)
        {
            UsuarioE oUsuarioE = new UsuarioE()
            {

                oUsuario = new Usuario(),
                listaEstado = _usuarios.EstadoUsuarios.Select(estado => new SelectListItem()
                {

                    Text = estado.EstadoUsuario1,
                    Value = estado.IdestadoUsuario.ToString()

                }).ToList(),
                listaTipo = _usuarios.TipoUsuarios.Select(tipo => new SelectListItem()
                {

                    Text = tipo.TipoUsuario1,
                    Value = tipo.IdtipoUsuario.ToString()

                }).ToList()

            };

            if (Idusuario != 0)
            {
                oUsuarioE.oUsuario = _usuarios.Usuarios.Find(Idusuario);
            }

            return View(oUsuarioE);
        }

        [HttpPost]
        public IActionResult Usuario_Detalle(UsuarioE objetoU)
        {

            if (objetoU.oUsuario.IdUsuario == 0)
            {
                _usuarios.Usuarios.Add(objetoU.oUsuario);
            }
            else
            {
                _usuarios.Usuarios.Update(objetoU.oUsuario);
            }

            _usuarios.SaveChanges();

            return RedirectToAction("Index", "Usuarios");
        }

        [HttpGet]
        public IActionResult Eliminar(int Idusuario)
        {

            Usuario obUsuario = _usuarios.Usuarios.Include(c => c.oEstadoUsuario).Where(o => o.IdUsuario == Idusuario).Include(c => c.oTipoUsuario).Where(o => o.IdUsuario == Idusuario).FirstOrDefault();

            return View(obUsuario);
        }

        [HttpPost]
        public IActionResult Eliminar(Usuario objetoU)
        {

            _usuarios.Usuarios.Remove(objetoU);
            _usuarios.SaveChanges();

            return View(objetoU);
        }

    }
}
