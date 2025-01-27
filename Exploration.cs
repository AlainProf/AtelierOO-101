//-----------------------------------------
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
        Util u = new Util();
        //------------------------------------------
        //
        //------------------------------------------

        public void ExploTableau()
        {
            u.Titre("Exploration des tableau C#");

            int[] tabEntiers = new int[10];

            for (int i = 0; i < tabEntiers.Length; i++)
            {
                tabEntiers[i]   = i * 2;    
            }

            for (int i = 0; i < tabEntiers.Length; i++)
            {
                Console.WriteLine($"{i}: {tabEntiers[i]}");
            }






            u.Pause();
        }
    }
}
