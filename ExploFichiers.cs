using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class ExploFichiers
    {
        Util u = new Util();
        public void ExecExploFichiers()
        {
            string FICHIER_POPULATION = @"d:\alino\atelier\pop.txt";
            u.Titre("Exploration des fichiers en C#");

            if (File.Exists(FICHIER_POPULATION))
            {
                StreamReader reader = new StreamReader(FICHIER_POPULATION);
                string ligneCourante;
                int iter = 0;
                while(reader.Peek() > -1)
                {
                    iter++;
                    ligneCourante = reader.ReadLine();

                    if (ParsingHumain(ligneCourante, out Humain h ))
                    {
                        h.Afficher();
                    }
                    else
                    {
                        Console.WriteLine($"Erreur à la ligne {iter}");
                    }

                   // Console.WriteLine($"{iter}: {ligneCourante}");
                }
            }
            else
            {
                Console.WriteLine($"Erreur: le fichier {FICHIER_POPULATION} n'existe pas");
            }
            u.Pause();
        }

        private bool ParsingHumain(string infoBrute, out Humain h)
        {
            h = new Humain();

            int nbChamps = CompterChamps(infoBrute);
            if (nbChamps == 8)
            {
                string[] tabInfo = infoBrute.Split(';');
                h = new Humain(tabInfo[0],
                               new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                               tabInfo[4],
                               new Adresse(tabInfo[5], tabInfo[6], tabInfo[7]));
                return true;
            }
            return false;
        }

        private int CompterChamps(string info)
        {
            if (info.Length == 0)
                return 0;

            int nbChamps = 1;
            foreach (char ch in info)
            {
                if (ch == ';')
                    nbChamps++;
            }
            return nbChamps;
        }

    }
}
