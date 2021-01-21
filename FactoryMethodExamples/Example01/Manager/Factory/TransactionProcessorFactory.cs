﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExamples.Example01.Manager.Factory
{
    using Domain.ValueObj;
    using Processors;
    using Processors.Interfaces;

    public static class TransactionProcessorFactory
    {
        public static ITransactionProcessor CreateTransactionProcessor(TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.CreditCard: return new CrediCardTransactionProcessor();
                case TransactionType.Debit: return new DebitTransactionProcessor();
                case TransactionType.PaymentSlip: return new PaymentSlipTransactionProcessor();

                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
