using System;
using System.Collections.Generic;
using System.Text;

namespace OopBankingProject {
   public class Savings : Account {  //Account= name of the inherited class and available 'public' properties

        public double IntRate { get; set; } = 0.03; //interest rate of 3%. To calculate amount int= .03/12 x months x balance

        public bool ChangeRate(double chgRate) { //Added a method to raise or lower the interest rate on the savings account
            if ((this.IntRate + chgRate) < 0) { //To make sure change to IntRate doesn't cause the rate to drop below zero
                return false;
            }
            this.IntRate += chgRate; 
            return true;
        }

        public override string Print() {
            return base.Print() + $" | {IntRate}";
        }

        public void PayInterest (decimal amountOfInterest) {
            this.Deposit(amountOfInterest);
        }

        public decimal CalcInterest(int months) {
            double interestToBePaid = this.IntRate / 12 * months * (double)this.GetBalance();
            return (decimal)interestToBePaid;
        }
    }
}
