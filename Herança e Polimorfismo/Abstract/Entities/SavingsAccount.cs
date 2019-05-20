using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRaste { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRaste) : base(number, holder, balance)
        {
            InterestRaste = interestRaste;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRaste;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
            /*Balance -= amount;*/
        }
    }
}
