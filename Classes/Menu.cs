using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101.Classes
{
    class Menu
    {
        public string Nom { get; set; }

        public List<MenuItem> ListeItems { get; set; }

        public Menu()
        {
            ListeItems = new List<MenuItem>();
        }
        public void AjouterItem(MenuItem mi)
        {
            ListeItems.Add(mi);
        }

        public void Afficher()
        {
            Console.Clear();
            for (int i = 0; i < Nom.Length; i++)
            {
                Console.Write('-');
            }

            Console.WriteLine("\n{0}", Nom);

            for (int i = 0; i < Nom.Length; i++)
            {
                Console.Write('-');
            }
            Console.WriteLine("\n");

            if (ListeItems != null)
            {
                foreach (MenuItem menuItem in ListeItems)
                {
                    Console.WriteLine("\t" + menuItem.Touche + ": " + menuItem.Nom);
                }
            }
            else
            {
                Console.WriteLine("Aucun item dans le menu");
            }
        }
        public void SaisirOption()
        {
            ConsoleKeyInfo keyInfo;

            while((keyInfo = Console.ReadKey()).Key != ConsoleKey.Escape)
            {
                foreach(MenuItem mi in ListeItems)
                {
                    if ((char)keyInfo.Key == mi.Touche)
                    {
                        mi.Action();
                        Console.ReadKey();
                        Afficher();
                    }
                }
            }
        }
    }
}
