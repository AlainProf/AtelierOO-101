namespace AtelierOO_101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atelier de dev de proj OO pour le groupe 2C6-101!");

            AfficherMenu();
        }

        static void AfficherMenu()
        {
            Console.WriteLine("F: outils Financiers ");
            Console.WriteLine("H: Humanité");
            Console.WriteLine("Q: Quitter");
        }
    }
}
