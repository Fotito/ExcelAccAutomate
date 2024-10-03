using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace getBalancesAndDifference
{
    internal class combinedAccount
    {
        private string ID;
        private double  capitalAmount;
        private double balanceWithFees;
        private double balanceWithoutFees;
        private double fastaBalance;
        private double Comparison;
        private string comment;
        public combinedAccount(string ID, double capitalAmount, double balaceWfee, double balanceNoFee, double fastaBalance) {
        this.ID = ID;
            this.capitalAmount = capitalAmount;
            this.balanceWithFees = balaceWfee;

            this.balanceWithoutFees = balanceNoFee;
            this.fastaBalance = fastaBalance;
            this.Comparison = fastaBalance - balanceWithoutFees;

            if (this.Comparison > 0) {
                this.comment = "RSA payment not processed";

            } else { this.comment = "Fasta Payment not processed"; }

        }
    }
}
