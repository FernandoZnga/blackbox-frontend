﻿using System;

namespace Blackbox.Client.Domain
{
    [Serializable()]
    public class Withdraw
    {
        public int AccountId { get; set; }
        public double Amount { get; set; }
        public string AtmId { get; set; }
        public string Key { get; set; }

        public Withdraw() { }
        public Withdraw(int accountId, double amount, string atmId)
        {
            AccountId = accountId;
            Amount = amount;
            AtmId = atmId;
        }
        public Withdraw(int accountId, double amount, string atmId, string key)
        {
            AccountId = accountId;
            Amount = amount;
            AtmId = atmId;
            Key = key;
        }
    }
}
