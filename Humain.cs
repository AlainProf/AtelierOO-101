using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Humain
    {
        private string _nom;
        private string _naissance;
        private string _sexe;

        public Humain()
        {
            _nom = "inconnu";
            _naissance = "0001-01-01";
            _sexe = "M";
        }
        public Humain(string n, string nais, string s)
        {
            _nom = n ;
            _naissance = nais;
            _sexe = s;
        }

        public void Afficher()
        {
            Console.WriteLine($"{_nom}, né le {_naissance}");
        }
    }
}
