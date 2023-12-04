using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCapp.Models;

namespace MVCapp.Data
{
    public class MVCappContext : DbContext
    {
        public MVCappContext (DbContextOptions<MVCappContext> options)
            : base(options)
        {
        }

        public DbSet<MVCapp.Models.Movie> Movie { get; set; } = default!;
    }
}
