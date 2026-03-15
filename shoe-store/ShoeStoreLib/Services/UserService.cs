namespace ShoeStoreLib.Models
{
    public class UserService
    {
        private IUserRepository repository_;

        public UserService()
        {
            repository_ = new MySQLUserRepository();
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
