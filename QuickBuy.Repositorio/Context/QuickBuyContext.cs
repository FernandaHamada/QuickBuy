using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entities;
using QuickBuy.Dominio.ValueObject;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Context
{
    public class QuickBuyContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestItem> RequestItems { get; set; }
        public DbSet<FormPayment> FormPayment { get; set; }

        public QuickBuyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Classes de mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new RequestConfiguration());
            modelBuilder.ApplyConfiguration(new RequestItemConfiguration());
            modelBuilder.ApplyConfiguration(new FormPaymentConfiguration());

            modelBuilder.Entity<FormPayment>().HasData(
                new FormPayment() {
                Id = 1,
                Name = "Boleto",
                Description = "Forma de Pagamento Boleto" },
                new FormPayment()
                {
                    Id = 2,
                    Name = "Cartão de Crédito",
                    Description = "Forma de Pagamento Cartão de Crédito"
                },
                new FormPayment()
                {
                    Id = 3,
                    Name = "Depósito",
                    Description = "Forma de Pagamento Depósito"
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
