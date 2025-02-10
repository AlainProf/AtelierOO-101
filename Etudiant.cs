using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Etudiant : Humain
    {
        public string Matricule { get; set; }
        public string Programme { get; set; }
        public double Moyenne { get; set; }

        public Etudiant()
        {
            Matricule = "1234567";
            Programme = "Techniques de l'informatique";
            Moyenne = 0.99;
        }

        public void Afficher()
        {
            Console.WriteLine($"Nom: {Nom}, {Age()} ans, mat:{Matricule}, inscrit en {Programme}");
        }
    }
}
