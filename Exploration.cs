//-----------------------------------------
//  Nom: Exploration.cs
//  Auteur : Alain Martel
//  Date : 2025-01-27
//  Description: 
//-----------------------------------------
using AtelierOO_101.Poker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Exploration
    {
        Util u = new ();
        const int taille = 10;
        int[] tabEntiers = new int[taille];
        Humain[] tabGr101 = new Humain[taille];
        Random r = new ();


        List<int> listeEntiers = new();
        List<Humain> lstGr101 = new List<Humain>();

        //------------------------------------------
        //
        //------------------------------------------
        public void ExploRefOut()
        {
            u.Titre("Exploration des param Out et Ref");

            int p = 18;
            fonction1(p);
            u.Sep("Post f1 (par valeur) : " + p);
            fonction2(ref p);
            u.Sep("Post f2 (par ref): " + p);


            fonction3(out int p2);
            u.Sep("Post f3 (par out) : " + p2);

            u.Pause();

        }

        //------------------------------------------
        //
        //------------------------------------------
        void fonction1(int p)
        {
            u.Sep("in fct 1 : " + p);
            p = p * 2;
        }
        //------------------------------------------
        //
        //------------------------------------------
        void fonction2(ref int p)
        {
            u.Sep("in fct 2 : " + p);
            p = p * 3;
        }
        //------------------------------------------
        //
        //------------------------------------------
        void fonction3(out int p)
        {
            p = 1;
            u.Sep("in fct 3 : " + p);
            p = p * 4;
        }


        //------------------------------------------
        //
        //------------------------------------------
        public void ExploListeH()
        {
            u.Titre("Liste des étudiants");

            for (int i = 0; i < taille; i++)
            {
                Humain h = new Humain(u.tabNoms[r.Next(0,10)], new DateTime(r.Next(1964, 2008), r.Next(1, 13), r.Next(1, 29)));
                Adresse adresse = new Adresse("1234", "rue Cartier", "Laval");
                h.Domicile = adresse;    
                lstGr101.Add(h);
            }
            u.Sep("Liste d'humains");
            AfficherListeH();
            u.Pause();
            lstGr101.Sort(ComparerAgeLoc);
            u.Sep("Liste triée");
            AfficherListeH();
            u.Pause();
            lstGr101.Sort(ComparerNomLoc);
            u.Sep("Liste triée");
            AfficherListeH();
            u.Pause();


        }

        //------------------------------------------
        //
        //------------------------------------------
        private void AfficherListeH()
        {

            for (int i = 0; i < lstGr101.Count; i++)
            {
                lstGr101[i].Afficher();
            }
        }

        //------------------------------------------
        //
        //------------------------------------------
        private int ComparerAgeLoc(Humain a, Humain b)
        {
            if (a.Naissance > b.Naissance)
            { return 1; }
            if (a.Naissance < b.Naissance)
            { return -1; }
            return 0;
        }

        //------------------------------------------
        //
        //------------------------------------------
        private int ComparerNomLoc(Humain a, Humain b)
        {
            return a.Nom.CompareTo(b.Nom);
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void ExploListe()
        {
            u.Titre("Liste en C#");

            for (int i = 0; i < taille; i++)
            {
                listeEntiers.Add(r.Next(1, 1001));
            }
            u.Sep("Liste d'entiers");
            // AfficherListe();
            u.Pause();
            listeEntiers.Sort();
            u.Sep("Liste triée");
            //AfficherListe();
            u.Pause();
            double moy = listeEntiers.Average();
            u.Sep($"moyenne:{moy}");
            u.Pause();
        }

        //------------------------------------------
        //
        //------------------------------------------
        private void AfficherListe()
        {
            for (int i = 0; i < listeEntiers.Count; i++)
            {
                Console.WriteLine($"{i}: {listeEntiers[i]}");
            }
        }


        //------------------------------------------
        //
        //------------------------------------------
        public void ExploTableauH()
        {
           /* u.Titre("Tableau d'Humain");

            for (int i = 0; i < tabGr101.Length; i++)
            {
                tabGr101[i] = new Humain(tabNoms[r.Next(0,10)], new DateTime(r.Next(1964, 2008), r.Next(1,13), r.Next(1,29)), "M");
            }
            u.Sep("Tableau d'humain");
            AfficherTabH();
            u.Pause();

            Array.Sort(tabGr101, Humain.ComparerNom);
            u.Sep("Tableau trié");
            AfficherTabH();
            u.Pause();

            Array.Sort(tabGr101, Humain.ComparerAge);
            u.Sep("Tableau trié selon l'àge");
            AfficherTabH();
            u.Pause();*/
        }

        //------------------------------------------
        //
        //------------------------------------------
        private void AfficherTabH()
        {
            for (int i = 0; i < tabGr101.Length; i++)
            {
                tabGr101[i].Afficher();
            }
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void ExploTableau()
        {
            u.Titre("Exploration des tableau C#");

            for (int i = 0; i < tabEntiers.Length; i++)
            {
                tabEntiers[i] = r.Next(1, 1001);
            }
            u.Sep("Tableau d'entiers aléatoires");
            //AfficherTab();
            u.Pause();
            Array.Sort(tabEntiers);
            u.Sep("Tableau trié");
            AfficherTab();
            u.Pause();


        }

        //------------------------------------------
        //
        //------------------------------------------
        private void AfficherTab()
        {
            for (int i = 0; i < tabEntiers.Length; i++)
            {
                Console.WriteLine($"{i}: {tabEntiers[i]}");
            }
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void ExecEnum()
        {
            u.Titre("Énumération en C#");

            var res = typeof(Humain);
            u.Sep($"res = {res}");

            JourSemaine aujh = JourSemaine.Lundi;
            JourSemaine demain = (JourSemaine)1;

            int ind = 5;
            bool EstValide = Enum.IsDefined(typeof(JourSemaine), ind);

            if (EstValide)
            {
                JourSemaine jx = (JourSemaine)ind;
                u.Sep($"X est  {jx}");
            }
            else
            {
                u.Sep($"ind {ind} n'est pas un indice valide de JourSemaine");
            }

            u.Sep(aujh.ToString());
            u.Sep($"Demain nous serons {demain}");

       

            Carte c1 = new Carte();
            c1.Afficher();

            Carte c2 = new Carte(3, 10);
            c2.Afficher();
            u.Pause();

            Paquet paq = new Paquet();  
            paq.Afficher();
            u.Pause();

            paq = new Paquet(true);
            paq.Afficher();
            u.Sep("Trié");
            paq.Trier();
            paq.Afficher();
            u.Pause();

        }

        public void ExecException()
        {
            try
            {
                divParZ(0);
                u.Sep("Post divParZ()");
            }
            catch (DivideByZeroException ex)
            {
                throw (new Exception("division par Zéro"));
                //Console.WriteLine($"Une exception est survenue: division par Zéro");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Une exception est survenue: {ex.Message}");
            }
            finally
            {
                u.Sep("Fin de execException()");
                u.Pause();
            }

        }

        private void divParZ(int den)
        {
            int va = 1000 / den;
        }

        public void ExecHeritage()
        {
            Etudiant e1 = new Etudiant();
            e1.Afficher();
            u.Pause();
        }
    }
}
