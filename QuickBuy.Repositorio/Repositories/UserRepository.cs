using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using QuickBuy.Repositorio.Context;
using System.Linq;

namespace QuickBuy.Repositorio.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }

        public User GetAll(string email, string password)
        {
            return QuickBuyContext.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}
