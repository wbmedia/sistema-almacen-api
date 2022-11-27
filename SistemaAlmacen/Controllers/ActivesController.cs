using Microsoft.AspNetCore.Mvc;

namespace SistemaAlmacen.Controllers
{
    public class ActivesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
