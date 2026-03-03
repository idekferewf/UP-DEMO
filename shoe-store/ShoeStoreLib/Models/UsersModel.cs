namespace ShoeStoreLib.Models
{
    public class UsersModel
    {
        private IUsersRepository usersRepository_;

        public UsersModel()
        {
            usersRepository_ = new MySQLUserRepository();
        }

        public User Login(string login, string password)
        {
            User user = usersRepository_.GetUserByLogin(login);
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
