using FirstMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVC.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}
