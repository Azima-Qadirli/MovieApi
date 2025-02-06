using Microsoft.EntityFrameworkCore;
using MovieSite.Domain.Entities;

namespace MovieSite.Persistence.Context
{
    public class MovieSiteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UM6TF1M;Database=MovieApi;Integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Cast> Casts { get; set; }
    }
}
