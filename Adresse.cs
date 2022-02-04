using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    class Adresse
    {
        string _numCivic;
        string _rue;
        string _ville;
        string _province;

        public Adresse()
        {
            _numCivic = "0";
            _rue = "";
            _ville = "";
            _province = "";
        }
        public Adresse(string nc, string r, string v, string p)
        {
            _numCivic = nc;
            _rue = r;
            _ville = v;
            _province = p;
        }

        public void Afficher()
        {
            Console.WriteLine("{0} {1}\nville {2}, {3} ", _numCivic, _rue, _ville, _province);
        }

        public bool Existe()
        {
            return _numCivic != "0";
        }

    }
}
