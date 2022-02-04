using System;

namespace AtelierOO_101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Le Financier!");
            CalculerRendementErgo();
            //CalculerRemboursementPret();
        }

        static void CalculerRendementErgo()
        {
            string strDepot;
            string strTauxInt;
            string strDuree;

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
            Console.WriteLine("Paramètres:\nDépôt: {0}\nTaux intérêt:{1}\nDurée:{2}", strDepot, strTauxInt, strDuree);

            Depot = Convert.ToDouble(strDepot);
            tauxInt = Convert.ToDouble(strTauxInt);
            duree = Convert.ToInt32(strDuree);
            rendementCumul = Depot;

            int tempsCumul = 0;
            while (tempsCumul < duree)
            {
                tempsCumul++;
                rendementCumul += tauxInt * rendementCumul;
                Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul);
            }

            Console.WriteLine("A terme mon dépot vaut: {0}", rendementCumul);
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




