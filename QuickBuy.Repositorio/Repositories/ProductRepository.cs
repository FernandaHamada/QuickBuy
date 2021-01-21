using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using QuickBuy.Repositorio.Context;

namespace QuickBuy.Repositorio.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
