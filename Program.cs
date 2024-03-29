namespace OrientedObjectBank
{
    internal class Program
    {
        public static bool IsCurrentAccount(string number)
        {
            bool result = (number.StartsWith('8') && number.Length == 6);
            return result;

        }
        public static bool IsSavingAccount(string number)
        {
            bool result = (number.StartsWith('2') && number.Length == 4);
            return result;

        }
        static void Main(string[] args)
        {
            //les numero du compte épargne commencent par 2 et ont 4 caracteres
            //et pour les comptes courants commencent par 8 et ont 6 caracteres
            
            SavingAccount ac1= new SavingAccount(10,"2222", "rosine",1200000);
            CurrentAccount cu1 = new CurrentAccount(300000, "823445", "bosco", 900000);
            CurrentAccount cu2 = new CurrentAccount(200000, "823456", "bosco", 700000);
            SavingAccount ac2 = new SavingAccount(8, "2123", "rosinette", 126500);
            int choix;
            Account[] tab = new Account[] {ac1,cu1,cu2,ac2};

            Console.WriteLine("bonjour entrer votre numero de compte");
            string numero =Console.ReadLine();
            if (IsCurrentAccount(numero) || IsSavingAccount(numero))
            {
                int i = 0;
                int reponse;
                while (i < tab.Length && tab[i].number != numero)
                {
                    i++;
                }
                if (i < tab.Length)
                {
                    
                   do { 
                    Console.WriteLine(@"Quelle operation souhaitez vous effectuer(choisissez un numero)
                                  1-afficher les informations du compte
                                  2-consulter le solde
                                  3-Effectuer un depot
                                  4-effectuer un retrait
                                  5-afficher l'historique du compte
                                  6-Quitter");
                    choix = int.Parse(Console.ReadLine());
                    
                    
                        switch (choix)
                        {
                            case 1:
                                tab[i].GetInformation(numero);
                                break;
                            case 2:
                                tab[i].CheckBalance();
                                break;
                            case 3:
                                Console.WriteLine("entrer le montant á deposer: ");
                                int montant = int.Parse(Console.ReadLine());
                                tab[i].AddAmount(montant);
                                break;
                            case 4:
                                Console.WriteLine("entrer le montant á retirer: ");
                                montant = int.Parse(Console.ReadLine());
                                tab[i].Withdraw(montant);
                                break;
                            case 5:
                                string texte=File.ReadAllText(@"C:\Users\DELL\Documents\OrientedObjectBank\fichier.txt");
                                Console.WriteLine($"{texte}");
                                break;
                            case 6:
                                Environment.Exit(0);
                                break; 
                            default:
                                Console.WriteLine("veuillez selectionner l'une des operations ci dessus");
                                break;

                        }
                        Console.WriteLine(@"souhaitez vous effectuer une autre operation?
                                                     1-oui
                                                     2-non");
                        reponse = int.Parse(Console.ReadLine());
                    }while(reponse==1);

                }

                else
                {
                    Console.WriteLine("Nous ne pouvons acceder á votre compte,allez á la direction pour plus d'informations ");

                }
            }
            else
            {
                Console.WriteLine("ce numero ne respecte pas le format des comptes bancaires de cette banque");
            }
            









        }
    }
}