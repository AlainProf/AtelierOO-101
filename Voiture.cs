using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Voiture
    {
        public string Constructeur { get; }
        public string Modele { get; }
        public string Couleur { get; }


        public Voiture(string c, string m ,string co)
        {
            Constructeur = c;
            Modele = m; 
            Couleur = co;   
        }

        public void Afficher()
        {
            Console.WriteLine($"{Constructeur}, {Modele} de couleur {Couleur}");
        }
    }
}
