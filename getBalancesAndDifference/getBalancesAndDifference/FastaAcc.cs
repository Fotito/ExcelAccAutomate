using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace getBalancesAndDifference
{
    internal class FastaAcc
    {
        
       private string     Accountnumber;
       private string DebtNumber;
        private string IDNumber;
        private string Names;
        private string Surname;
        private string Initial;
        private string Title;
         private double   CapitalAmt;
          private double  BalOutstanding;

        public FastaAcc(string Accnum, string debtNum, string IDNum, string name, string surname, string initial, string title,
            double capAmmoun, double balanceOutstanding) {
        this.Accountnumber = Accnum;
            this.DebtNumber = debtNum;
            this.IDNumber = IDNum;
            this.Names = name;
            this.Surname = surname;
            this.Initial = initial;
            this.Title = title;
            this.CapitalAmt=capAmmoun;
            this.BalOutstanding=balanceOutstanding;
        }
            
    }
}
