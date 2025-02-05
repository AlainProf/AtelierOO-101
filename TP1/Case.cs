using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.TP1
{
    internal class Case
    {
        public string Contenu {  get; set; }
        int _colonne;
        int _rangee;

        public Case(int col, int ran)
        {
            _colonne = col;
            _rangee = ran;
            Contenu = "_";
        }

        public void Afficher()
        {
            Console.SetCursorPosition((_colonne)*4 + Puissance4.DECALAGE_X, _rangee + Puissance4.DECALAGE_Y+2);
            Console.Write("|_");
            Console.Write(Contenu);
            Console.Write("_|");

        }
    }
}
