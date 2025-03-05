using AtelierOO_101.ClassesUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Poker
{
    enum ValeurCarte
    {
        deux,
        trois,
        quatre,
        cinq,
        six,
        sept,
        huit,
        neuf,
        dix,
        valet,
        dame,
        roi,
        las
    }

    enum SorteCarte
    {
        pique,
        trefle,
        carreau,
        coeur
    }


    internal class Carte
    {
        public ValeurCarte Valeur {get;set;}
        public SorteCarte Sorte {get ; set;}

        Util u = new();

        public Carte()
        {
            Valeur = (ValeurCarte)0;
            Sorte = (SorteCarte)0;
        }
        public Carte(int s, int v)
        {
            Valeur = (ValeurCarte)v;
            Sorte = (SorteCarte)s;
        }

        public void Afficher()
        {
            if (Valeur == ValeurCarte.las)
            {
                u.Sep($" as de {Sorte} ");
            }
            else
            {
                u.Sep($" {Valeur} de {Sorte} ");
            }
        }

        public static int ComparerValeur(Carte ca, Carte cb)
        {
            if (ca.Valeur > cb.Valeur)
                return 1;
            if (ca.Valeur < cb.Valeur)
                return -1;
            return 0;

        }

    }
}
