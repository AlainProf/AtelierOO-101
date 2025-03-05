//-----------------------------------------
//  Nom: Util.cs
//  Auteur : Alain Martel
//  Date : 2025-01-27
//  Description: 
//-----------------------------------------
using AtelierOO_101.Classes;
using AtelierOO_101.Donnees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.ClassesUtil
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

        //------------------------------------------
        //
        //------------------------------------------
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
        public void Sep(string msg = "")
        {
            if (debogue)
                Console.WriteLine($"----------{msg}----------");
        }

        //------------------------------------------
        //
        //------------------------------------------
        public static Humain GenereHumainAleatoire()
        {
            Util u = new Util();

            int iPrenom = u.rdm.Next(0, 200);
            string sexe = "M";
            if (iPrenom < 102)
            {
                sexe = "F";
            }

            int iFam = u.rdm.Next(0, 200);
            string nom = DonnesDeBase.tabPrenoms[iPrenom] + " " + DonnesDeBase.tabFamilles[iFam];

            DateTime naissance = new DateTime(u.rdm.Next(1926, 2024), u.rdm.Next(1, 13), u.rdm.Next(1, 29));

            int iRue = u.rdm.Next(0, 500);
            int iVille = u.rdm.Next(0, 50);

            Adresse dom = new Adresse(u.rdm.Next(17, 14199).ToString(),
                                      DonnesDeBase.tabRues[iRue],
                                      DonnesDeBase.tabVilles[iVille]);

            int tirage = u.rdm.Next(0, 1000);
            if (tirage > 500)
            {
                DateTime limMin = new DateTime(2008, 02, 24);
                DateTime limMax = new DateTime(1975, 02, 24);

                if (naissance.Ticks > limMin.Ticks && naissance.Ticks < limMax.Ticks)
                {
                    return new Humain(nom, naissance, sexe, dom);
                }

                int iProg = u.rdm.Next(0, 115);

                tirage = u.rdm.Next(0, 10);
                if (tirage == 5)
                {
                    int iEntrep = u.rdm.Next(0, 50);
                    return new Stagiaire(nom, naissance, sexe, dom,
                                         DonnesDeBase.tabProg[iProg], u.rdm.Next(10, 100),
                                         DonnesDeBase.tabEntreprises[iEntrep], u.rdm.Next(0, 16000));

                }

                return new Etudiant(nom, naissance, sexe, dom, DonnesDeBase.tabProg[iProg], u.rdm.Next(10, 100));
            }
            return new Humain(nom, naissance, sexe, dom);

        }
    }
}
