using System;

namespace Blackbox.Client.Domain
{
    [Serializable()]
    public class Withdraw
    {
        public int AccountId { get; set; }
        public double Amount { get; set; }
        public string Key { get; set; }

        public Withdraw() { }
        public Withdraw(int accountId, double amount)
        {
            AccountId = accountId;
            Amount = amount;
        }
        public Withdraw(int accountId, double amount, string key)
        {
            AccountId = accountId;
            Amount = amount;
            Key = key;
        }
    }
}
