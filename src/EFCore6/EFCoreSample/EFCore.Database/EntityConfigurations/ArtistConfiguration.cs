using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCore.Database.EntityConfigurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            var c = new EnumToStringConverter<Gendre>();
            builder.ToTable("ArtistaTable");
            builder.HasKey(t => t.FiscalCode);
            builder.OwnsOne(x => x.CurrentAddress,
                p =>
                {
                    p.Property(t => t.Via).HasColumnName("ShipsToStreet");
                });
            builder.Property(t => t.Gendre).HasConversion(c);
            builder.HasQueryFilter(t => !t.IsDeleted);
        }
    }

    //public class ArtistRolesConfiguration : IEntityTypeConfiguration<ArtistRoles>
    //{
    //    public void Configure(EntityTypeBuilder<ArtistRoles> builder)
    //    {
    //        builder.ToTable("ArtistRoles");
    //    }
    //}
}
