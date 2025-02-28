using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class ExploPoly
    {
        Util _u = new();
        public void Recensement()
        { 
            ChargementPopulation();
        }

        void ChargementPopulation()
        {
            string FICHIER_POPULATION = @"d:\alino\atelier\pop.txt";
            _u.Titre("Exploration des fichiers en C#");

            if (File.Exists(FICHIER_POPULATION))
            {
                StreamReader reader = new StreamReader(FICHIER_POPULATION);
                string ligneCourante;
                Parseur psr = new Parseur();

                List<Humain> listPop = new List<Humain>();
                int iter = 0;
                while (reader.Peek() > -1)
                {
                    iter++;
                    ligneCourante = reader.ReadLine();


                    if (psr.ParsingHumain(ligneCourante, out Humain h, out string msgErr))
                    {
                        listPop.Add(h);
                    }
                    else
                    {
                        Console.WriteLine($"Erreur à la ligne {iter}: {msgErr} ");
                    }

                    // Console.WriteLine($"{iter}: {ligneCourante}");
                }
                Console.WriteLine($"Chargement de {listPop.Count} humains");
            }
            else
            {
                Console.WriteLine($"Erreur: le fichier {FICHIER_POPULATION} n'existe pas");
            }
            _u.Pause();
        }
    }
}
