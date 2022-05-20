using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptAkademy.Models;
using ScriptAkademy.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ScriptAkademy.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ScriptAkademyContext _clientes;
        public ClientesController(ScriptAkademyContext clientes) { _clientes = clientes; }
        public IActionResult Index()
        {
            List<Cliente> clientes = _clientes.Clientes.ToList();

            return View(clientes);
        }

        [HttpGet]
        public IActionResult Cliente_Detalle(int Idcliente)
        {
            ClienteE oClienteE = new ClienteE()
            {
                oCliente = new Cliente()
            };
            if(Idcliente != 0)
            {
                oClienteE.oCliente = _clientes.Clientes.Find(Idcliente);
            }
            return View(oClienteE);
        }
        [HttpPost]
        public IActionResult Cliente_Detalle(ClienteE objetoC)
        {
            if(objetoC.oCliente.IdCliente == 0)
            {
                _clientes.Clientes.Add(objetoC.oCliente);
            }
            else
            {
                _clientes.Clientes.Update(objetoC.oCliente);
            }
            _clientes.SaveChanges();

            return RedirectToAction("Index","Inicio");
        }
    }
}
