using Microsoft.AspNetCore.Mvc;

namespace MyBookLibrary.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
