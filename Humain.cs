//-----------------------------------------
//  Nom: Humain.cs
//  Auteur : Alain Martel
//  Date : 2025-01-27
//  Description: 
//-----------------------------------------
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
        private DateTime _naissance;
        private string _sexe;

        //------------------------------------------
        //
        //------------------------------------------
        public Humain()
        {
            _nom = "inconnu";
            _naissance = new DateTime(1,1,1);
            _sexe = "F";
        }
        //------------------------------------------
        //
        //------------------------------------------
        public Humain(string n)
        {
            _nom = n;
            _naissance = DateTime.Now;
            _sexe = "F";
        }
        //------------------------------------------
        //
        //------------------------------------------
        public Humain(string n, DateTime nais, string s)
        {
            _nom = n;
            _naissance = nais;
            _sexe = s;
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void Afficher()
        {
            Console.WriteLine($"{_nom}, {Age()} ans ");
        }

        //------------------------------------------
        //
        //------------------------------------------
        public long Age()
        {
            long debut = _naissance.Ticks;
            long fin = DateTime.Now.Ticks;
            return (fin - debut) / (10000000 * (long)365.24 * 86400);
        }

        //------------------------------------------
        //
        //------------------------------------------
        public static int ComparerNom(Humain a, Humain b)
        {
            return a._nom.CompareTo(b._nom);
        }

        //------------------------------------------
        //
        //------------------------------------------
        public static int ComparerAge(Humain a, Humain b)
        {
            if (a._naissance.Ticks < b._naissance.Ticks)
                return 1;
            if (a._naissance.Ticks > b._naissance.Ticks)
                return -1;
            return 0;
        }
    }
}
