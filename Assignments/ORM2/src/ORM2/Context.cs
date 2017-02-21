using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM2
{
    public class BloggingContext : DbContext
    {
        public DbSet<UpdateModel> UpdateModels { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=ORM");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
