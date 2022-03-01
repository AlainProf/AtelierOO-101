using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    class Carte
    {
        int _valeur;
        int _sorte;
        string _valTexte;

        private const int _largeurCarte = 4;

        public Carte()
        {
            _valeur = 0;
            _sorte = 0;
        }

        public Carte(int s, int v)
        {
            _valeur = v;
            _sorte = s;
        }

        public int Afficher(int decalageX, int decalageY)
        {
            SetValeurTexte();
            SetCouleurCarte();

            int xCarte = (decalageX * _largeurCarte) + decalageX;
            int yCarte = (decalageY * 4);

            Console.SetCursorPosition(xCarte, yCarte);
            Console.Write(_valTexte + "   ");
            Console.SetCursorPosition(xCarte, yCarte + 1);
            Console.Write("    ");
            Console.SetCursorPosition(xCarte, yCarte + 2);
            Console.Write("   " + _valTexte);

            //Console.Clear();

            return 0;
        }


        private void SetValeurTexte()
        {
            switch (_valeur)
            {
                case 12:
                    _valTexte = "A";
                    break;
                case 11:
                    _valTexte = "K";
                    break;
                case 10:
                    _valTexte = "Q";
                    break;
                case 9:
                    _valTexte = "J";
                    break;
                case 8:
                    _valTexte = "X";
                    break;
                case 7:
                    _valTexte = "9";
                    break;
                case 6:
                    _valTexte = "8";
                    break;
                case 5:
                    _valTexte = "7";
                    break;
                case 4:
                    _valTexte = "6";
                    break;
                case 3:
                    _valTexte = "5";
                    break;
                case 2:
                    _valTexte = "4";
                    break;
                case 1:
                    _valTexte = "3";
                    break;
                case 0:
                    _valTexte = "2";
                    break;
            }
        }

        private void SetCouleurCarte()
        {
            switch (_sorte)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
        }

    }
}
