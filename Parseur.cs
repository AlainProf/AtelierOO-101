//-----------------------------------------
//  Nom: 
//  Auteur : Alain Martel
//  Date : 2025-0
//  Description: 
//-----------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class Parseur
    {
        //------------------------------------------
        //
        //------------------------------------------
        public bool ParsingHumain(string infoBrute, out Humain h, out string msgErr)
        {
            h = new Humain();
            msgErr = "";

            int nbChamps = CompterChamps(infoBrute);
            if (nbChamps == 8)
            {
                string[] tabInfo = infoBrute.Split(';');
                if (ValiderHumain(tabInfo, out string errValidation))
                {
                    h = new Humain(tabInfo[0],
                                new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                                tabInfo[4],
                                new Adresse(tabInfo[5], tabInfo[6], tabInfo[7]));
                    return true;
                }
                else
                {
                    msgErr = $"Information corrompue: {errValidation}";
                    return false;
                }
            }
            msgErr = "Nombre de champs incorrect";
            return false;
        }

        //------------------------------------------
        //
        //------------------------------------------
        private bool ValiderHumain(string[] tabInfo, out string errValidation)
        {
            errValidation = "";
            if (tabInfo[0].Length > 50)
            {
                errValidation = "Nom trop long";
                return false;
            }
            if (tabInfo[0].Length < 2)
            {
                errValidation = "Nom trop court";
                return false;
            }
            if (int.TryParse(tabInfo[1], out int val))
            {
                if (val < 1900)
                {
                    errValidation = " trop vieux";
                    return false;
                }
                if (val > 2007)
                {
                    errValidation = " mineur ";
                    return false;
                }
            }
            else
            {
                errValidation = "Année n'est pas un numérique";
                return false;
            }
            return true;
        }

        //------------------------------------------
        //
        //------------------------------------------
        private int CompterChamps(string info)
        {
            if (info.Length == 0)
                return 0;

            int nbChamps = 1;
            foreach (char ch in info)
            {
                if (ch == ';')
                    nbChamps++;
            }
            return nbChamps;
        }

    }

}
