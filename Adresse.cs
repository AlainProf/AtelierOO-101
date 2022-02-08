//----------------------------
//   Fichier:
//   Auteur:
//   Date : 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    class Adresse
    {
        /// <summary>
        /// Représente le numéro de porte d'un batiment
        /// </summary>
        public string NumCivic { get; set; }

        /// <summary>
        /// Rue où est situé un batiment 
        /// </summary>
        public string Rue { get; set; }
        
        public string Ville { get; set; }
        public string Province { get; set; }

        public Adresse()
        {
            NumCivic = "0";
            Rue = "";
            Ville = "";
            Province = "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nc">pour initialiser NumCivic</param>
        /// <param name="r">pour initialiser Rue</param>
        /// <param name="v"></param>
        /// <param name="p"></param>
        public Adresse(string nc, string r, string v, string p)
        {
            NumCivic = nc;
            Rue = r;
            Ville = v;
            Province = p;
        }

        public void Afficher()
        {
            Console.WriteLine("{0} {1}\nville {2}, {3} ", NumCivic, Rue, Ville, Province);
        }

        public bool Existe()
        {
            return NumCivic != "0";
        }

    }
}
