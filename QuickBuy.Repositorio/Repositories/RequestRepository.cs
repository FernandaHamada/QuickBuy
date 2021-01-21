using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using QuickBuy.Repositorio.Context;

namespace QuickBuy.Repositorio.Repositories
{
    public class RequestRepository : BaseRepository<Request>, IRequestRepository
    {
        public RequestRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
