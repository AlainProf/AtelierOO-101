﻿//-----------------------------------------
//  Nom: Exploration.cs
//  Auteur : Alain Martel
//  Date : 2025-01-27
//  Description: 
//-----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Exploration
    {
        Util u = new ();
        const int taille = 1000000;
        int[] tabEntiers = new int[taille];
        Humain[] tabGr101 = new Humain[taille];
        Random r = new ();

        //string[] tabNoms = new string[taille] {"Gabriel", "Guilaume", "Raphaël", "Louis", "Elias", "Félix", "Adam", "Olivier", "Donavan", "Derek" };

        List<int> listeEntiers = new();

        //------------------------------------------
        //
        //------------------------------------------
        public void ExploListe()
        {
            u.Titre("Liste en C#");

            for (int i = 0; i < taille; i++)
            {
                listeEntiers.Add(r.Next(1,1001));
            }
            u.Sep("Liste d'entiers");
           // AfficherListe();
            u.Pause();
            listeEntiers.Sort();
            u.Sep("Liste triée");
            //AfficherListe();
            u.Pause();
            double moy = listeEntiers.Average();
            u.Sep($"moyenne:{moy}");
            u.Pause();
        }

        //------------------------------------------
        //
        //------------------------------------------
        private void AfficherListe()
        {
            for (int i = 0; i < listeEntiers.Count; i++)
            {
                Console.WriteLine($"{i}: {listeEntiers[i]}");
            }
        }


        //------------------------------------------
        //
        //------------------------------------------
        public void ExploTableauH()
        {
           /* u.Titre("Tableau d'Humain");

            for (int i = 0; i < tabGr101.Length; i++)
            {
                tabGr101[i] = new Humain(tabNoms[r.Next(0,10)], new DateTime(r.Next(1964, 2008), r.Next(1,13), r.Next(1,29)), "M");
            }
            u.Sep("Tableau d'humain");
            AfficherTabH();
            u.Pause();

            Array.Sort(tabGr101, Humain.ComparerNom);
            u.Sep("Tableau trié");
            AfficherTabH();
            u.Pause();

            Array.Sort(tabGr101, Humain.ComparerAge);
            u.Sep("Tableau trié selon l'àge");
            AfficherTabH();
            u.Pause();*/
        }

        //------------------------------------------
        //
        //------------------------------------------
        private void AfficherTabH()
        {
            for (int i = 0; i < tabGr101.Length; i++)
            {
                tabGr101[i].Afficher();
            }
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void ExploTableau()
        {
            u.Titre("Exploration des tableau C#");

            for (int i = 0; i < tabEntiers.Length; i++)
            {
                tabEntiers[i] = r.Next(1, 1001);
            }
            u.Sep("Tableau d'entiers aléatoires");
            //AfficherTab();
            u.Pause();
            Array.Sort(tabEntiers);
            u.Sep("Tableau trié");
            AfficherTab();
            u.Pause();


        }

        private void AfficherTab()
        {
            for (int i = 0; i < tabEntiers.Length; i++)
            {
                Console.WriteLine($"{i}: {tabEntiers[i]}");
            }
        }
    }
}
