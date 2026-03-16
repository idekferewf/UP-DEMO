using System.Collections.Generic;

namespace ShoeStoreLib.Models
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User GetUserByLogin(string login);
    }
}
