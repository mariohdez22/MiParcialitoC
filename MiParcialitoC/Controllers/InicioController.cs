using Microsoft.AspNetCore.Mvc;

namespace MiParcialitoC.Controllers
{
    public class InicioController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}
