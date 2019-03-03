using System;

namespace Blackbox.Client.Domain
{
    [Serializable()]
    public class AccountBalance
    {
        public int AccountId { get; set; }
        public string Key { get; set; }

        public AccountBalance() { }
        public AccountBalance(int accountId) => AccountId = accountId;
        public AccountBalance(int accountId, string key)
        {
            AccountId = accountId;
            Key = key;
        }
    }
}
