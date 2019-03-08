using System;

namespace Blackbox.Client.Domain
{
    [Serializable()]
    public class AccountBalance
    {
        public int AccountId { get; set; }
        public string AtmId { get; set; }
        public string Key { get; set; }

        public AccountBalance() { }
        public AccountBalance(int accountId, string atmId)
        {
            AccountId = accountId;
            AtmId = atmId;
        }

        public AccountBalance(int accountId, string atmId, string key)
        {
            AccountId = accountId;
            AtmId = atmId;
            Key = key;
        }
    }
}
