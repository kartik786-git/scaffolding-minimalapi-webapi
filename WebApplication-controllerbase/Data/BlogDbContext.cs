using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_controllerbase.Model;

namespace WebApplication_controllerbase.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext (DbContextOptions<BlogDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_controllerbase.Model.Blog> Blog { get; set; } = default!;
    }
}
