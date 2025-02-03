using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    internal class ExploEcran
    {
        Util u = new();
        public void Exec()
        {
            NoirEtBlanc();
            Parcours();


            /*u.Titre("Exploration de l'écran de la console C#");

            int largeur = Console.WindowWidth;  
            int hauteur = Console.WindowHeight;

            u.Sep($"largeur {largeur} X hauteur{hauteur}");


            Console.SetCursorPosition(largeur / 2, hauteur / 2);
            Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.Red;   
            Console.Write(" ");
            for(int i = 0; i < 16; i++)
            {
                Console.BackgroundColor = (ConsoleColor)i;
                Console.Write(" ");
            }
            */
            u.Pause();
            NoirEtBlanc();
        }

        public void Parcours()
        {
            Console.BackgroundColor = (ConsoleColor)8;
            int x = 0;
            int y = 0;

            for (; x < Console.WindowWidth-1; x++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
                Thread.Sleep(1);
            }

            for (; y < Console.WindowHeight - 1; y++)
            {
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = (ConsoleColor)2;
                Console.Write(' ');
                Thread.Sleep(1);
            }

            for (; x > 0; x--)
            {
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = (ConsoleColor)13;
                Console.Write(' ');
                Thread.Sleep(1);
            }
            for (; y > 0; y--)
            {
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = (ConsoleColor)5;
                Console.Write(' ');
                Thread.Sleep(1);
            }
        }

        public void NoirEtBlanc()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;   

        }
    }
}
