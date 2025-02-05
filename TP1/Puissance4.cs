using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.TP1
{
    internal class Puissance4
    {
        Util u = new();

        public static readonly int DECALAGE_X = 5;
        public static readonly int DECALAGE_Y = 10;

        bool _partieContinu = true;
        public void Jouer()
        {
            Grille _grille = new Grille();
            _grille.Afficher();
            while (_partieContinu)
            {

                Console.Write("\n\nVotre coup:");
                char coup = u.SaisirChar();
                int col = ConvertCoupEnCol(coup);
                _grille.InsererJeton(col, "x");
                _grille.Afficher();

                u.Pause();
            }
        }
        private int ConvertCoupEnCol(char coup)
        {
            switch(coup)
            {
                case 'a': return 0;
                case 'b': return 1;
                case 'c': return 2;
                case 'd': return 3;
                case 'e': return 4;
                case 'f': return 5;
                case 'g': return 6;
                default: return 0;
            }
        }
    }


}
