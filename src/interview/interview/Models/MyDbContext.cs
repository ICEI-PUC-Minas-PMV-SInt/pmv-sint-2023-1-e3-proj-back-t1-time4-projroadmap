using Microsoft.EntityFrameworkCore;
using interview.Models;

namespace interview.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
         
        }

        public DbSet<Usuario>? Usuarios { get; set; }

        public DbSet<Perguntas>? Perguntas { get; set; }

        public DbSet<Quiz>? Quiz { get; set; }

        public DbSet<Tema>? Tema { get; set; }

        public DbSet<Score> Score { get; set; }

        public DbSet<Respostas>? Respostas { get; set; }

    }
}
