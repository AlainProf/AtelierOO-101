using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    class JeuPoker
    {
        private static int _couleurTapis = 2; // 2 == vert
        private static int _couleurTexte = 15; // 15 == blanc

        public const int NB_CARTES_PAR_MAIN = 6;
        public static int NB_JOUEURS;

        private Paquet lePaquet = new Paquet();

        private MainPoker[] MainsDesJoueurs;

        public JeuPoker(int nbJ)
        {
            NB_JOUEURS = nbJ;

            MainsDesJoueurs = new MainPoker[NB_JOUEURS];
            for (int i = 0; i < NB_JOUEURS; i++)
            {
                MainsDesJoueurs[i] = new MainPoker();
            }
        }

        public int Jouer()
        {
            CouleurTapis();
            Console.Clear();
            lePaquet.Brasser();

            for (int i = 0; i < NB_CARTES_PAR_MAIN * NB_JOUEURS;  i++)
            {
                Carte c = lePaquet.Distribuer();
                int indice = i / NB_JOUEURS;
                MainsDesJoueurs[i % NB_JOUEURS].AjouterCarte(indice, c);
            }

            for (int i = 0; i < NB_JOUEURS; i++)
            {
                MainsDesJoueurs[i].Afficher(i);
            }
            return 0;
        }

        public static void CouleurTapis()
        {
            Console.BackgroundColor = (ConsoleColor)_couleurTapis;
            Console.ForegroundColor = (ConsoleColor)_couleurTexte;
        }

        public int AfficherLePaquet()
        {
             //lePaquet.Brasser();
             lePaquet.Afficher();
             Console.ReadLine();
            return 0;
        }
    }
}
