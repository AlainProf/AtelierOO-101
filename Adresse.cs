//----------------------------
//   Fichier:
//   Auteur:
//   Date : 

using System;

namespace AtelierOO_101
{
    /// <summary>
    /// Représente les informations d'adresse d'un lieu
    /// </summary>
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
        
        /// <summary>
        /// Ville du lieu
        /// </summary>
        public string Ville { get; set; }
        /// <summary>
        /// Province du lieu en question
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Adresse()
        {
            NumCivic = "0";
            Rue = "";
            Ville = "";
            Province = "";
        }
        /// <summary>
        /// Constructeur paramétré avec les toutes info
        /// </summary>
        /// <param name="nc">pour initialiser NumCivic</param>
        /// <param name="r">pour initialiser Rue</param>
        /// <param name="v">ville</param>
        /// <param name="p">province</param>
        public Adresse(string nc, string r, string v, string p)
        {
            NumCivic = nc;
            Rue = r;
            Ville = v;
            Province = p;
        }

        /// <summary>
        /// Affichage de tous les détails d'une adresse
        /// </summary>
        public void Afficher()
        {
            Console.WriteLine("{0} {1}\nville {2}, {3} ", NumCivic, Rue, Ville, Province);
        }

        /// <summary>
        /// Vérifie si l'adresse demandée est bien initialisé
        /// </summary>
        /// <returns>return true si c'est le cas et return false si l'adresse à été initialisée par des valeurs par défaut</returns>
        public bool Existe()
        {
            return NumCivic != "0";
        }

    }
}
