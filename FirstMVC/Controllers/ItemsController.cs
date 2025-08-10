using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
