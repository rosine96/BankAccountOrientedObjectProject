using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientedObjectBank
{
    public class CurrentAccount:Account
    {
        public double limit { get; set; }
        public CurrentAccount(double limit,string number,string OwnerName,double balance):base(number,OwnerName,balance)
        {
            this.limit = limit;    
        }
        public override void Withdraw(double amount)
        {
        if (amount <= limit)
            {
                balance -= amount;
            }
        else
            {
                Console.WriteLine("Vous avez atteint le pafond de votre compte");
            }
        }
       
    }
}
