using Microsoft.EntityFrameworkCore;
using interview.Models;

namespace interview.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
         
        }


        public DbSet<Teste> Teste { get; set; }

        public DbSet<interview.Models.Perguntas>? Perguntas { get; set; }

        public DbSet<interview.Models.Quiz>? Quiz { get; set; }
    }
}
