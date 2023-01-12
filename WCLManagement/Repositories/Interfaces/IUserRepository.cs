using WCLManagement.Entities;
using WCLManagement.ViewModels;

namespace WCLManagement.Repositories.Interfaces
{
    public interface IUserRepository
    {
        AuthenticateResponseVM Authenticate(AuthenticateRequestVM model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
