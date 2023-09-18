using BankApp.Model.Entities;

namespace BankApp.Data
{
    public class DataStore
    {
        private static List<User> registeredUsers = new List<User>();

        public static void AddUser(User user)
        {
            registeredUsers.Add(user);
        }

        public static User GetUserByEmail(string email)
        {
            return registeredUsers.Find(user => user.Email == email);
        }

        public static List<Account> AllAccounts = new List<Account>();
    }
}
