using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.TP1
{
    internal class Colonne
    {
        Case[] _cases = new Case[6];
        int _numero;

        public Colonne(int num)
        {
            _numero = num;
            for (int i = 0; i < 6; i++)
            {
                _cases[i] = new Case(_numero, i);
            }
        }

        public void Afficher()
        {
            foreach (Case uneCase in _cases)
            {
                uneCase.Afficher();
            }
        }

        public void InsererJeton(string symbole)
        {
            _cases[0].Contenu = symbole;
        }
    }
}
