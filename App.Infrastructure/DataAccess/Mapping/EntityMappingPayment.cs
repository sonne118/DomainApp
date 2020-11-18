using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Domain.Model;

namespace App.Infrastructure.DataAccess.Mapping
{
    internal class EntityMappingPayment : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasKey(p => p.PaymentId);
            builder.Property(p => p.SourceCurrency).IsRequired().HasMaxLength(3);
            builder.Property(p => p.TargetCurrency).IsRequired().HasMaxLength(3);
            builder.Property(p => p.TargetValue).IsRequired().HasMaxLength(8);
            builder.Property(p => p.CreateDate).IsRequired().HasMaxLength(12);
            builder.Property(p => p.Status).IsRequired().HasMaxLength(5);
            builder.Property(p => p.IsRemoved).IsRequired();
        }
    }
}