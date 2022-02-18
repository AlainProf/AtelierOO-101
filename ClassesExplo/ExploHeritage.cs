using AtelierOO_101.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.ClassesExplo
{
    class ExploHeritage
    {
        public static int Introduction()
        {
            Console.Clear();
            Console.WriteLine("Intro au concept d'héritage en C#\n_______________________________________________\n");

            Citoyen mX = new();

            mX.Afficher();

            Humain mmeY = new();
            mmeY.Afficher();

            Citoyen citX = new("Ludovic Fournier", new DateTime(2004, 7, 27), "256111111", "Femme");
            citX.Afficher();


            Citoyen citSco = new Citoyen("Jonathan", new DateTime(1989, 1, 1), "294111111", "M");

            Diplome d1 = new();
            d1.Nom = "Dip réguliers ";
            d1.Niveau = "Primaires";
            d1.Obtention = new DateTime(2000, 6, 23);

            citSco.Scolarite.Add(d1);

            d1 = new();
            d1.Nom = "Service de restauration";
            d1.Niveau = "Etudes professionnelles";
            d1.Obtention = new DateTime(2011, 6, 23);

            citSco.Scolarite.Add(d1);

            d1 = new();
            d1.Nom = "Sommelerie";
            d1.Niveau = "ASP";
            d1.Obtention = new DateTime(2012, 6, 23);

            citSco.Scolarite.Add(d1);

            citSco.Afficher();

            return 0;
        }
    }
}
