using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Etudiant : Humain
    {
        public string Matricule { get; set; }
        public string Programme { get; set; }
        public double Moyenne { get; set; }
        Util _u = new();

        static int MatMax = 1000000;

        public Etudiant()
        {
            _u.Sep("In constructeur Etudiant()");
            Matricule = "1234567";
            Programme = "Techniques de l'informatique";
            Moyenne = 0.99;
        }
        public Etudiant(string mat, string prog, double moy)
        {
            _u.Sep("In constructeur Etudiant(m,p,mo)");
            Matricule = mat;
            Programme = prog;
            Moyenne = moy;
        }
        public Etudiant(string n, DateTime nais, string g, string mat, string prog, double moy) : base(n, nais, g)
        {
            _u.Sep("In constructeur Etudiant(n,ne, g, m,p,mo)");
            Matricule = mat;
            Programme = prog;
            Moyenne = moy;
        }
        public Etudiant(string n, DateTime nais, string g, Adresse dom, string prog, double moy) :
            base(n, nais, g, dom)
        {
            MatMax++;
            Matricule = MatMax.ToString();
            Programme = prog;
            Moyenne = moy;
        }
        public Etudiant(string n, DateTime nais, string g, Adresse dom, string mat, string prog, double moy) :
            base(n, nais, g, dom)
        {

            Matricule = mat;
            Programme = prog;
            Moyenne = moy;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write($", {Matricule}, {Programme} moy de {Moyenne}");
        }
    }
}
