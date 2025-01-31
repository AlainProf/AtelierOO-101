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
       // private string Nom;
        public string Nom { get; set; }
        public DateTime Naissance { get; set; }
        public string Sexe {  get; set; } 
        public Adresse Domicile { get; set; }

        //------------------------------------------
        //
        //------------------------------------------
        public Humain()
        {
            Nom = "inconnu";
            Naissance = new DateTime(1,1,1);
            Sexe = "F";
            Domicile = new Adresse();   
        }
        //------------------------------------------
        //
        //------------------------------------------
        public Humain(string n)
        {
            Nom = n;
            Naissance = DateTime.Now;
            Sexe = "F";
            Domicile = new Adresse();
        }
        //------------------------------------------
        //
        //------------------------------------------
        public Humain(string n, DateTime nais)
        {
            Nom = n;
            Naissance = nais;
            Sexe = "F";
            Domicile = new Adresse();
        }
        //------------------------------------------
        //
        //------------------------------------------
        public Humain(string n, DateTime nais, string s)
        {
            Nom = n;
            Naissance = nais;
            Sexe = s;
        }
        //------------------------------------------
        //
        //------------------------------------------
        public Humain(string n, DateTime nais, string s, Adresse dom)
        {
            Nom = n;
            Naissance = nais;
            Sexe = s;
            Domicile = dom;
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void Afficher()
        {
            Console.WriteLine($"{Nom}, {Age()} ans ");
            Domicile.Afficher();    
        }

        //------------------------------------------
        //
        //------------------------------------------
        public long Age()
        {
            long debut = Naissance.Ticks;
            long fin = DateTime.Now.Ticks;
            return (fin - debut) / (10000000 * (long)365.24 * 86400);
        }

        //------------------------------------------
        //
        //------------------------------------------
        public static int ComparerNom(Humain a, Humain b)
        {
            return a.Nom.CompareTo(b.Nom);
        }

        //------------------------------------------
        //
        //------------------------------------------
        public static int ComparerAge(Humain a, Humain b)
        {
            if (a.Naissance.Ticks < b.Naissance.Ticks)
                return 1;
            if (a.Naissance.Ticks > b.Naissance.Ticks)
                return -1;
            return 0;
        }
    }
}
