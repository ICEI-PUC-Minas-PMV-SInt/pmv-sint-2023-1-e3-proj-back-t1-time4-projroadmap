﻿using Microsoft.EntityFrameworkCore;
using interview.Models;

namespace interview.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
         
        }


        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Perguntas>? Perguntas { get; set; }

        public DbSet<Quiz>? Quiz { get; set; }
    }
}
