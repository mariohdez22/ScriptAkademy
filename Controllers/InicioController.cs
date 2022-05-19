using Microsoft.AspNetCore.Mvc;

namespace ScriptAkademy.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
