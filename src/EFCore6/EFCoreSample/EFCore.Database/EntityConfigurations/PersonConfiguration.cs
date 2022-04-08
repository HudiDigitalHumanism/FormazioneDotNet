using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Database.EntityConfigurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<PersonRole>
    {
        public void Configure(EntityTypeBuilder<PersonRole> builder)
        {
            builder.ToTable("RuoloPersonale");
            builder.HasKey(t => t.RoleName);
            builder.Property(t => t.RoleName).ValueGeneratedNever();
            builder.Property(t => t.EndRole).ValueGeneratedOnUpdate();
        }
    }
}
