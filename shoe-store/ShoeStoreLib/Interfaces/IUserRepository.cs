namespace ShoeStoreLib.Models
{
    public interface IUserRepository
    {
        User GetUserByLogin(string login);
    }
}
