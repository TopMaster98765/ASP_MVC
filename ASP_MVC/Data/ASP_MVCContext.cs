using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_MVC.Models;

namespace ASP_MVC.Data
{
    public class ASP_MVCContext : DbContext
    {
        public ASP_MVCContext (DbContextOptions<ASP_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<ASP_MVC.Models.Movie> Movie { get; set; }
    }
}
