using System.Collections.Generic;

namespace ShoeStoreLib.Models
{
    public class UserService
    {
        private IUserRepository repository_;

        public UserService(IUserRepository repository)
        {
            repository_ = repository;
        }

        public List<User> GetAllUsers()
        {
            return repository_.GetAllUsers();
        }

        public User Login(string login, string password)
        {
            User user = repository_.GetUserByLogin(login);
            return user?.Password == password ? user : null;
        }
    }
}
