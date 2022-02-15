using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.ClassesExplo
{
    class ExploManipFichier
    {
        static public int ExplorationLectureEtEcritureDsFichier()
        {
            Console.Clear();
            Console.WriteLine("Lecture et écriture dans des ficheirs avec C#");

            string FicIn = "d:\\amartel\\classe101.txt";
            string FicOut = "d:\\amartel\\classe101TrieParAge.txt";

            if (File.Exists(FicIn))
            {
                StreamReader reader = File.OpenText(FicIn);
                string ligneCourante;
                int i = 0;
                List<Humain> classe101 = new();
                while (reader.Peek() > -1)
                {
                    i++;
                    ligneCourante = reader.ReadLine();
                    Humain h = ParsingHumain(ligneCourante);
                    classe101.Add(h);
                }

                classe101.Sort(ExploSD.TriParVieux);
                StreamWriter writer = new(FicOut);
                foreach (Humain hu in classe101)
                {
                    writer.WriteLine(hu.GetNom() + ";" + hu.GetNaissance().ToString("yyyy-MM-dd"));
                }
                writer.Close();
                Console.WriteLine("Fichier créé et rempli en ordre de vieillesse");
            }
            else
            {
                Console.WriteLine("ERREUR fichier {0} n'existe pas", FicIn);
            }


            return 0;
        }

        static Humain ParsingHumain(string infoBrute)
        {
            string[] tabInfo = infoBrute.Split(';');
            DateTime naissance = ParseDate(tabInfo[1]);

            return new Humain(naissance, tabInfo[0]);
        }

        static DateTime ParseDate(string dateBrute)
        {
            string[] tabInfoDate = dateBrute.Split('-');

            return new DateTime(Convert.ToInt32(tabInfoDate[0]),
                                Convert.ToInt32(tabInfoDate[1]),
                                Convert.ToInt32(tabInfoDate[2]));
        }
    }
}
