using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double Balance { get; set; } = 0;
        public void Deposit(double amount) => Balance += amount;

        public BankAccount()
        {
        }
        public void GetBalance() => Console.WriteLine($"Your balance is: {Balance:c2}");
    }
}
