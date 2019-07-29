using System;

namespace OopBankingProject {

    class Program {

        static void Main(string[] args) {

            Savings sav1 = new Savings();
            sav1.Number = "1004";
            sav1.Name = "New Savings";

            MoneyMarket MM = new MoneyMarket();
            MM.Number = "1003";
            MM.Name = "Money Market";
            MM.IntRate = 0.15;

            MM.Deposit(10989);
            decimal MMInterestPaid = MM.CalcInterest(12);
            MM.PayInterest(MMInterestPaid);

            Account[] accounts = new Account[] { sav1, MM };

            foreach (Account acct in accounts) {
                Console.WriteLine(acct.Print());

            }

            Console.WriteLine(sav1.Print());
            Console.WriteLine(MM.Print());
/*
            Console.WriteLine($"Your Money Market Account balance is ${MM.GetBalance()}");

            bool ItWorked = MM.TransferTo(sav1, 50);
            Console.WriteLine($"Your Money Market Account balance is ${MM.GetBalance()}");
            Console.WriteLine($"Your New Savings Account balance is ${sav1.GetBalance()}");

            Savings sav = new Savings(); //creating a new instance of the savings class, new savings account
            sav.Number = "1002";
            sav.Name = "Savings 1";
            sav.IntRate = 0.05;

            sav.Deposit(200);
            sav.Withdraw(100);
            decimal interestToBePaid = sav.CalcInterest(6);
            sav.PayInterest(interestToBePaid);
            decimal savbal = sav.GetBalance();
            Console.WriteLine($"Savings balance is {savbal}.");

            sav.Deposit(100);
            savbal = sav.GetBalance();
            Console.WriteLine($"Savings balance is {savbal}.");

            sav.Withdraw(150);
            savbal = sav.GetBalance();
            Console.WriteLine($"Savings balance is {savbal}.");



            /*
                        Account acct = new Account(); //Created a new account instance
                        acct.Number = "1001";     //Defined the variable=acct and the property name = number
                        acct.Name = "Test Account";

                        acct.Deposit(20);
                        acct.Withdraw(10);
                        decimal balance = acct.GetBalance();
                        Console.WriteLine($"Account balance is {balance} (should be 10)");
                        acct.Deposit(-10);
                        balance = acct.GetBalance();
                        Console.WriteLine($"Account balance is {balance} (should be 10)");
                        acct.Withdraw(-10);
                        balance = acct.GetBalance();
                        Console.WriteLine($"Account balance is {balance} (should be 10)");
                        acct.Withdraw(20);
                        balance = acct.GetBalance();
                        Console.WriteLine($"Account balance is {balance} (should be 10)");
                */
        }
    }
 }
