using System;

namespace AtelierOO_101
{
    /// <summary>
    /// Classe principale pour l'atelier du cours 2C6 POO
    /// </summary>
    class Program
    {
        /// <summary>
        /// Point d'entrée pour toutes les expérimentation fait dans le cours 2C6 POO
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Menu();
        }


        /// <summary>
        /// Menu pricipal de l'Atelier
        /// </summary>
        static void Menu()
        {
            ConsoleKeyInfo touche;
            Options();
            while ((touche = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch ( (char)touche.Key)
                {
                    case 'R':
                        Console.ReadKey(false);
                        CalculerRendementErgo();
                        Console.ReadKey(false);
                        break;
                    case 'E':
                        Console.ReadKey(false);
                        CalculerRemboursementPret();
                        Console.ReadKey(false);
                        break;
                    case 'H':
                        ExploHumain.ExplorationHumain();
                        Console.ReadKey(false);
                        break;
                }
                Options();
            }
        }


        /// <summary>
        /// Affcihage des diverses options offertes à l'utilisateur
        /// </summary>
        static void Options()
        {
            AfficherEntete();
            Console.WriteLine("\tR: calculer rendement");
            Console.WriteLine("\tE: remboursement prêt");
            Console.WriteLine("\tH: Classes Humain et Adresse");

            Console.WriteLine("\n\tESC pour quitter");
            Console.Write("\n\tVotre choix :");
        }

        /// <summary>
        /// Affichage d'une entête formatée surper belle présentant le programme 
        /// </summary>
        static void AfficherEntete()
        {
            string entete = "Atelier du cours 2C6 POO";
            Console.Clear();
            for (int i = 0; i < entete.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n" + entete);

            for (int i = 0; i < entete.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(); ;
        }
        /// <summary>
        /// Calcul du rendement d'un dépôt à terme
        /// </summary>
       static void CalculerRendementErgo()
        {
            SaisirParamRendement(out double depot, out double tauxInt, out int duree, out string compo);
            double rendementCumul = depot;

            int tempsCumul = 0;
            int multi = 1;

            switch(compo)
            {
                case "m":
                    multi = 12;
                    break;

                case "q":
                    multi = 365;
                    break;
               
            }
            while (tempsCumul < duree * multi)
            {
                tempsCumul++;
                rendementCumul += tauxInt/multi * rendementCumul;
                Console.WriteLine("iter {0}: rendementCumul {1}", tempsCumul, rendementCumul.ToString(".00"));
            }
            Console.WriteLine("A terme mon dépot vaut: {0}", rendementCumul.ToString(".00"));
        }

        /// <summary>
        ///  Saisie des paramètres nécessaires au calcul d'un rendement sur un dépôt
        /// </summary>
        /// <param name="depot">Valeur du dépôt</param>
        /// <param name="tauxInt">Taux d'intérêt annuel</param>
        /// <param name="duree">Le temps que le dépôt fructufiera</param>
        /// <param name="compo">La fréquence de composition de l'intérêt</param>
        static void SaisirParamRendement(out double depot, out double tauxInt, out int duree, out string compo )
        {
            string depotSaisi;
            string tauxIntSaisi;
            string dureeSaisie;
            
            Console.Clear();
            Console.WriteLine("Depot:");
            depotSaisi = Console.ReadLine();
            Console.WriteLine("Intérêt:");
            tauxIntSaisi = Console.ReadLine();
            Console.WriteLine("Durée:");
            dureeSaisie = Console.ReadLine();
            Console.WriteLine("Composition de l'intérêt:");
            compo = Console.ReadLine();
            Console.WriteLine("Paramètres:\nDépôt: {0}\nTaux intérêt:{1}\nDurée:{2}\ncomposition de l'intérêt:{3}", depotSaisi, tauxIntSaisi, dureeSaisie, compo);

            depot = Convert.ToDouble(depotSaisi);
            tauxInt = Convert.ToDouble(tauxIntSaisi);
            duree = Convert.ToInt32(dureeSaisie);
        }

        /// <summary>
        /// Calcul du temps nécessaire pour rembourser un prêt avec sasie des param par l'utilisateur
        /// </summary>
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

        /// <summary>
        /// Calcul du temps de remboursement d'après des param donnés
        /// </summary>
        /// <param name="bal"></param>
        /// <param name="inte"></param>
        /// <param name="mens"></param>
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




