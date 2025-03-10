﻿//-----------------------------------------
//  Nom: Exploration.cs
//  Auteur : Alain Martel
//  Date : 2025-01-27
//  Description: 
//-----------------------------------------
using AtelierOO_101.Classes;
using AtelierOO_101.ClassesUtil;
using AtelierOO_101.Donnees;
using AtelierOO_101.Poker;
using AtelierOO_101.TP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Explo
{
    internal class Exploration
    {
        const int NB_COLONNNES = 27;
        const int NB_RANGEES = 20;

        Util u = new();
        const int taille = 10;
        int[] tabEntiers = new int[taille];
        Humain[] tabGr101 = new Humain[taille];
        Random r = new();


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
                Humain h = new Humain(u.tabNoms[r.Next(0, 10)], new DateTime(r.Next(1964, 2008), r.Next(1, 13), r.Next(1, 29)));
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
            return 1;
            //return a.Nom.CompareTo(b.Nom);
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

        //------------------------------------------
        //
        //------------------------------------------
        public void ExecException()
        {
            try
            {
                divParZ(0);
                u.Sep("Post divParZ()");
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("division par Zéro " + ex.Message);
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

        //------------------------------------------
        //
        //------------------------------------------
        private void divParZ(int den)
        {
            int va = 1000 / den;
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void ExecHeritage()
        {
            u.Titre("Protected et Héritage");


            u.Pause();


            /*Etudiant e1 = new Etudiant();
            e1.Afficher();

            e1 = new Etudiant("2222222", "soins infirmier", 0.59);
            e1.Afficher();

            e1 = new Etudiant("Gabriel", new DateTime(2007,12,23), "M", "3333333", "science nat ", 0.89);
            e1.Afficher();
            u.Pause();*/


        }

        //------------------------------------------
        //
        //------------------------------------------
        public void ReadOnlyVsConst()
        {
            u.Titre("Const vs readonly");
            u.Pause();
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void ExercInterface()
        {
            u.Titre("Interface ");

            Humain h1 = new Humain("Raphael", new Adresse("123", "allo", "Zagreb"));
            Humain h2 = new Humain("MichelAngelo", new Adresse("23", "allo", "Zagreb"));
            Humain h3 = new Humain("Leo", new Adresse("3", "allo", "Zagreb"));
            Humain h4 = new Humain("Donatello", new Adresse("1", "allo", "Zagreb"));

            List<Humain> tmnt = new List<Humain>();
            tmnt.Add(h1);
            tmnt.Add(h2);
            tmnt.Add(h3);
            tmnt.Add(h4);


            u.Sep("Liste originale");
            foreach (Humain h in tmnt)
            {
                h.Afficher();
            }

            tmnt.Sort();
            u.Sep("Liste triée");
            foreach (Humain h in tmnt)
            {
                h.Afficher();
            }


            u.Sep("Tri à la carte");
            tmnt.Sort(Humain.ComparerNom);
            foreach (Humain h in tmnt)
            {
                h.Afficher();
            }


            u.Pause();
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void PileEtFile()
        {
            u.Titre("Pile et File (stack et Queue)");

            Voiture v1 = new("Ford", "Focus", "Noire");
            Voiture v2 = new("Mercedes", "AMG1", "Rose");
            Voiture v3 = new("Nissan", "Micra", "Jaune");

            Stack<Voiture> entreeGarage = new Stack<Voiture>();

            entreeGarage.Push(v1);
            v1.Afficher();
            entreeGarage.Push(v2);
            v2.Afficher();
            entreeGarage.Push(v3);
            v3.Afficher();

            u.Sep("Position dans la pile:");


            u.Sep("Position de sortie:");

            while (entreeGarage.Count > 0)
            {
                Voiture tmp = entreeGarage.Pop();
                tmp.Afficher();
            }


            u.Pause();

            u.Sep("---------------------");

            Queue<Voiture> laveAuto = new Queue<Voiture>();
            u.Sep("Position dans la file:");

            laveAuto.Enqueue(v1);
            v1.Afficher();
            laveAuto.Enqueue(v2);
            v2.Afficher();
            laveAuto.Enqueue(v3);
            v3.Afficher();


            u.Sep("Position de sortie:");

            while (laveAuto.Count > 0)
            {
                Voiture tmp = laveAuto.Dequeue();
                tmp.Afficher();
            }


            u.Pause();
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void Tab2D()
        {
            u.Titre("Tableau à deux dimension");



            char[,] grille = new char[NB_COLONNNES, NB_RANGEES];

            InitGrilleA(ref grille);
            AfficherGrille(grille);

            u.Pause();
        }

        //------------------------------------------
        //
        //------------------------------------------
        void InitGrilleA(ref char[,] gr)
        {
            for (int y = 0; y < NB_RANGEES; y++)
            {
                for (int x = 0; x < NB_COLONNNES; x++)
                {
                    switch (u.rdm.Next(0, 3))
                    {
                        case 0:
                            gr[x, y] = 'O';
                            break;

                        case 1:
                            gr[x, y] = 'X';
                            break;

                        case 2:
                            gr[x, y] = '_';
                            break;

                    }
                }
            }
        }
        //------------------------------------------
        //
        //------------------------------------------
        void InitGrilleH(ref char[,] gr)
        {
            int iter = 65;
            for (int y = 0; y < NB_RANGEES; y++)
            {
                for (int x = 0; x < NB_COLONNNES; x++)
                {
                    if (iter > 90)
                    {
                        iter = 65;
                    }
                    gr[x, y] = (char)iter;
                    iter++;
                }
            }
        }
        //------------------------------------------
        //
        //------------------------------------------
        void InitGrille(ref char[,] gr)
        {
            int iter = 65;
            for (int x = 0; x < NB_COLONNNES; x++)
            {
                for (int y = 0; y < NB_RANGEES; y++)
                {
                    if (iter > 90)
                    {
                        iter = 65;
                    }
                    gr[x, y] = (char)iter;
                    iter++;
                }
            }
        }
        //------------------------------------------
        //
        //------------------------------------------
        void AfficherGrille(char[,] gr)
        {
            for (int x = 0; x < NB_COLONNNES; x++)
            {
                for (int y = 0; y < NB_RANGEES; y++)
                {
                    Console.SetCursorPosition(x * 4 + 10, y + 12);
                    Console.Write("|_");
                    Console.Write(gr[x, y]);
                    Console.Write("_|");
                }
            }
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void GenereBD(int nbEnreg = 1000000)
        {
            u.Titre("Faudrait réactiver le code");
            u.Pause();

            ////////////////////////////////////////

            u.Titre($"Génération de {nbEnreg} humains");
            List<Humain> population = new List<Humain>();

            for (int i = 0; i < nbEnreg; i++)
            {
                population.Add(Util.GenereHumainAleatoire());
            }

            u.Pause();

            int cmpEtudiants = 0;
            int cmpStagiaires = 0;

            StreamWriter sw = new StreamWriter(@"d:\alino\atelier\pop.txt");

            foreach (Humain h2 in population)
            {
                StringBuilder sb = new();
                sb.Append(h2.Nom);
                sb.Append(";");
                sb.Append($"{h2.Naissance.Year};{h2.Naissance.Month};{h2.Naissance.Day};");
                sb.Append(h2.Sexe + ";");
                sb.Append($"{h2.Domicile.NumCivique};{h2.Domicile.Rue};{h2.Domicile.Ville}");

                if (h2 is Etudiant)
                {
                    Etudiant? eTmp = h2 as Etudiant;
                    if (eTmp != null)
                    {
                        cmpEtudiants++;
                        sb.Append($";{eTmp.Matricule};{eTmp.Programme};{eTmp.Moyenne.ToString("N2")}");
                    }
                    if (eTmp is Stagiaire)
                    {
                        cmpEtudiants--;
                        cmpStagiaires++;
                        Stagiaire? stag = eTmp as Stagiaire;
                        if (stag != null)
                        {
                            sb.Append($";{stag.Entreprise};{stag.Salaire}");
                        }

                    }
                }
                sw.WriteLine(sb);
            }
            sw.Close();
            u.Sep($"ecriture de {population.Count}, dont {cmpEtudiants} étudiants, parmis ceux-ci {cmpStagiaires} stagiaires");
            u.Pause();
        }

    }
}
