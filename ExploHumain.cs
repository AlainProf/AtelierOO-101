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
        /// Classe utilitaire visant l'exploration des classes Humain et Adresse
        /// </summary>
        public static void ExplorationHumain()
        {
            Console.Clear();
            Adresse adr = new Adresse("207", "Rose LaTulippe", "Ste-Adèle", "Honte à Rio");

            adr.Rue = "Gille laTulipe";
            adr.Ville = "Singe et Rhum";
            Humain h3 = new Humain(new System.DateTime(2004, 7, 27), "Ludovick", adr);
            h3.Afficher();
        }
    }
}
