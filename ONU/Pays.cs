using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.ONU
{
    class Pays
    {
        Util _u = new();
        public string Nom {  get; set; }    
        List<Ville> Villes { get; set; } 
        Ville Capital {  get; set; }

        public Pays(string n, List<Ville> lv, Ville cap)
        {
            Nom = n;
            Villes = lv;
            Villes.Add(cap);
            Capital = cap;
        }

        public void Afficher()
        {
            _u.Sep(Nom);
            Console.WriteLine($" Sa capital est: {Capital.Nom}");
            Console.WriteLine("Liste de ses villes:");

            Villes.Sort(Ville.ComparePop);  
        
            int pop = 0;




            foreach (Ville v in Villes)
            {
                v.Afficher();
                pop += v.Population;
            }

            Console.WriteLine($"{pop} habitants");  



        }


    }
}
