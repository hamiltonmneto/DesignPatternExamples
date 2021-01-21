using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExamples.Example01.Manager.Processors.Base
{
    using Domain.Base;

    public abstract class ProcessorBase<T> where T : TransactionBase
    {
        protected T ValidateTransactionType(TransactionBase transaction)
        {
            if (!(transaction is T)) throw new ArgumentException("Invalid Transaction Type");

            return (T)transaction;
        }
    }
}
