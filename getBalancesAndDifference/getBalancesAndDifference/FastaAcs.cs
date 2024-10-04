using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace getBalancesAndDifference
{
    internal class rsaAcs
    {
        private string loannumber;
        private string title;
        private string fullnames;
        private string surname;
        private string id_number;
        private string debtormobile;
        private string email;
        
        private double closing_balance;

        public rsaAcs(string LoanNum, string title, string name, string surname, 
            string id, string cellNum, string email, double balance) { 
        this.loannumber = LoanNum;
            this.title = title;
            this.fullnames = name;
            this.surname = surname;
            this.id_number = id;
            this.debtormobile = cellNum;
            this.email = email;
            this.closing_balance = balance;
        }
    }
}
