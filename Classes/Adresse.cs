//-----------------------------------------
//  Nom: 
//  Auteur : Alain Martel
//  Date : 2025-0
//  Description: 
//-----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    internal class Adresse
    {
        public string NumCivique { get; set; }
        public string Rue { get; set; }
        public string Ville { get; set; }

        //------------------------------------------
        //
        //------------------------------------------

        public Adresse()
        {
            NumCivique = "0";
            Rue = "Sans nom";
            Ville = "Fantôme";
        }
        //------------------------------------------
        //
        //------------------------------------------
        public Adresse(string nc, string r, string v)
        {
            NumCivique = nc;
            Rue = r;
            Ville = v;
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void Afficher()
        {
            Console.Write($"{NumCivique} {Rue}, {Ville}");
        }
    }
}
