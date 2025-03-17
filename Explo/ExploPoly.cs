//-----------------------------------------
//  Nom: ExploPoly.cs
//  Auteur : Alain Martel
//  Date : 2025-03-05
//  Description: 
//-----------------------------------------
using AtelierOO_101.Classes;
using AtelierOO_101.ClassesUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Explo
{
    internal class ExploPoly
    {
        Util _u = new();
        List<Humain> listPop = new List<Humain>();

        //------------------------------------------
        //
        //------------------------------------------
        public void Recensement()
        {
            _u.Titre("Recensement");
            ChargementPopulation();
            int nbHommes = 0;
            int nbFemmes = 0;
            int nbEnfants = 0;
            int nbVieux = 0;

            foreach(Humain h in listPop)
            {
                if (h.Age() > 65)
                    nbVieux++;
                if (h.Age() <= 16)
                    nbEnfants++;
                if (h.Sexe == "M")
                    nbHommes++;
                if (h.Sexe == "F")
                    nbFemmes++;
            }

            Console.WriteLine($"sur {listPop.Count} humains nous avons \n{nbVieux} seniors {nbEnfants} enfants\n{nbFemmes} femmes, {nbHommes} hommes");
            _u.Pause();
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void ListeElecteurs()
        {
            _u.Titre("Liste électorale");
            ChargementPopulation();
            int nbElecteurs = 0;

            foreach (Humain h in listPop)
            {
                if (h.Age() > 18)
                    nbElecteurs++;
            }

            Console.WriteLine($"sur {listPop.Count} humains nous avons \n{nbElecteurs} électeur");
            _u.Pause();
        }
        //------------------------------------------
        //
        //------------------------------------------
        public void PretEtBourse()
        {
            _u.Titre("Prêts et bourses");
            ChargementPopulation();
            int nbEtudiants = 0;

            foreach (Humain h in listPop)
            {
                if (h is Etudiant)
                    nbEtudiants++;
            }

            Console.WriteLine($"sur {listPop.Count} humains nous avons \n{nbEtudiants } étudiants à nourir");
            _u.Pause();
        }

       
        //------------------------------------------
        //
        //------------------------------------------
        public void MilieuStage()
        {
            _u.Titre("Salaire moyen des stagiaires");
            ChargementPopulation();
            int nbStagiaires = 0;
            double salTotal = 0;

            foreach (Humain h in listPop)
            {
                if (h is Stagiaire)
                {
                    Stagiaire s = h as Stagiaire;
                    nbStagiaires++;
                    salTotal += s.Salaire; 
                }
            }

            Console.WriteLine($"{nbStagiaires} stagiaires ont un salaire moyen de {(salTotal/nbStagiaires).ToString("N2")}$ par an");
            _u.Pause();
        }
        //------------------------------------------
        //
        //------------------------------------------
        void ChargementPopulation()
        {
            if (listPop.Count > 0) return;

            string FICHIER_POPULATION = @"d:\alino\atelier\pop.txt";
            //_u.Titre("Exploration des fichiers en C#");

            if (File.Exists(FICHIER_POPULATION))
            {
                StreamReader reader = new StreamReader(FICHIER_POPULATION);
                string? ligneCourante;
                Parseur psr = new Parseur();
                
                int iter = 0;
                while (reader.Peek() > -1)
                {
                    iter++;
                    ligneCourante = reader.ReadLine();

                    if (iter % 100000 == 0)
                        Console.WriteLine(iter / 10000 + "%");

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
            //_u.Pause();
        }
    }
}
