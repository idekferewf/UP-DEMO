using System.Collections.Generic;
using System.Linq;

namespace ShoeStoreLib.Models
{
    public class UserService
    {
        private IUserRepository repository_;

        public UserService()
        {
            repository_ = new MySQLUserRepository();
        }

        public List<string> GetAllLogins()
        {
            return repository_.GetAllUsers().Select(u => u.Login).ToList();
        }

        public User Login(string login, string password)
        {
            User user = repository_.GetUserByLogin(login);

            if (user == null)
            {
                return null;
            }

            if (user.Password == password)
            {
                return user;
            }

            return null;
        }
    }
}
