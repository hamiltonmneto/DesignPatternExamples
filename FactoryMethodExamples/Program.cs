using FactoryMethodExamples.Example01.Domain;
using FactoryMethodExamples.Example01.Domain.ValueObj;
using FactoryMethodExamples.Example01.Manager.Factory;
using System;

namespace FactoryMethodExamples
{

    class Program
    {
        static void Main(string[] args)
        {

            /*
                *Factory Method
                *
                * Defines an object creation interface, but let your subclass decide which class to instantiate
                * You are considered a "Virtual Construtor"
             */


            //CreditCard Transaction

            var creditCardTransactionProcessor =
                TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.CreditCard);

            var creditCardTransaction = new CreditCardTransaction(
                1000, "Joe Satriani", "222", "1111222233334444");

            var creditCardTransactionInfo = creditCardTransactionProcessor.Authorize(creditCardTransaction);

            Console.WriteLine($"{creditCardTransactionInfo.Amount} | {creditCardTransactionInfo.CreateDate:g} | " +
                              $"{creditCardTransactionInfo.TransactionKey} | {creditCardTransactionInfo.TransactionStatusType}");


            // Debit Transaction

            var debitTransactionProcessor =
                TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.Debit);

            var debitTransaction = new DebitTransaction(1300, "Banco Itaú");

            var debitTransactionInfo = debitTransactionProcessor.Authorize(debitTransaction);

            Console.WriteLine($"{debitTransactionInfo.Amount} | {debitTransactionInfo.CreateDate:g} | " +
                              $"{debitTransactionInfo.TransactionKey} | {debitTransactionInfo.TransactionStatusType}");

        }
    }
}
