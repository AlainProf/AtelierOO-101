using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    /// <summary>
    /// Classe générale représentant un humain
    /// </summary>
    class Humain
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Humain()
        {
            _nom = "inconnu";
            _naissance = DateTime.Now;
            _deces = new DateTime(1, 1, 1);
            _residence = new Adresse();
        }

        public string GetNom()
        {
            return _nom;
        }

        public DateTime GetNaissance()
        {
            return _naissance;
        }

        /// <summary>
        /// Constructeur paramétré pour un humain vivant dont on ne connaît la résidence
        /// </summary>
        /// <param name="na">date de naissance</param>
        /// <param name="n">nom de l'humain, avec valeur par défaut si nécessaire</param>
        public Humain(DateTime na, string n = "incognito")
        {
            _nom = n;
            _naissance = na;
            _deces = new DateTime(1, 1, 1);
            _residence = new Adresse();
        }
        /// <summary>
        /// Constructeur pour un humain décédé
        /// </summary>
        /// <param name="na">date de naissance</param>
        /// <param name="n">nom</param>
        /// <param name="d">date de décès</param>
        public Humain(DateTime na, string n, DateTime d)
        {
            _nom = n;
            _naissance = na;
            _deces = d;
            _residence = new Adresse();
        }
        /// <summary>
        /// Constructeur pour un humain dont on connait la résidence
        /// </summary>
        /// <param name="na">date de naissance</param>
        /// <param name="n">nom</param>
        /// <param name="a">adresse de résidence</param>
        public Humain(DateTime na, string n, Adresse a)
        {
            _nom = n;
            _naissance = na;
            _residence = a;
        }


       /// <summary>
       /// Méthode qui calcule l'âge d'un humain, s'il est décédé on calcule l'age atteint au décès
       /// </summary>
       /// <returns>nombre d'années complètes</returns>
       public long Age()
        {
            double delta;
            if (EstVivant())
            {
                delta = DateTime.Now.Ticks - _naissance.Ticks;
            }
            else
            {
                delta = _deces.Ticks - _naissance.Ticks;
            }
            
            return (long) (delta / 10000000 / (365.24 * 24 * 60 * 60));
        }

        /// <summary>
        /// Affichage de tous les détails de l'humain
        /// </summary>
        public virtual void Afficher()
        {
            Console.WriteLine("nom {0}\n né le {1}", _nom, _naissance);
            Console.WriteLine("agé de {0} ans", Age());

            if (!EstVivant())
            {
                Console.WriteLine("Décédé depuis {0} ans", AnsDepuisDeces());
            }

            if (_residence.Existe())
            {
                Console.WriteLine("\nDemeure au");
                _residence.Afficher();
            }
            else
                Console.WriteLine("SDF");
            Console.WriteLine("-------------\n");
        }

        /// <summary>
        /// Calcule le temps depuis le décès
        /// </summary>
        /// <returns>le nombre d'année complètes écoulées depuis le décès</returns>
        public long AnsDepuisDeces()   
        {
            double delta = DateTime.Now.Ticks - _deces.Ticks;
            return (long)(delta / 10000000 / (365.24 * 24 * 60 * 60));
        }
         

        /// <summary>
        /// Méthode appelée lors du décès d'un humain, fixe la date de décès à maintenant
        /// </summary>
        public void Mourir()
        {
            _deces = DateTime.Now;
        }

        protected string _nom;
        protected DateTime _naissance;
        protected DateTime _deces;
        protected Adresse _residence;
        //------------------------------------
        //
        //------------------------------------
        private bool EstVivant()
        {
            return _deces.Ticks < 100000;
        }

    }
}
