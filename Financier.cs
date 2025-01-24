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
            Util.Titre("Financier 101!");

            int dette = 1000;
            double tauxInteret = 0.24 / 12;
            double detteResiduelle = dette;
            double intCum = 0;
            double paieCum = 0;
            int nbMois = 0;

            while (detteResiduelle > 5)
            {
                nbMois++;
                double intMensuel = tauxInteret * detteResiduelle;
                intCum += intMensuel;
                double remboursementMin = detteResiduelle * 0.04;
                paieCum += remboursementMin;

                double remboursementMensuel = remboursementMin - intMensuel;

                detteResiduelle -= remboursementMensuel;

                Console.WriteLine("mois :" + nbMois +
                                  " Dette: " + (detteResiduelle + remboursementMin).ToString("N2") +
                                  " paiement du mois: " + remboursementMin.ToString("N2") +
                                  " int mensuel: " + intMensuel.ToString("N2") +
                                  " rembourse:" + remboursementMensuel.ToString("N2") +
                                  " int cum" + intCum.ToString("N2") +
                                  " paie cum" + paieCum.ToString("N2"));

            }

        }
    }
}
