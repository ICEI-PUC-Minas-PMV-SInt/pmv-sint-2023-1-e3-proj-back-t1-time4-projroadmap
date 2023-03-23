using Microsoft.EntityFrameworkCore;

namespace interview.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Teste> Teste { get; set; }
    }
}
