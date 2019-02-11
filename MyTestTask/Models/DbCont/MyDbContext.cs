using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestTask.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Departament> Departaments { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Offering> Offerings { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        { }

        public MyDbContext() { }
    }
}
