using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview()
        {
            var item=new Item() { Id = 1 ,Name="Laptop"};
            return View(item);
        }
    }
}
