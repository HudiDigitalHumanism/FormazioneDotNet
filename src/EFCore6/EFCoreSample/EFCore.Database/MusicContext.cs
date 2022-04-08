using EFCore.Database.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFCore.Database
{
    public class MusicContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; } = null!;
        public DbSet<PersonRole> PersonRoles { get; set; } = null!;

        public MusicContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
        }
    }
}
