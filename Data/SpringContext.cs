using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Spring.Models;

namespace Spring.Data
{
    public class SpringContext : DbContext
    {
        public SpringContext (DbContextOptions<SpringContext> options)
            : base(options)
        {
        }

        public DbSet<Spring.Models.Furniture> Furniture { get; set; } = default!;
    }
}
