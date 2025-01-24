using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Financier
    {
        public void Exec()
        {
            Console.WriteLine("\tFinancier H25!\n___________________________\n");

            Console.Write("Montant de la dette:");
            string detteStr = Console.ReadLine();
            int dette = int.Parse(detteStr);

            Console.Write("Taux intérêt:");
            string tauxInteretAnnuelStr = Console.ReadLine();
            double tauxInteretAnnuel = double.Parse(tauxInteretAnnuelStr);

            Console.Write("Affichage détaillé? (o/n):");
            ConsoleKeyInfo cle = Console.ReadKey();
            char infoDetail = cle.KeyChar;

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
