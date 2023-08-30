using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InMyFruits.Models;

namespace InMyFruits.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}