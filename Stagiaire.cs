using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Stagiaire:Etudiant
    {
        public void Afficher()
        {
            Console.WriteLine($"{Nom}");
        }

    }
}
