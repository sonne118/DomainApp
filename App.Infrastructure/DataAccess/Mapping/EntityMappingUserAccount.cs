using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Domain.Model;

namespace App.Infrastructure.DataAccess.Mapping
{
    internal class EntityMappingUserAccount : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.Property(p => p.UserId).IsRequired().HasMaxLength(30).IsConcurrencyToken();
            builder.Property(p => p.AccountBalance).IsRequired().HasMaxLength(30);
            builder.Property(p => p.BonusAccounts).IsRequired().HasMaxLength(30);
            builder.Property(p => p.Currency).IsRequired().HasMaxLength(5);
            builder.Property(p => p.Email).HasMaxLength(15);
        }
    }
}