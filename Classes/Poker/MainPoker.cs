using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    class MainPoker
    {
        public Carte[] lesCartes { get; set; }

        public MainPoker()
        {
            lesCartes = new Carte[JeuPoker.NB_CARTES_PAR_MAIN];
            for(int i=0; i<JeuPoker.NB_CARTES_PAR_MAIN; i++)
            {
                lesCartes[i] = new Carte();
            }
        }

        public void AjouterCarte(int indice, Carte c)
        {
            lesCartes[indice] = c;
        }

        public void Afficher(int numJoueur)
        {
            for (int i = 0; i < JeuPoker.NB_CARTES_PAR_MAIN; i++)
            {
                lesCartes[i].Afficher(i, numJoueur);
            }
        }

    }
}
