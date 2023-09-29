using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperHeroesApp.Models;

namespace SuperHeroesApp.Data
{
    public class ApplicationDbContext : IdentityDbContext

    {

        public DbSet<SuperHero> SuperHeroes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}