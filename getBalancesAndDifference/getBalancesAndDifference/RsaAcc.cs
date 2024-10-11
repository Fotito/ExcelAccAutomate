using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace getBalancesAndDifference
{
    internal class RsaAcc
    {
        
       private string     Accountnumber;
       private string DebtNumber;
        private string IDNumber;
        private string Surname;
        private string Initial;
        private string Title;
         private double   CapitalAmt;
          private double  BalOutstanding;
//1,4.5.6.8.9.10.11
        public RsaAcc(string Accnum, string debtNum, string IDNum, string surname, string initial, string title,
            double capAmmoun, double balanceOutstanding) {
        this.Accountnumber = Accnum;
            this.DebtNumber = debtNum;
            this.IDNumber = IDNum;
            this.Surname = surname;
            this.Initial = initial;
            this.Title = title;
            this.CapitalAmt=capAmmoun;
            this.BalOutstanding=balanceOutstanding;
        }
            
    }
}
