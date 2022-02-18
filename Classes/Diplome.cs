using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    class Diplome
    {
        public string Nom { get; set; }
        public string Niveau { get;set; }
        public DateTime Obtention { get; set; }

        public void Afficher()
        {
            Console.WriteLine("Diplome {0} d'étude {1}\t obetenu le {2}", Nom, Niveau, Obtention);
        }
    }
}
