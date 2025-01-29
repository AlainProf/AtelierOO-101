//-----------------------------------------
//  Nom: Program.cs
//  Auteur : Alain Martel
//  Date : 2025-01-27
//  Description: 
//-----------------------------------------

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
            bool rester = true;
            while (rester)
            {
                u.Titre("Atelier du cours POO- gr 1");
                AfficherMenu();
                ExecuterChoix(ref rester);
            }
            Console.WriteLine("\n\tAu revoir :o( ...");
        }
        //------------------------------------------
        //
        //------------------------------------------
        static void AfficherMenu()
        {
            Console.WriteLine("F: outils Financiers ");
            Console.WriteLine("H: Humanité");
            Console.WriteLine("T: Exploration des tableaux C#");
            Console.WriteLine("L: Exploration des listes C#");
            Console.WriteLine("Q: Quitter");

            Console.Write("\nVotre choix:");
        }


        //------------------------------------------
        //
        //------------------------------------------
        static void ExecuterChoix(ref bool rester)
        {
            char choix = u.SaisirChar();
            Exploration explo = new();

            switch (choix.ToString().ToLower())
            {
                case ("l"):
                    explo.ExploListe();
                    break;
                case ("t"):
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
