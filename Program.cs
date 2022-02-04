using System;

namespace AtelierOO_101
{
    class Program
    {
        static void Main(string[] args)
        {
            //financier();
           /* Humain h1 = new Humain();
            h1.Afficher();

            DateTime d = new DateTime(1989, 9, 13);
            Humain h2 = new Humain(d, "Joe");
            h2.Afficher();*/

            Adresse adr = new Adresse("207", "Rose LaTulippe", "Ste-Adèle", "Honte à Riop");
            Humain h3 = new Humain(new DateTime(2004, 7,27), "Ludovick", adr);
            h3.Afficher();


            /*Humain h4 = new Humain(new DateTime(1802, 2, 26), "Victor Hugo", new DateTime(1885,5,22));
            h4.Afficher();*/
        }
















        static void financier()
        { 
            
            bool go = true;
            ConsoleKey cle;
            while (go)
            {
                Console.Clear();
                Console.WriteLine("Le Financier, entrez vos paramètres:");
                CalculerRendementErgo();
                //CalculerRemboursementPret();

                Console.WriteLine("Appuyz sur une touche pour continuer ou ESC pour terminer");
                cle = Console.ReadKey(true).Key;
                if (cle == ConsoleKey.Escape)
                    go = false;
            }
        }


        static void CalculerRendementErgo()
        {
            string strDepot;
            string strTauxInt;
            string strDuree;
            string strCompo;

            double Depot;
            double tauxInt;
            int duree;
            double rendementCumul = 0;

            Console.WriteLine("Depot:");
            strDepot = Console.ReadLine();
            Console.WriteLine("Intérêt:");
            strTauxInt = Console.ReadLine();
            Console.WriteLine("Durée:");
            strDuree = Console.ReadLine();
            Console.WriteLine("Composition de l'intérêt:");
            strCompo = Console.ReadLine();
            Console.WriteLine("Paramètres:\nDépôt: {0}\nTaux intérêt:{1}\nDurée:{2}\ncomposition de l'intérêt:{3}", strDepot, strTauxInt, strDuree, strCompo);

            Depot = Convert.ToDouble(strDepot);
            tauxInt = Convert.ToDouble(strTauxInt);
            duree = Convert.ToInt32(strDuree);
            rendementCumul = Depot;

            int tempsCumul = 0;

            switch(strCompo)
            {
                case "a":
                    while (tempsCumul < duree)
                    {
                        tempsCumul++;
                        rendementCumul += tauxInt * rendementCumul;
                        Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul.ToString(".00"));
                    }
                    break;

                case "m":
                    while (tempsCumul < duree*12)
                    {
                        tempsCumul++;
                        rendementCumul += tauxInt/12 * rendementCumul;
                        Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul.ToString(".00"));
                    }
                    break;

                case "q":
                    while (tempsCumul < duree*365)
                    {
                        tempsCumul++;
                        rendementCumul += tauxInt/365 * rendementCumul;
                        Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul.ToString(".00"));
                    }
                    break;

                default:
                    Console.WriteLine(" Votre choix de composition {0} est incorrect", strCompo);
                    break;
            }

            Console.WriteLine("A terme mon dépot vaut: {0}", rendementCumul.ToString(".00"));
        }

        static void CalculerRendement()
        {
            double Depot = 1000;
            double tauxInt = 0.10;
            int duree = 35;
            double rendementCumul = Depot;

            int tempsCumul = 0;
            while (tempsCumul < duree)
            {
                tempsCumul++;
                rendementCumul += tauxInt * rendementCumul;
                Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul);
            }
            Console.WriteLine("A terme mon dépot vaut: {0}", rendementCumul);
        }

        static void CalculerRemboursementPret()
        {
            //string strPaiementMinimum;
            string strInteret;
            string strPaiementMensuel;
            string strBalance;

            Console.WriteLine("Balance:");
            strBalance = Console.ReadLine();
            Console.WriteLine("taux d'intérêt:");
            strInteret = Console.ReadLine();
            Console.WriteLine("remboursement mensuel:");
            strPaiementMensuel = Console.ReadLine();
            CalculerRemboursement(Convert.ToDouble(strBalance), Convert.ToDouble(strInteret), Convert.ToDouble(strPaiementMensuel));
        }

        static void CalculerRemboursement(double bal, double inte, double mens)
        {
            double residu = bal;
            Console.WriteLine("Credit de {0} à {1}% avec mensualité de {2} ", residu, inte * 100, mens);
            int nbMois = 0;
            double interetCumul = 0;
            while (residu > 0)
            {
                Console.Write("Mois {0}, intéret: {1} Capital: {2} ", nbMois + 1,
                                                        (residu * inte / 12).ToString(".00"),
                                                        (mens - (residu * inte / 12)).ToString(".00"));
                residu -= mens - ((residu * inte) / 12);
                interetCumul += (residu * inte) / 12;
                Console.WriteLine(" balance à payer : {0}. Intérêt cumulé: {1}", residu.ToString(".00"), interetCumul.ToString(".00"));
                nbMois++;
            }
            Console.WriteLine("Réglement du prêt en {0} mois", nbMois);
        }
    }
}




