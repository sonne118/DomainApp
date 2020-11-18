using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Domain.Model;

namespace App.Infrastructure.DataAccess.Mapping
{
    internal class EntityMappingBonusAccount : IEntityTypeConfiguration<BonusAccount>
    {
        public void Configure(EntityTypeBuilder<BonusAccount> builder)
        {
            builder.HasKey(p => p.BonusAccountId);
            builder.Property(p => p.UserId).IsRequired().HasMaxLength(30).IsConcurrencyToken();
            builder.Property(p => p.SumPerTransaction).IsRequired().HasMaxLength(12);
            builder.Property(p => p.Currency).IsRequired().HasMaxLength(5);
            builder.Property(p => p.PaymentId).IsRequired().HasMaxLength(30);
        }
    }
}