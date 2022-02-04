using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    class Humain
    {
        private string _nom;
        private DateTime _naissance;
        private DateTime _deces;
        private Adresse _residence;

        public Humain()
        {
            _nom = "inconnu";
            _naissance = DateTime.Now;
            _deces = new DateTime(1, 1, 1);
            _residence = new Adresse();
        }

        public Humain(DateTime na, string n = "incognito")
        {
            _nom = n;
            _naissance = na;
            _deces = new DateTime(1, 1, 1);
            _residence = new Adresse();
        }
        public Humain(DateTime na, string n, DateTime d)
        {
            _nom = n;
            _naissance = na;
            _deces = d;
            _residence = new Adresse();
        }
        public Humain(DateTime na, string n, Adresse a)
        {
            _nom = n;
            _naissance = na;
            _residence = a;
        }



        private bool EstVivant()
        {
            return _deces.Ticks < 100000;
        }

        public long Age()
        {
            double delta;
            if (EstVivant())
                delta = DateTime.Now.Ticks - _naissance.Ticks;
            else
                delta = _deces.Ticks - _naissance.Ticks;
            
            return (long) (delta / 10000000 / (365.24 * 24 * 60 * 60));
        }

        public void Afficher()
        {
            Console.WriteLine("nom {0}\n né le {1}", _nom, _naissance);
            Console.WriteLine("agé de {0} ans", Age());

            if (!EstVivant())
                Console.WriteLine("Décédé depuis {0} ans", AnsDepuisDeces());

            if (_residence.Existe())
            {
                Console.WriteLine("\nDemeure au");
                _residence.Afficher();
            }
            else
                Console.WriteLine("SDF");
        }

        public long AnsDepuisDeces()   
        {
            double delta = DateTime.Now.Ticks - _deces.Ticks;
            return (long)(delta / 10000000 / (365.24 * 24 * 60 * 60));
        }
         

        public void Mourir()
        {
            _deces = DateTime.Now;
        }


    }
}
