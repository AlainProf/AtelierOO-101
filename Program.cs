//-----------------------------------------
//  Nom: Program.cs
//  Auteur : Alain Martel
//  Date : 2025-01-27
//  Description: 
//-----------------------------------------

using AtelierOO_101.Applications;
using AtelierOO_101.Classes;
using AtelierOO_101.ClassesUtil;
using AtelierOO_101.Explo;
using AtelierOO_101.ONU;
using AtelierOO_101.TP1;

namespace AtelierOO_101
{
    internal class Program
    {
        static Util u = new Util();
        static ExploPoly exploPoly = new();

        //------------------------------------------
        //
        //------------------------------------------
        static void Main(string[] args)
        {
            //AfficherParam(args);
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
            Console.WriteLine("A: Array (Exploration des tableaux)");
            Console.WriteLine("B: Base de données");
            Console.WriteLine("C: Couleur et Écran");
            Console.WriteLine("D: tableaux à Deux dimensions");
            Console.WriteLine("E: Énumération (enum) en C#");
            Console.WriteLine("F: Financier ");
            Console.WriteLine("G: héritaGe");
            Console.WriteLine("H: Humanité");
            Console.WriteLine("I: Interface");
            Console.WriteLine("J: Milieu de staJe (*)");
            Console.WriteLine("K: file et pile");

            Console.WriteLine("L: Listes");
            Console.WriteLine("M: recenseMent (*)");
            Console.WriteLine("N: puissaNce 4");
            Console.WriteLine("O: ONU");
            Console.WriteLine("P: Pret bourse (*)");
            Console.WriteLine("R: Ref et out");
            Console.WriteLine("S: liSte electorale (*)");
            Console.WriteLine("T: TicTacToe");
            Console.WriteLine("U: Const vs Readonly");
            Console.WriteLine("V: Exploration des Fichiers");
            Console.WriteLine("X: eXception en C#");


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

            switch (choix.ToString().ToLower())
            {
                case ("a"):
                    explo.ExploTableauH();
                    break;
                case ("b"):
                    explo.GenereBD();
                    break;
                case ("c"):
                    ExploEcran exploEcran = new();
                    exploEcran.Exec();
                    break;
                case ("d"):
                    explo.Tab2D();
                    break;
                case ("e"):
                    explo.ExecEnum();
                    break;
                case ("f"):
                    ExecFinancier();
                    break;
                case ("g"):
                    explo.ExecHeritage();
                    break;
                case ("h"):
                    ExecHumanite();
                    break;
                case ("i"):
                    explo.ExercInterface();
                    break;
                case ("j"):
                    exploPoly.MilieuStage();
                    break;
                case ("k"):
                    explo.PileEtFile();
                    break;
                case ("l"):
                    explo.ExploListeH();
                    break;
                case ("m"):
                    exploPoly.Recensement();
                    break;
                case ("n"):
                    Puissance4 p4 = new();
                    p4.Jouer();
                    break;
                case ("o"):
                    Onu onu = new();
                    onu.Exec();
                    break;
                case ("p"):
                    exploPoly.PretEtBourse();
                    break;
                case ("r"):
                    explo.ExploRefOut();
                    break;
                case ("s"):
                    exploPoly.ListeElecteurs();
                    break;
                case ("t"):
                    TicTacToe ttt = new();
                    ttt.Jouer();
                    break;
                case ("u"):
                    explo.ReadOnlyVsConst();
                    break;

                case ("x"):
                    explo.ExecException();
                    break;
                case ("v"):
                    //exploF.ExecExploFichiers();
                    //exploF.EcrireFichier();
                    exploF.ExecExploFichiers();
                        //EcrireXHumains(100000);  
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
