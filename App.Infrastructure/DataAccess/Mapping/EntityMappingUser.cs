using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Domain.Model;

namespace App.Infrastructure.DataAccess.Mapping
{
    internal class EntityMappingUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.UserId);
            builder.Property(p => p.Timestamp).IsRowVersion();
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(30).IsConcurrencyToken();
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(30).IsConcurrencyToken();
            builder.Property(p => p.Adresse).HasMaxLength(15);
            builder.Property(p => p.EMail).HasMaxLength(15);
        }
    }
}