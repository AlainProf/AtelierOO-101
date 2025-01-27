//-----------------------------------------
//  Nom: Financier.cs
//  Auteur : Alain Martel
//  Date : 2025-01-27
//  Description: 
//-----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Financier
    {
        Util u = new Util();
        //------------------------------------------
        //
        //------------------------------------------
        public void Exec()
        {
            bool rester = true;
            while (rester)
            {
                u.Titre("Financier 2025");
                AfficherMenu();
                ExecuterChoix(ref rester);
            }
        }
        //------------------------------------------
        //
        //------------------------------------------
        static void AfficherMenu()
        {
            Console.WriteLine("R: Remboursement d'un prêt");
            Console.WriteLine("P: Placement (rendement)");
            Console.WriteLine("Q: Quitter");
            Console.Write("\nVotre choix:");
        }


        //------------------------------------------
        //
        //------------------------------------------
        void ExecuterChoix(ref bool rester)
        {
            char choix = u.SaisirChar();

            switch (choix.ToString().ToLower())
            {
                case ("r"):
                    CalculerRemboursement();
                    u.Pause();
                    break;
                case ("p"):
                    CalculerPlacement();
                    u.Pause();
                    break;
                case ("q"):
                default:
                    rester = false;
                    break;
            }
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void CalculerPlacement()
        {
            u.Titre("Rendement d'un placement");

            Console.Write("Montant du placement:");
            int placement = u.SaisirEntier();
            
            Console.Write("Taux intérêt annuel:");
            double tauxInteretAnnuel = u.SaisirReel();

            Console.Write("Durée du placement:");
            int duree = u.SaisirEntier();

            Console.Write("Composition (A|M|Q):");
            char compo = u.SaisirChar();
            Console.WriteLine();

            Console.Write("Affichage détaillé? (o/n):");
            char infoDetail = u.SaisirChar();
            Console.WriteLine();

            double intCum = 0;
            double capitalCum = placement;

            if (infoDetail == 'o')
            {
                Console.WriteLine(@"{0}{1}{2}", "année".PadLeft(6),
                                  "Placement".PadLeft(12),
                                  "int courant".PadLeft(12));
            }

            for(int i=0; i<duree; i++) 
            {
                double intCourant = capitalCum * tauxInteretAnnuel;
                intCum += intCourant;
                capitalCum += intCourant;   
                
                if (infoDetail == 'o')
                {
                    Console.WriteLine(i.ToString().PadLeft(6)
                                   + (capitalCum - intCourant).ToString("N2").PadLeft(12)
                                   + intCourant.ToString("N2").PadLeft(12));
                }
            }
            Console.WriteLine("\n_________________________________\n");
            Console.WriteLine($"Rendement de {intCum.ToString("N2")}$ sur un placement de {placement}. (total : {capitalCum.ToString("N2")})");
        }

        //------------------------------------------
        //
        //------------------------------------------
        public void CalculerRemboursement()
        {
            u.Titre("Remboursement d'un prêt");

            Console.Write("Montant de la dette:");
            int dette = u.SaisirEntier();

            Console.Write("Taux intérêt:");
            double tauxInteretAnnuel = u.SaisirReel();

            Console.Write("Affichage détaillé? (o/n):");
            char infoDetail = u.SaisirChar();

            double tauxIntMensuel = tauxInteretAnnuel / 12;
            double pourcentageMinDelaDette = 0.04;
            double detteResiduelle = dette;
            double intCum = 0;
            double paieCum = 0;


            int nbMois = 0;

            if (infoDetail == 'o')
            {

                Console.WriteLine(@"{0}{1}{2}{3}{4}{5}{6}", "Mois".PadLeft(6),
                                  "Dette".PadLeft(12),
                                  "Paiem mens".PadLeft(12),
                                  "rembours".PadLeft(12),
                                  "int mens".PadLeft(12),
                                  "int cum".PadLeft(12),
                                  "paie cum".PadLeft(12));
            }

            while (detteResiduelle > 1)
            {
                nbMois++;

                double paiementCourant = detteResiduelle * pourcentageMinDelaDette;
                paieCum += paiementCourant;
                double intMensuel = detteResiduelle * tauxIntMensuel;
                intCum += intMensuel;
                double remboursementCourant = paiementCourant - intMensuel;
                detteResiduelle -= remboursementCourant;

                if (infoDetail == 'o')
                {
                    Console.WriteLine(nbMois.ToString().PadLeft(6)
                                   + (detteResiduelle + remboursementCourant).ToString("N2").PadLeft(12)
                                   + paiementCourant.ToString("N2").PadLeft(12)
                                   + remboursementCourant.ToString("N2").PadLeft(12)
                                   + intMensuel.ToString("N2").PadLeft(12)
                                   + intCum.ToString("N2").PadLeft(12)
                                   + paieCum.ToString("N2").PadLeft(12));
                }
            }
            Console.WriteLine("\n_________________________________\n");
            // Console.WriteLine("Dette de " + dette + "$" + " remboursée en " + nbMois + " mois" );    
            // Console.WriteLine(@"Dette de {0}$ remboursée en {1} mois", dette, nbMois);
            Console.WriteLine($"Dette de {dette}$ remboursée en {nbMois} mois. Intérêt cum:{intCum.ToString("N2")}$, paiement total:{paieCum.ToString("N2")}$");


        }
    }
}
