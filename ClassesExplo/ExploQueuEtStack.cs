using AtelierOO_101.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.ClassesExplo
{
    class ExploQueuEtStack
    {

        public static int JouerAvecStackEtQueue()
        {
            Console.Clear();
            Console.WriteLine(" Queue et Stact" );

            Stack<Carte> pioche = new();

            pioche.Push(new Carte(3, 10));
            pioche.Push(new Carte(1, 9));
            pioche.Push(new Carte(3, 3));
            pioche.Push(new Carte(1, 0));

            while( pioche.Count > 0)
            {
                Carte c = pioche.Pop();
                c.Afficher(0, 0);
                Console.ReadLine();
            }

            Queue<Carte> qCar = new();
            qCar.Enqueue(new Carte(3, 10));
            qCar.Enqueue(new Carte(1, 9));
            qCar.Enqueue(new Carte(3, 3));
            qCar.Enqueue(new Carte(1, 0));


            while (qCar.Count > 0)
            {
                Carte c = qCar.Dequeue();
                c.Afficher(0, 0);
                Console.ReadLine();
            }



            return 0;
        }
    }
}
