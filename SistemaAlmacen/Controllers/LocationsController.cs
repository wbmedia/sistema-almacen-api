using Microsoft.AspNetCore.Mvc;

namespace SistemaAlmacen.Controllers
{
    public class LocationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
