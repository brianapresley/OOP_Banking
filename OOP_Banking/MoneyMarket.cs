using System;
using System.Collections.Generic;
using System.Text;

namespace OopBankingProject {
   public class MoneyMarket : Account {

        public double IntRate { get; set; } = 0.15;

        public override string Print() {
            return base.Print() + $" | {IntRate}";
        }

        public void PayInterest(decimal amountOfInterest) {
            this.Deposit(amountOfInterest);
        }

        public decimal CalcInterest(int months) {
            double interestToBePaid = this.IntRate / 12 * months * (double)this.GetBalance();
            return (decimal)interestToBePaid;
        }
    }
}
