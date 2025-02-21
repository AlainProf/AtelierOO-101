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

namespace AtelierOO_101
{
    internal class ExploFichiers 
    {
        Util _u = new Util();
        List<Humain> gr101 = new List<Humain>();
        Parseur psr = new Parseur();
        //------------------------------------------
        //
        //------------------------------------------
        public void ExecExploFichiers()
        {
            string FICHIER_POPULATION = @"d:\alino\atelier\pop.txt";
            _u.Titre("Exploration des fichiers en C#");

            if (File.Exists(FICHIER_POPULATION))
            {
                StreamReader reader = new StreamReader(FICHIER_POPULATION);
                string ligneCourante;
                int iter = 0;
                while (reader.Peek() > -1)
                {
                    iter++;
                    ligneCourante = reader.ReadLine();

                    if (psr.ParsingHumain(ligneCourante, out Humain h, out string msgErr))
                    {
                        gr101.Add(h);
                        // h.Afficher();
                    }
                    else
                    {
                        Console.WriteLine($"Erreur à la ligne {iter}: {msgErr} ");
                    }

                    // Console.WriteLine($"{iter}: {ligneCourante}");
                }
                Console.WriteLine($"Chargement de {gr101.Count} humains");
                gr101.Sort(Humain.ComparerAge);

                //EcrireFichier();
            }
            else
            {
                Console.WriteLine($"Erreur: le fichier {FICHIER_POPULATION} n'existe pas");
            }
            _u.Pause();
        }

        //------------------------------------------
        //
        //------------------------------------------
        public  void EcrireFichier()
        {
            Console.WriteLine("Écriture du fichier trié");


            StreamWriter sw = new StreamWriter(@"d:\alino\atelier\pop.txt");
            sw.WriteLine("Groupe 101 trié par Age");

            gr101.Sort(Humain.ComparerNom);

//            foreach (Humain h in gr101)
            for(int i=0; i<1000; i++)
            {
                Humain h = new Humain(_u.tabNoms[_u.rdm.Next(0, 10)], new DateTime(_u.rdm.Next(1964, 2007), _u.rdm.Next(1, 13), _u.rdm.Next(1, 29)), "F");
//                sw.WriteLine($"{h.Nom};{h.Naissance.Year};{h.Naissance.Month};{h.Naissance.Day};{h.Sexe};{h.Domicile.NumCivique};{h.Domicile.Rue};{h.Domicile.Ville}");
              //  sw.WriteLine($"{h.Nom};{h.Naissance.Year};{h.Naissance.Month};{h.Naissance.Day};{h.Sexe}");
            }
            sw.Close();
            _u.Sep("ecriture de 1000 humains");

                _u.Pause();

        }

        public void EcrireXHumains(int nbHumaGeneres= 1000)
        {
            //List<Humain> grpAlea = new List<Humain>();
            for (int i = 0; i < nbHumaGeneres; i++)
            {
                Humain h = Humain.HumainAleatoire();    
                gr101.Add(h);  
            }

            EcrireFichier();


        }
    }


}
