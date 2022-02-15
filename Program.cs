using System;
using AtelierOO_101.Classes;
using AtelierOO_101.ClassesExplo;


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
            Menu menu = new Menu();
            menu.Nom = "Atelier de la classe 2C6-101 POO";

            menu.AjouterItem(new MenuItem("Manipulation de fichiers (R/W)", 'M', ExploManipFichier.ExplorationLectureEtEcritureDsFichier)); 
            menu.AjouterItem(new MenuItem("calculer rendement", 'R', CalculerRendementErgo));

            menu.AjouterItem(new MenuItem("remboursement prêt", 'P', CalculerRemboursementPret));
            menu.AjouterItem(new MenuItem("Classes Humain et Adresse", 'C', ExploHumain.ExplorationHumain));
            menu.AjouterItem(new MenuItem("Exploration des tableaux (array) en C#", 'T', ExploSD.ExploArray));
            menu.AjouterItem(new MenuItem("Tableaux d'instances", 'I', ExploSD.ArrayDInstances));
            menu.AjouterItem(new MenuItem("Liste d'instances", 'L', ExploSD.ListeDInstances));

            menu.Afficher();
            menu.SaisirOption();
        }


        /// <summary>
        /// Menu pricipal de l'Atelier
        /// </summary>
        static void MenuOld()
        {
            ConsoleKeyInfo touche;
            ExploSD exSD = new();
            OptionsOld();
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
                    case 'A':
                        ExploSD.ExploArray();
                        Console.ReadKey(false);
                        break;
                    case 'I':
                        ExploSD.ArrayDInstances();
                        Console.ReadKey(false);
                        break;
                    case 'L':
                        ExploSD.ListeDInstances();
                        Console.ReadKey(false);
                        break;
                }
                OptionsOld();
            }
        }


        /// <summary>
        /// Affcihage des diverses options offertes à l'utilisateur
        /// </summary>
        static void OptionsOld()
        {
            AfficherEnteteOld();
            Console.WriteLine("\tR: calculer rendement");
            Console.WriteLine("\tE: remboursement prêt");
            Console.WriteLine("\tH: Classes Humain et Adresse");
            Console.WriteLine("\tA: Exploration des tableaux (array) en C#");
            Console.WriteLine("\tI: Tableaux d'instances");
            Console.WriteLine("\tL: Liste d'instances");

            Console.WriteLine("\n\tESC pour quitter");
            Console.Write("\n\tVotre choix :");
        }

        /// <summary>
        /// Affichage d'une entête formatée surper belle présentant le programme 
        /// </summary>
        static void AfficherEnteteOld()
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
       static int CalculerRendementErgo()
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
            return 0;
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
        static int CalculerRemboursementPret()
        {
            Console.Clear();
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

            return 0;
        }

        /// <summary>
        /// Calcul du temps de remboursement d'après des param donnés
        /// </summary>
        /// <param name="bal">balance résiduelle du prêt</param>
        /// <param name="inte">taux d'intérêt annuel</param>
        /// <param name="mens">mensualités versées</param>
        static void CalculerRemboursement(double bal, double inte, double mens)
        {
            Console.Clear();
            double residu = bal;
            Console.WriteLine("Credit de {0} à {1}% avec mensualité de {2} ", residu, inte * 100, mens);
            int nbMois = 0;
            double interetCumul = 0;

            Console.WriteLine("Mois |  Interet mens |  K mens | Balance | Intérêt Cum");

            while (residu > 0)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", nbMois + 1,
                                                        (residu * inte / 12).ToString(".00"),
                                                        (mens - (residu * inte / 12)).ToString(".00"),
                                                        residu.ToString(".00"),
                                                        interetCumul.ToString(".00"));
                residu -= mens - ((residu * inte) / 12);
                interetCumul += (residu * inte) / 12;
                //Console.WriteLine(" balance à payer : {0}. Intérêt cumulé: {1}", residu.ToString(".00"), interetCumul.ToString(".00"));
                nbMois++;
            }
            Console.WriteLine("Réglement du prêt en {0} mois", nbMois);
        }
    }
}




