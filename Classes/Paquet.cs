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
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.SetCursorPosition(10, 10);
            for (int i = 0; i < 52; i++)
            {
                lesCartes[i].Afficher();
            }
            return 0;
        }
    }
}
