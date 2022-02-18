using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    class Citoyen : Humain
    {
        public string NAS { get; set; }
        public string Sexe { get; set; }
        public List<Diplome> Scolarite {get; set;}

        public Citoyen() 
        {
            _nom = "non défini";
            _naissance = new DateTime(1, 1, 1);
            _residence = new();

            Scolarite = new();
        }

        public Citoyen(string n, DateTime na, string nas, string s): 
            base(na, n)
        {
            Sexe = s;
            NAS = nas;
            Scolarite = new List<Diplome>();
        }

        

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("NAS:{0}\nSexe{1}", NAS, Sexe);
            Console.WriteLine("___________________\n");

            if (Scolarite.Count > 0)
            {
                foreach(Diplome dip in Scolarite)
                {
                    dip.Afficher();
                }
            }
            else
            {
                Console.WriteLine(" aucun diplôme encore\n");
            }
         }
    }
}
