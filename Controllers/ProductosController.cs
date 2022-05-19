using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptAkademy.Models;
using ScriptAkademy.Models.ViewModels;
using System.Diagnostics;

namespace ScriptAkademy.Controllers
{
    public class ProductosController : Controller
    {

        private readonly ScriptAkademyContext _productos;

        public ProductosController(ScriptAkademyContext productos)
        {
            _productos = productos;
        }

        public IActionResult Index()
        {
            List<Producto> productos = _productos.Productos.Include(c => c.oEstadoProducto).Include(c => c.oTipoProducto).Include(c => c.oUsuariosP).ToList();

            return View(productos);
        }

        [HttpGet]
        public IActionResult Producto_Detalle(int Idproducto)
        {

            ProductoE oProductoE = new ProductoE()
            {

                oProducto = new Producto(),
                listadoEstadoP = _productos.EstadoProductos.Select(estado => new SelectListItem()
                {

                    Text = estado.EstadoProducto1,
                    Value = estado.IdestadoProducto.ToString()

                }).ToList(),
                listadoTipoP = _productos.TipoProductos.Select(tipo => new SelectListItem()
                {

                    Text = tipo.TipoProducto1,
                    Value = tipo.IdtipoProducto.ToString()

                }).ToList(),
                listadoUsuario = _productos.Usuarios.Select(usuario => new SelectListItem()
                {

                    Text = usuario.Nombre,
                    Value = usuario.IdUsuario.ToString()

                }).ToList()

            };

            if (Idproducto != 0)
            {
                oProductoE.oProducto = _productos.Productos.Find(Idproducto);
            }

            return View(oProductoE);

        }

        [HttpPost]
        public IActionResult Producto_Detalle(ProductoE objetoP)
        {

            if (objetoP.oProducto.IdProductos == 0)
            {
                _productos.Productos.Add(objetoP.oProducto);
            }
            else
            {
                _productos.Productos.Update(objetoP.oProducto);
            }

            _productos.SaveChanges();

            return RedirectToAction("Index", "Productos");
        }


        [HttpGet]
        public IActionResult Eliminar(int Idproducto)
        {

            Producto obProducto = _productos.Productos.Include(c => c.oEstadoProducto).Where(o => o.IdProductos == Idproducto).Include(c => c.oTipoProducto).Where(o => o.IdProductos == Idproducto).Include(c => c.oUsuariosP).Where(o => o.IdProductos == Idproducto).FirstOrDefault();

            return View(obProducto);

        }

        [HttpPost]
        public IActionResult Eliminar(Producto objetoP) 
        {

            _productos.Productos.Remove(objetoP);
            _productos.SaveChanges();

            return View(objetoP);
        }

    }
}
