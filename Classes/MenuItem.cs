using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    class MenuItem
    {
        public string Nom { get; set; }
        public char Touche { get; set; }

        public Func<int> Action { get; set; }

        public MenuItem(string n, char t, Func<int> aExecuter)
        {
            Nom = n;
            Touche = t;
            Action = aExecuter;
        }
    }
}
