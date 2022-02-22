using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AtelierOO_101.ClassesExplo
{
    class ExploCouleur
    {
        static int _nbLignes;
        static int _nbCols;
        static int _nbCouleurs;
        public static int Epilepsie()
        {
            Console.WriteLine("Couleurs de la console");
            Console.Clear();

            _nbCols= Console.WindowWidth;
            _nbLignes = Console.WindowHeight;
            _nbCouleurs = Enum.GetValues(typeof(ConsoleColor)).Length;

            Console.WriteLine("{0} col par {1} lignes", _nbCols, _nbLignes);
            while (true)
            {
                for (int i = 0; i < _nbLignes; i++)
                {
                    Console.BackgroundColor = (ConsoleColor)(i % _nbCouleurs);
                    for (int j = 0; j < _nbCols; j++)
                    {
                        Console.Write(" ");
                    }
                    Thread.Sleep(5);
                    Console.SetCursorPosition(0, i);
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < _nbCols; i++)
                {
                    Console.BackgroundColor = (ConsoleColor)(i % _nbCouleurs);
                    for (int j = 0; j < _nbLignes; j++)
                    {
                        Console.Write(" ");
                        Console.SetCursorPosition(i, j);
                    }
                    Thread.Sleep(5);
                }
            }
            return 0;
        }

        public static int NuitEtoilee()
        {
            _nbCols = Console.WindowWidth;
            _nbLignes = Console.WindowHeight;
            _nbCouleurs = Enum.GetValues(typeof(ConsoleColor)).Length;
            Random Alea = new Random();
            int back;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int i = 0; i < 14931*16; i++)
            {
                int x = Alea.Next(_nbCols);
                int y = Alea.Next(_nbLignes);

                Console.SetCursorPosition(x, y);

                back = Alea.Next(_nbCouleurs);
                while(back == 0)
                    back = Alea.Next(_nbCouleurs);

                Console.BackgroundColor = (ConsoleColor)back;
                Console.Write(" ");
                //Thread.Sleep(1);
            }
            return 0;
        }

    }
}
