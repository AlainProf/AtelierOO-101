﻿//-----------------------------------------
//  Nom: Util.cs
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
    enum JourSemaine
    {
        Lundi,
        Mardi,
        Mecredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche
    }
    internal class Util
    {
        public static readonly bool debogue = true;


        public Random rdm = new();

        public readonly string[] tabNoms = new string[10] { "Gabriel", "Guilaume", "Raphaël", "Louis", "Elias", "Félix", "Adam", "Olivier", "Donavan", "Derek" };
        public readonly string[] tabRues = new string[10] { "de l'Hotel", "du Parc", "Fournier", "Du palias", "2ième avenue", "boul labelle", "aut 15 nord", "sans issuee", "Donavan", "Boul arthur-sauvé" };
        public readonly string[] tabVilles = new string[10] { "Singe et rhum", "montréal", "laval", "Québec", "Trois rivière", "Gatineua", "Ottawa", "Longueuil", "Sherbrooke", "Teerebonne" };

        bool _debogue; 

        public Util(bool debogue = true)
        {
            _debogue = debogue; 
        }


        //------------------------------------------
        //
        //------------------------------------------
        public void Titre(string leTitre)
        {

            ViderEcran();
            for (int i = 0; i < leTitre.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

            Console.WriteLine(leTitre);

            for (int i = 0; i < leTitre.Length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("\n\n");
        }

        //------------------------------------------
        //
        //------------------------------------------
        public char SaisirChar()
        {
            ConsoleKeyInfo cle;
            cle = Console.ReadKey(true);
            return cle.KeyChar;
        }

        //------------------------------------------
        //
        //------------------------------------------
        public int SaisirEntier()
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int res))
            {
                return res;
            }
            else
                return 0;
        }
        //------------------------------------------
        //
        //------------------------------------------
        public double SaisirReel()
        {
            string? input = Console.ReadLine();
            if (double.TryParse(input, out double res))
            {
                return res;
            }
            else
                return 0.0;
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void ViderEcran()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void Pause()
        {
            if (debogue)
                Console.WriteLine("\n\tAppuyez sur une touche...");
            Console.ReadKey(true);
        }
        //------------------------------------------
        //
        //------------------------------------------
        public void Sep(string msg="")
        {
            if (debogue)
               Console.WriteLine($"----------{msg}----------");
        }
    }
}
