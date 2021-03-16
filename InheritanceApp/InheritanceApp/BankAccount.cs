using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    public class BankAccount
    {
        public string AccountNo { get; set; }
        public string CunstomerName { get; set; }
        public double Balance { get; set; }
        public string Deposite(double amount)
        {
            Balance += amount;
            return "Deposited";
        }
        public string Windrow(double)

    }
}
