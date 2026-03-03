using System.Collections.Generic;

namespace ShoeStoreLib.Models
{
    public interface IUsersRepository
    {
        User GetUserByLogin(string login);
    }
}
