using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace localDB.Models
{
    public class localDBContext : DbContext
    {
        public localDBContext (DbContextOptions<localDBContext> options)
            : base(options)
        {
        }

        public DbSet<localDB.Models.Movie> Movie { get; set; }
    }
}
