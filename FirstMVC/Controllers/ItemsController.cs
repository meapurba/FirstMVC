using FirstMVC.Data;
using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FirstMVC.Controllers
{
    public class ItemsController : Controller
    {
        private readonly MyDbContext _dbcontext;

        public ItemsController(MyDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IActionResult> Index()
        {
            var items=await _dbcontext.Items.ToListAsync();
            return View(items);
        }

        public IActionResult Create() { 

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Name,Price")] Item item)
        {
            if (ModelState.IsValid) { 
                _dbcontext.Items.Add(item);
                await _dbcontext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(item);

        }

        public async Task<IActionResult> Edit(int id)
        {
            var item=await _dbcontext.Items.FirstOrDefaultAsync(x=>x.Id==id);
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Name,Price")] Item item)
        {
            if (ModelState.IsValid)
            {
                _dbcontext.Items.Update(item);
                await _dbcontext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(item);

        }

        public async Task<IActionResult> Delete(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
