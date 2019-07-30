using System;
using System.Collections.Generic;
using System.Text;

namespace OopBankingProject {
    public class Checking : Account {

        private int LastChkNbr = 0;

        public bool ChkPayment(int ChkNbr, decimal ChkAmount) {
           bool success = this.Withdraw(ChkAmount);
            if(success) {
                this.LastChkNbr = ChkNbr;
                return true;
            }
            return false;

        }

        public override string Print() {
            return base.Print() + $" | {LastChkNbr}";
            
        }


    }
    }

