using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ValueObject;

namespace QuickBuy.Repositorio.Config
{
    public class FormPaymentConfiguration : IEntityTypeConfiguration<FormPayment>
    {
        public void Configure(EntityTypeBuilder<FormPayment> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Name).IsRequired().HasMaxLength(50);
            builder.Property(f => f.Description).IsRequired().HasMaxLength(100);
        }
    }
}
