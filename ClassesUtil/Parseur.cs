//-----------------------------------------
//  Nom: Parseur.cs
//  Auteur : Alain Martel
//  Date : 2025-0
//  Description: 
//-----------------------------------------
using AtelierOO_101.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.ClassesUtil
{
    enum CODE_ERREUR
    {
        NomTropLong = 100,
        NomTropCourt = 200,
        TropVieux = 300,
        Mineur = 400
    }

    internal class Parseur
    {
        //------------------------------------------
        //
        //------------------------------------------
        public bool ParsingHumain(string? infoBrute, out Humain h, out string msgErr)
        {
            h = new Humain();
            msgErr = "";

            if (infoBrute == null)
                return true;


            int iter = 0;

            int nbChamps = CompterChamps(infoBrute);

            if (nbChamps == 13)
            {
                iter++;
                string[] tabInfo = infoBrute.Split(';');
                if (ValiderStagiaire(tabInfo, out string errValidation))
                {
                    h = new Stagiaire(tabInfo[0],
                                new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                                tabInfo[4],
                                new Adresse(tabInfo[5], tabInfo[6], tabInfo[7]),
                                tabInfo[8], tabInfo[9], double.Parse(tabInfo[10]),
                                tabInfo[11], int.Parse(tabInfo[12])
                                );
                    return true;
                }
                else
                {
                    msgErr = $"Information corrompue: {errValidation}";
                    return false;
                }
            }


            if (nbChamps == 11)
            {
                iter++;
                string[] tabInfo = infoBrute.Split(';');
                if (ValiderEtudiant(tabInfo, out string errValidation))
                {
                    h = new Etudiant(tabInfo[0],
                                new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                                tabInfo[4],
                                new Adresse(tabInfo[5], tabInfo[6], tabInfo[7]),
                                tabInfo[8], tabInfo[9], double.Parse(tabInfo[10])
                                );
                    return true;
                }
                else
                {
                    msgErr = $"Information corrompue: {errValidation}";
                    return false;
                }
            }


            if (nbChamps == 8)
            {
                iter++;
                string[] tabInfo = infoBrute.Split(';');
                if (ValiderHumain(tabInfo, out string errValidation))
                {
                    h = new Humain(tabInfo[0],
                                new DateTime(int.Parse(tabInfo[1]), int.Parse(tabInfo[2]), int.Parse(tabInfo[3])),
                                tabInfo[4],
                                new Adresse(tabInfo[5], tabInfo[6], tabInfo[7])
                                );

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
                errValidation = CODE_ERREUR.NomTropLong.ToString();
                return false;
            }
            if (tabInfo[0].Length < 2)
            {
                errValidation = CODE_ERREUR.NomTropCourt.ToString();
                return false;
            }
            return true;
        }

        //------------------------------------------
        //
        //------------------------------------------
        private bool ValiderEtudiant(string[] tabInfo, out string errValidation)
        {
            errValidation = "";
            return true;
        }
        //------------------------------------------
        //
        //------------------------------------------
        private bool ValiderStagiaire(string[] tabInfo, out string errValidation)
        {
            errValidation = "";
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
