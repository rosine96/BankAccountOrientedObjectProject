using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientedObjectBank
{
    public class SavingAccount : Account
    {
        public float interest { get; set; }
        public SavingAccount(float interest, string number, string OwnerName, double balance) : base(number, OwnerName, balance)
        {
            this.interest = interest;
        }
        public override void AddAmount(double amount)
        {
            base.AddAmount(amount);
            balance +=amount * interest / 100;
        }
        public override void Withdraw(double amount)
        {
            if (amount < balance / 2)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("vous ne pouvez pas retirer plus de la moitie de votre solde");
            }
        }
        
    }
}
