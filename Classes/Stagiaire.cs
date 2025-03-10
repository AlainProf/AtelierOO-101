﻿//-----------------------------------------
//  Nom: Stagiaire.cs
//  Auteur : Alain Martel
//  Date : 2025-03-05
//  Description: 
//-----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    internal class Stagiaire : Etudiant
    {
        public string Entreprise { get; set; }
        public int Salaire;

        //------------------------------------------
        //
        //------------------------------------------
        public Stagiaire(string n, DateTime nais, string g, Adresse dom, string prog, double moy, string entrep, int sal) : base(n, nais, g, dom, prog, moy)
        {
            Entreprise = entrep;
            Salaire = sal;
        }
        //------------------------------------------
        //
        //------------------------------------------
        public Stagiaire(string n, DateTime nais, string g, Adresse dom,
                         string mat, string prog, double moy,
                         string entrep, int sal) : base(n, nais, g, dom, mat, prog, moy)
        {
            Entreprise = entrep;
            Salaire = sal;
        }

        //------------------------------------------
        //
        //------------------------------------------
        public override void Afficher()
        {
            base.Afficher();
            Console.Write($" en stage chez {Entreprise}, {Salaire}$/an");
        }

    }
}
