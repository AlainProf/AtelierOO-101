//-----------------------------------------
//  Nom: Program.cs
//  Auteur : Alain Martel
//  Date : 2025-01-27
//  Description: 
//-----------------------------------------

using AtelierOO_101.ONU;
using AtelierOO_101.TP1;

namespace AtelierOO_101
{
    internal class Program
    {
        static Util u = new Util();
        //------------------------------------------
        //
        //------------------------------------------
        static void Main(string[] args)
        {
            AfficherParam(args);

            bool rester = true;
            while (rester)
            {
                try
                {
                    u.Titre("Atelier du cours POO- gr 1");
                    AfficherMenu();
                    ExecuterChoix(ref rester);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Attention une exception est survenue: " + ex.Message);
                    Console.Write("Voulez-vous continuer? (o/n)");
                    char dec = u.SaisirChar();

                    if (dec!='o' && dec != 'O')
                    {
                        rester = false;
                    }
                }
                finally
                {
                    Console.WriteLine("\n\tAu revoir :o( ...");
                }
            }
        }
        //------------------------------------------
        //
        //------------------------------------------
        static void AfficherParam(string[] tabP)
        {
            int i = 0;
            foreach (string p in tabP) 
            {
                i++;
                u.Sep($"{i}:{p}");
            }
            if (i == 0)
            {
                u.Sep("Aucun param");
            }

            if (tabP.Length == 1)
                //Util.debogue = false;
            u.Pause();


        }
        //------------------------------------------
        //
        //------------------------------------------
        static void AfficherMenu()
        {
            Console.WriteLine("1: Recensement");
            Console.WriteLine("2: Liste electorale");
            Console.WriteLine("3: Pret bourse");
            Console.WriteLine("4: Milieu de stage");
            Console.WriteLine("Z: BaZe de données");
            Console.WriteLine("0: Tableua à deux dim");
            Console.WriteLine("B: File et Pile en C#");
            Console.WriteLine("N: iNterface");
            Console.WriteLine("Y: ONU");
            Console.WriteLine("O: Const vs Readonly");
            Console.WriteLine("G: Héritage en C#");
            Console.WriteLine("X: Exception en C#");
            Console.WriteLine("E: Énumération (enum) en C#");
            Console.WriteLine("P: Puissance 4");
            Console.WriteLine("R: param ref et out");
            Console.WriteLine("C: Couleur et Écran");
            Console.WriteLine("T: TicTacToe");
            Console.WriteLine("F: outils Financiers ");
            Console.WriteLine("H: Humanité");
            Console.WriteLine("A: Exploration des tableaux (array) C#");
            Console.WriteLine("L: Exploration des listes C#");
            Console.WriteLine("I: Exploration des Fichiers");
            Console.WriteLine("Q: Quitter");

            Console.Write("\nVotre choix:");
        }

        //------------------------------------------
        //
        //------------------------------------------
        static void ExecuterChoix(ref bool rester)
        {
            char choix = u.SaisirChar();
            Exploration explo = new(); ;
            ExploFichiers exploF = new();
            ExploPoly exploPoly = new();

            switch (choix.ToString().ToLower())
            {
                case ("1"):
                    exploPoly.Recensement();
                    break;

                case ("z"):
                    explo.GenereBD();
                    break;

                case ("2"):
                    explo.Tab2D();
                    break;

                case ("b"):
                    explo.PileEtFile();
                    break;

                case ("n"):
                    explo.ExercInterface();
                    break;

                case ("y"):
                    Onu onu = new();
                    onu.Exec();
                    break;

                case ("o"):
                    explo.ReadOnlyVsConst();
                    break;

                case ("g"):
                    explo.ExecHeritage();
                    break;

                case ("x"):
                    explo.ExecException();
                    break;

                case ("e"):
                    explo.ExecEnum();
                    break;

                case ("p"):
                    Puissance4 p4 = new();
                    p4.Jouer();
                    break;
                case ("r"):
                    explo.ExploRefOut();
                    break;
                case ("c"):
                    ExploEcran exploEcran = new();
                    exploEcran.Exec();
                    break;
                case ("t"):
                    TicTacToe ttt = new();
                    ttt.Jouer();
                    break;
                case ("i"):
                    //exploF.ExecExploFichiers();
                    //exploF.EcrireFichier();
                    exploF.ExecExploFichiers();
                        //EcrireXHumains(100000);  
                    break;
                case ("l"):
                    explo.ExploListeH();
                    break;
                case ("a"):
                    explo.ExploTableauH();
                    break;
                case ("f"):
                    ExecFinancier();
                    break;
                case ( "h" ): ExecHumanite();
                      break;
                case( "q") :
                default:
                    rester = false;
                    break;
            }
        }


        //------------------------------------------
        //
        //------------------------------------------
        static void ExecHumanite()
        {
            u.Titre("Exploration des humains");
            Humain h = new Humain();
            h.Afficher();

            Humain h1 = new Humain("Adam", new DateTime(1964,7,23), "M");
            Humain h2 = new Humain("Êve");
            Humain h3 = new Humain("Louis", new DateTime(2004,9,6), "M");

            h1.Afficher();
            h2.Afficher();
            h3.Afficher();
            u.Pause();
        }
        //------------------------------------------
        //
        //------------------------------------------
        static void ExecFinancier()
        {
            Financier fin = new Financier();
            fin.Exec();
        }



    }
}
