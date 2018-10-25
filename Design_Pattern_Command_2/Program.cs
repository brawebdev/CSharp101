using Design_Pattern_Command_2.Commands;
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
            IBankAccount checkingAccount = new CheckingAccount();
            IBankAccount savingsAccount = new SavingsAccount();

            //Concrete commands
            ICommand addToChecking = new Add(checkingAccount);
            ICommand subtractFromChecking = new Subtract(checkingAccount);
            ICommand getBalanceOfChecking = new Get(checkingAccount);

            ICommand addToSavings = new Add(savingsAccount);
            ICommand subtractFromSavings = new Subtract(savingsAccount);
            ICommand getBalanceOfSavings = new Get(savingsAccount);

            //Invoker
            BankAccountInvoker checkingInvoker = new BankAccountInvoker(addToChecking, subtractFromChecking, getBalanceOfChecking);
            BankAccountInvoker savingsInvoker = new BankAccountInvoker(addToSavings, subtractFromSavings, getBalanceOfSavings);

            checkingInvoker.Add(10);
            checkingInvoker.Subtract(5);
            var checkingBalance = checkingInvoker.Get();
            Console.WriteLine(checkingBalance);

            savingsInvoker.Add(8);
            savingsInvoker.Subtract(5);
            var savingsBalance = savingsInvoker.Get();
            Console.WriteLine(savingsBalance);

            Console.ReadLine();
        }
    }
}
