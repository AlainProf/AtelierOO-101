//-----------------------------------------
//  Nom: TicTacToe.cs
//  Auteur : Alain Martel
//  Date : 2025-0
//  Description: 
//-----------------------------------------
using AtelierOO_101.ClassesUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Applications
{
    internal class TicTacToe
    {
        Util u = new();
        char _prochainJoueur = 'x';
        bool _partieEnCours = true;
        char[] _cases = new char[9] { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        //------------------------------------------
        //
        //------------------------------------------
        public void Jouer()
        {
            while (_partieEnCours)
            {


                AfficherGrille();
                ProchainCoup();
                if (CoupGagnant())
                {

                    AfficherGrille();
                    Console.WriteLine("\n\nBRAVO!! vous abez gagné!!");
                    _partieEnCours = false;
                }
            }
            u.Pause();
        }


        //------------------------------------------
        //
        //------------------------------------------
        private bool CoupGagnant()
        {
            // Gagnant par une ligne
            if (_cases[0] != ' ' && _cases[0] == _cases[1] && _cases[1] == _cases[2])
            {
                return true;
            }
            if (_cases[3] != ' ' && _cases[3] == _cases[4] && _cases[4] == _cases[5])
            {
                return true;
            }
            if (_cases[6] != ' ' && _cases[6] == _cases[7] && _cases[7] == _cases[8])
            {
                return true;
            }

            // Gagnant par une colonne
            if (_cases[0] != ' ' && _cases[0] == _cases[3] && _cases[3] == _cases[6])
            {
                return true;
            }
            if (_cases[1] != ' ' && _cases[1] == _cases[4] && _cases[4] == _cases[7])
            {
                return true;
            }
            if (_cases[2] != ' ' && _cases[2] == _cases[5] && _cases[5] == _cases[8])
            {
                return true;
            }

            // Gagnant par une diagonale
            if (_cases[0] != ' ' && _cases[0] == _cases[4] && _cases[4] == _cases[8])
            {
                return true;
            }
            if (_cases[2] != ' ' && _cases[2] == _cases[4] && _cases[4] == _cases[6])
            {
                return true;
            }
            return false;
        }
        //------------------------------------------
        //
        //------------------------------------------
        private void AfficherGrille()
        {
            u.Titre("Tic Tac Toe");
            Console.WriteLine("_" + _cases[0] + "_|_" + _cases[1] + "_|_" + _cases[2] + "_");
            Console.WriteLine("_" + _cases[3] + "_|_" + _cases[4] + "_|_" + _cases[5] + "_");
            Console.WriteLine(" " + _cases[6] + " | " + _cases[7] + " | " + _cases[8] + " ");
        }

        //------------------------------------------
        //
        //------------------------------------------
        private void ProchainCoup()
        {
            Console.WriteLine($"\n\nAu joueur {_prochainJoueur} de jouer! Quelle case? (0 à 8)");
            char coup = 'Q';

            while (!CoupLegal(coup))
            {
                coup = u.SaisirChar();
            }
            int idx = int.Parse(coup.ToString());
            _cases[idx] = _prochainJoueur;

            if (_prochainJoueur == 'x')
                _prochainJoueur = 'o';
            else
                _prochainJoueur = 'x';
        }

        //------------------------------------------
        //
        //------------------------------------------
        private bool CoupLegal(char coup)
        {
            if (coup == '0' || coup == '1' || coup == '2' || coup == '3' || coup == '4' || coup == '5' || coup == '6' || coup == '7' || coup == '8')
            {
                int idxCoup = int.Parse(coup.ToString());
                if (_cases[idxCoup] == ' ')
                    return true;
            }
            return false;
        }
    }
}
