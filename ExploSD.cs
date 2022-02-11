using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierOO_101
{
    class ExploSD
    {
        public void ExploArray()
        {
            Console.Clear();
            Console.WriteLine("Les Array en C#");

            double[] tabNotes = new double[6];
            tabNotes[0] = 71;
            tabNotes[1] = 84;
            tabNotes[2] = 67;
            tabNotes[3] = 89;
            tabNotes[4] = 72;
            tabNotes[5] = 58;

            for(int i= 0; i<tabNotes.Length; i++)
            {
                Console.WriteLine("note {0}: {1}", i+1, tabNotes[i]);
            }

            double cumul = 0;
            foreach(int n in tabNotes)
            {
                cumul += n;
            }
            Console.WriteLine("Moyenne des notes: {0}", tabNotes.Average());
       }

       public void ArrayDInstances()
        {
            Console.Clear();
            Humain[] classe101 = new Humain[4];

            classe101[0] = new Humain();
            classe101[1] = new Humain(new DateTime(1999, 9, 9), "Patrice Dinelle");
            classe101[2] = new Humain(new DateTime(2004, 1, 9), "Ludovic Fournier");
            classe101[3] = new Humain(new DateTime(1964, 1, 9), "Pépère Gagnon", new DateTime(2022, 02,02));

            Humain h1 = new();
            DateTime dt = new();

            Humain[] classe102 = { h1, new Humain(), new Humain(dt, "Anthony Gratton") };

            Console.WriteLine("\n__________________________________\nTab brut:");
            foreach (Humain h in classe101)
            {
                h.Afficher();
            }

            Console.WriteLine("\n__________________________________\nTri par jeune au vieux:");

            Array.Sort(classe101, TriParJeune);
            foreach (Humain h in classe101)
            {
                h.Afficher();
            }
            Console.WriteLine("\n__________________________________\nTri par vieux au jeune:");

            Array.Sort(classe101, (ha,hb) => { return (int)(hb.Age() - ha.Age());  });

            foreach (Humain h in classe101)
            {
                h.Afficher();
            }
        }

        public static int TriParVieux(Humain ha, Humain hb)
        {
            return (int)(hb.Age() - ha.Age());
        }
        public static int TriParJeune(Humain ha, Humain hb)
        {
            return (int)(ha.Age() - hb.Age());
        }

        public void ListeDInstances()
        {
            Console.Clear();
            List<Humain> Idoles = new();

            Humain hAEnlever = new(new DateTime(1996, 6, 1), "Tom Holland");

            Idoles.Add(new Humain(new DateTime(2010,2,1), "Lodovic"));
            Idoles.Add(new Humain(new DateTime(1946, 1, 19), "Dolly Parton"));
            Idoles.Add(new Humain(new DateTime(1958, 8, 29), "Michael Jackson", new DateTime(2009, 6, 25)));
            Idoles.Add(hAEnlever);

            foreach(Humain h in Idoles)
            {
                h.Afficher();
            }

            Idoles.Sort(TrierParLonguerNom);

            Console.WriteLine("\n____________________________\n");
            foreach (Humain h in Idoles)
            {
                h.Afficher();
            }
            
            Idoles.Remove(hAEnlever);

            Console.WriteLine("\n____________________________\n"); 
            foreach (Humain h in Idoles)
            {
                h.Afficher();
            }


        }

        static int TrierParLonguerNom(Humain ha, Humain hb)
        {
            return ha.GetNom().Length - hb.GetNom().Length;
        }

    }
}
