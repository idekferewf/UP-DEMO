namespace ShoeStoreLib
{
    public class User
    {
        private int _id;

        public int Id { get { return _id; } }

        public string Fio { get; set; }

        public UserRole Role { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public User(int id)
        {
            _id = id;
        }
    }
}
