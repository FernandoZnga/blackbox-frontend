﻿using System;

namespace Blackbox.Client.Domain
{
    [Serializable()]
    public class Deposit
    {
        public int AccountId { get; set; }
        public double Amount { get; set; }
        public string AtmId { get; set; }
        public string Key { get; set; }

        public Deposit() { }
        public Deposit(int accountId, double amount, string atmId)
        {
            AccountId = accountId;
            Amount = amount;
            AtmId = atmId;
        }
        public Deposit(int accountId, double amount, string atmId, string key)
        {
            AccountId = accountId;
            Amount = amount;
            AtmId = atmId;
            Key = key;
        }
    }
}
