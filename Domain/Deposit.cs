﻿using System;

namespace Blackbox.Client.Domain
{
    [Serializable()]
    public class Deposit
    {
        public int AccountId { get; set; }
        public double Amount { get; set; }
        public string Key { get; set; }

        public Deposit() { }
        public Deposit(int accountId, double amount)
        {
            AccountId = accountId;
            Amount = amount;
        }
        public Deposit(int accountId, double amount, string key)
        {
            AccountId = accountId;
            Amount = amount;
            Key = key;
        }
    }
}
