using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_minmalAPI.Model;

namespace WebApplication_minmalAPI.Data
{
    public class MinimalBlogBbContext : DbContext
    {
        public MinimalBlogBbContext (DbContextOptions<MinimalBlogBbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_minmalAPI.Model.Blog> Blog { get; set; } = default!;
    }
}
