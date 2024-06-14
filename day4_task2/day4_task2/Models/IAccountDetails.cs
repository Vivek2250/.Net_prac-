namespace day4_task2.Models
{
    public interface IAccountDetails
    {
        public List<Account> GetAccounts();
    }

    public class AccountDetails : IAccountDetails
    {
        public List<Account> GetAccounts()
        {
            var accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    CustName = "Luffy",
                    AccNumber = 12345,
                    Address = "EggHead",
                    MobileNumber = 234567
                },
                new Account()
                {
                    Id = 2,
                    CustName = "Naruto",
                    AccNumber = 231423,
                    Address = "Konoha",
                    MobileNumber = 098765
                },
                new Account()
                {
                    Id = 1,
                    CustName = "Goku",
                    AccNumber = 84746,
                    Address = "Universe 7",
                    MobileNumber = 947463
                },
                new Account()
                {
                    Id = 1,
                    CustName = "Ichigo",
                    AccNumber = 937473,
                    Address = "Reishi",
                    MobileNumber = 847493
                }

            };
            return accounts;
        }
    }
}
