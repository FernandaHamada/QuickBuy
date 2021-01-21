using QuickBuy.Dominio.Entities;

namespace QuickBuy.Dominio.Contracts
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetAll(string email, string password);
    }
}
