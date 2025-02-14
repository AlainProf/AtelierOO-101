using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.ONU
{
    class Ville
    {
        private Util _u = new();
        public string Nom {  get; set; }    
        public CoordGeo Position { get; set; }

        public int Population {  get; set; }
        public Ville()
        {
            Nom = "Atlantide";
            Position = new(0, 0);
        }
        public Ville(string n, CoordGeo pos, int pop)
        {
            Nom = n;
            Position = pos;
            Population = pop;
        }

        public void Afficher()
        {
            _u.Sep(Nom);
            Console.WriteLine("Situé à ");
            Position.Afficher();
            Console.WriteLine($"Population : {Population}");  
        }

        public static int ComparePop(Ville va, Ville vb)
        {
            if (va.Population > vb.Population) return 1;
            if (va.Population < vb.Population) return -1;
            return 0;
        }
    }
}
