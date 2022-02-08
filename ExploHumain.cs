using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    class ExploHumain
    {
        /// <summary>
        /// Exploration des classes Humain et Adresse
        /// </summary>
        public static void ExplorationHumain()
        {
            Console.Clear();
            /* Humain h1 = new Humain();
             h1.Afficher();

             DateTime d = new DateTime(1989, 9, 13);
             Humain h2 = new Humain(d, "Joe");
             h2.Afficher();*/

            Adresse adr = new Adresse("207", "Rose LaTulippe", "Ste-Adèle", "Honte à Rio");

            adr.Rue = "Gille laTulipe";
            adr.Ville = "Singe et Rhum";
            Humain h3 = new Humain(new System.DateTime(2004, 7, 27), "Ludovick", adr);
            h3.Afficher();

            /*Humain h4 = new Humain(new DateTime(1802, 2, 26), "Victor Hugo", new DateTime(1885,5,22));
            h4.Afficher();*/
        }
    }
}
