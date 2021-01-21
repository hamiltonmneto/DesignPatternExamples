using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExamples.Example01.Domain
{
    using Base;
    using ValueObj;

    public sealed class DebitTransaction : TransactionBase
    {
        public string BankName { get; }

        public DebitTransaction(double amount, string bankName) : base(TransactionType.Debit, amount)
        {
            BankName = bankName;
        }
    }
}