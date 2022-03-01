using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    class Paquet
    {
        public Carte[] lesCartes = new Carte[52];
        private int _curseur = 0;

        public Paquet()
        {
            int iter = 0;
            for (int i = 0; i < 4;  i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    lesCartes[iter] = new Carte(i, j);
                    iter++;
                }
            }
        }

        public int Afficher()
        {
            JeuPoker.CouleurTapis();
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            for (int i = 0; i < 52; i++)
            {
                lesCartes[i].Afficher(i % 13, i/13);
            }
            return 0;
        }

        public void Brasser()
        {
            Random alea = new();

            for (int i = 52-1; i > 1; i--)
            {
                // tirage au soirt d'un index valant entre 0 et i
                int randomIndex = alea.Next(i);

                //permutation entre la carte [randomIndex] et la carte[i];
                Carte temp = lesCartes[i];
                lesCartes[i] = lesCartes[randomIndex];
                lesCartes[randomIndex] = temp;
            }
        }
        public Carte Distribuer()
        {
            return lesCartes[_curseur++];
        }
       
    }
}
