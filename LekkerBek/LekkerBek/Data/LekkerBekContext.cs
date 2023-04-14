using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LekkerBek.Models;

namespace LekkerBek.Data
{
    public class LekkerBekContext : DbContext
    {
        public LekkerBekContext (DbContextOptions<LekkerBekContext> options)
            : base(options)
        {
        }

        public DbSet<LekkerBek.Models.Dish> Dish { get; set; } = default!;

        public DbSet<LekkerBek.Models.Customer>? Customer { get; set; }

        public DbSet<LekkerBek.Models.Order>? Order { get; set; }
    }
}
