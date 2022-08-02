using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class FoodContext : DbContext
    {
        public FoodContext (DbContextOptions<FoodContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication3.Models.Cart> Cart { get; set; } = default!;
        public DbSet<WebApplication3.Models.UserList> UserList { get; set; } = default!;
        public DbSet<WebApplication3.Models.OrderMaster> OrderMaster { get; set; } = default!;
        public DbSet<WebApplication3.Models.OrderDetails> OrderDetail { get; set; } = default!;
        public DbSet<WebApplication3.Models.Food> Food { get; set; } = default!;

    }
}
