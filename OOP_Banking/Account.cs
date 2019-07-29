using System;
using System.Collections.Generic;
using System.Text;

namespace OopBankingProject {

   public class Account {

        public string Number { get; set; }
        private decimal Balance { get; set; } = 0;
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        public virtual string Print() { //Polymorphism
            return $"{this.Number} | ${this.Balance} | {this.Name} "; 
        }

        public bool TransferTo(Account ToAccount, decimal Amount) {
           bool success = this.Withdraw(Amount);
            if(success) {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
        }

        public bool Deposit(decimal Amount) {
            if(Amount <= 0) {
                Console.WriteLine("Deposit amount must be greater than zero.");
            } else {
                this.Balance += Amount;
                return true;
            }
            return false;
        }
        public bool Withdraw(decimal Amount) {
            if(Amount <= 0) {
                Console.WriteLine("Withdrawl amount must be greater than zero.");
                return false;
            }
            else { 
                if(this.Balance >= Amount) {
                    this.Balance -= Amount;
                    return true;
                }

            }
            return true;
        }
        public decimal GetBalance() {
            return this.Balance;
        }
    }
}
