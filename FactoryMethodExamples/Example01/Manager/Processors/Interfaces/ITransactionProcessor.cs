using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExamples.Example01.Manager.Processors.Interfaces
{
    using Domain;
    using Domain.Base;

    public interface ITransactionProcessor
    {
        TransactionInfo Authorize(TransactionBase transaction);
    }
}
