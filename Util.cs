//-----------------------------------------
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
    internal class Util
    {
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
            cle = Console.ReadKey();
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
            Console.WriteLine("\n\tAppuyez sur une touche...");
            Console.ReadKey(true);
        }
    }
}
