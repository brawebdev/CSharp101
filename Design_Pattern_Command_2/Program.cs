﻿using Design_Pattern_Command_2.Commands;
using Design_Pattern_Command_2.Commands.ConcreteCommands;
using Design_Pattern_Command_2.Invoker;
using Design_Pattern_Command_2.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Command_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Receiver
            //Example of Liskov Substitution Principle:
                //If S (CheckingAccount, SavingsAccount) is a subtype of T (IBankAccount),
                //then objects of type T (IBankAccount) may be replaced with object of type S (CheckingAccount, SavingsAccount).
            IBankAccount checkingAccount = new CheckingAccount();
            IBankAccount savingsAccount = new SavingsAccount();

            //Concrete commands
            ICommand addToChecking = new Add(checkingAccount);
            ICommand subtractFromChecking = new Subtract(checkingAccount);
            ICommand getBalanceOfChecking = new Get(checkingAccount);
            ICommand revertChecking = new Revert(checkingAccount);

            ICommand addToSavings = new Add(savingsAccount);
            ICommand subtractFromSavings = new Subtract(savingsAccount);
            ICommand getBalanceOfSavings = new Get(savingsAccount);
            ICommand revertSavings = new Revert(savingsAccount);

            //Invoker
            BankAccountInvoker checkingInvoker = new BankAccountInvoker(addToChecking, subtractFromChecking, getBalanceOfChecking, revertChecking);
            BankAccountInvoker savingsInvoker = new BankAccountInvoker(addToSavings, subtractFromSavings, getBalanceOfSavings, revertSavings);

            checkingInvoker.Add(10);
            checkingInvoker.Subtract(5);
            checkingInvoker.Revert(1);
            var checkingBalance = checkingInvoker.Get();
            Console.WriteLine(checkingBalance);

            savingsInvoker.Add(8);
            savingsInvoker.Subtract(5);
            savingsInvoker.Revert(1);
            var savingsBalance = savingsInvoker.Get();
            Console.WriteLine(savingsBalance);

            Console.ReadLine();
        }
    }
}
