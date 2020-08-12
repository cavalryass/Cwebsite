using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cwebsite
{
    public class Account
    {
        public double balance { get; set; }
        public string ownerMail { get; set; }
        public double Equity { get; set; }
        public string accountNumber { get; set; }//can be name of person will be the key
        List<BalanceInfornation> balanceInfo;

        public Account(double balance, string ownerMail, double equity, string accountNumber, List<BalanceInfornation> balanceInfo)
        {
            this.balance = balance;
            this.ownerMail = ownerMail;
            Equity = equity;
            this.accountNumber = accountNumber;
            this.balanceInfo = balanceInfo;
        }
    }
    public class BalanceInfornation
    {
        public int key { get; set; }
        public DateTime dateOfTransference { get; set; }
        public double amount { get; set; }
        public string requestTo { get; set; }
        public string requestFrom { get; set; }
        public string comment { get; set; }

        public BalanceInfornation(int key, DateTime dateOfTransference, double amount, string requestTo, string requestFor, string comment)
        {
            this.key = key;
            this.dateOfTransference = dateOfTransference;
            this.amount = amount;
            this.requestTo = requestTo;
            this.requestFrom = requestFor;
            this.comment = comment;
        }
    }
}