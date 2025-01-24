namespace AtelierOO_101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Util.Titre("Atelier de dev de proj OO pour le groupe 2C6-101!");
            AfficherMenu();
            ExecuterChoix();
        }


        static void ExecuterChoix()
        {
            char choix = Util.SaisirChar();

            switch(choix.ToString().ToLower())
            {
                case("f") : ExecFinancier();
                      break;
                case( "h" ): ExecHumanite();
                      break;
                case( "q") :
                     Console.WriteLine("Développer le exit()");
                     break;
                default:
                   Console.WriteLine("Option inexistante");
            break;
            }
        }


        static void ExecHumanite()
        {
            Util.Titre("Exploration des humains");
            Humain h = new Humain();
            h.Afficher();

            Humain h1 = new Humain("Adam", "-6000", "M");
            Humain h2 = new Humain("Êve", "-5999", "F");

            h1.Afficher();
            h2.Afficher();
        }
        static void ExecFinancier()
        {
            Financier fin = new Financier();
            fin.Exec();
        }

        static void AfficherMenu()
        {
            Console.WriteLine("F: outils Financiers ");
            Console.WriteLine("H: Humanité");
            Console.WriteLine("Q: Quitter");
        }
    }
}
