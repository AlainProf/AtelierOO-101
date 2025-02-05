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
            //Parcours();
            Ciel();


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
        public void Ciel()
        {
            int compteur = 0;
            int x;
            int y;

            while(compteur < 10)
            {
                for(y=0; y< Console.WindowHeight; y++)
                {
                    for(x=0; x< Console.WindowWidth; x++)
                    {
                        Console.BackgroundColor = (ConsoleColor)(y % 16);
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                    }
                }

                for (x=0; x < Console.WindowWidth; x++)
                {
                    for (y=0; y < Console.WindowHeight; y++)
                    {
                        Console.BackgroundColor = (ConsoleColor)(x % 16);
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                    }

                }
                compteur++;
            }
        }

        public void Parcours()
        {
            int limiteX = (Console.WindowWidth - 1);  
            int limiteY = (Console.WindowHeight - 1);

            while (true)
            {

                int x = 0;
                int y = 0;

                int iter = 0;
                while (iter <= Math.Floor((double)(limiteX / 2)) && iter <= Math.Floor((double)(limiteY / 2)))
                {
                    Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);

                    for (; x < limiteX - iter; x++)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                        Console.Write(' ');

                    }
                    Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                    for (; y < limiteY - iter; y++)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                        Console.Write(' ');
                    }

                    Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                    for (; x > iter; x--)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                        Console.Write(' ');
                    }
                    Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                    for (; y > iter; y--)
                    {
                        Console.SetCursorPosition(x, y); 
                        Console.BackgroundColor = (ConsoleColor)u.rdm.Next(0, 16);
                        Console.Write(' ');
                    }
                    iter++;
                    x = iter;
                    y = iter;
                    Thread.Sleep(1);
                }
            }
        }

        public void NoirEtBlanc()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;   

        }
    }
}
