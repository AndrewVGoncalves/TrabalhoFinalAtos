using Microsoft.AspNetCore.Mvc;

namespace TrabalhoFinalAndrew.Controllers
{
    public class ControladorFotos : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
