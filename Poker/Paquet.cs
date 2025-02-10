using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Poker
{
    internal class Paquet
    {
        public Carte[] lesCartes = new Carte[52];
        public List<Carte> lstCartes = new List<Carte>();
        Util u = new();

        public Paquet(bool melanger=false)
        {
            int iter = 0;
            if (!melanger)
            {
                for (int s = 0; s < 4; s++)
                {
                    for (int v = 0; v < 13; v++)
                    {
                        lesCartes[iter] = new Carte(s, v);
                        iter++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 52;i++)
                {
                   int s = u.rdm.Next(0, 4);
                   int v = u.rdm.Next(0, 13);
                   lesCartes[i] = new Carte(s, v);
                }
            }
        }

        public void Afficher()
        {
            for(int i=0; i<52; i++)
            {
                lesCartes[i].Afficher();
            }
        }

        public void Trier()
        {
            Array.Sort(lesCartes, Carte.ComparerValeur);
        }
    }
}
