using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrientedObjectBank
{
    public abstract class Account
    {
        public string? number { get; set; }
        public string? OwnerName { get; set; }
        public double balance { get; set; }
        //constructeur
        public Account(string number,string OwnerName, double balance)
        {
            this.number = number;
            this.OwnerName = OwnerName;
            this.balance = balance; 

        }
        //afficher les informations du compte bancaire
        public  void GetInformation(string number)
        { 
            if (number == this.number) 
            {
                Console.WriteLine($"The owner name is {OwnerName} the account balance is {balance}");
            }
        }
        //consulter le solde du compte,virtuel car elle sera redefinie dans le compte epargne en fonction de l'interet
        public virtual void CheckBalance()
        {
            Console.WriteLine($"le solde de votre compte est:{balance}");
            File.AppendAllText(@"C:\Users\DELL\Documents\OrientedObjectBank\fichier.txt", $"le solde de votre compte est:{balance}" 
                + Environment.NewLine);
        }
        //ajouter un montant dans le compte
        public virtual void AddAmount(double amount) 
        { 
            balance += amount;
            File.AppendAllText(@"C:\Users\DELL\Documents\OrientedObjectBank\fichier.txt", $"vous avez fait un depot de:{amount}" +
               $"et votre nouveau solde est de {balance} " + Environment.NewLine);
        }
        //retirer un montant,je declare la signature et je vais redefinir cette fonction dans les classes filles
        public abstract void Withdraw(double amount);
    }
}
