using System;

namespace Blackbox.Server
{
    [Serializable()]
    public class AccountBalance
    {
        public int AccountId { get; set; }

        public AccountBalance() { }
        public AccountBalance(int account)
        {
            AccountId = account;
        }
    }
}
