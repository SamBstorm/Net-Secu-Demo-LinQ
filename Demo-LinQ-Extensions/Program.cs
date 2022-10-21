namespace Demo_LinQ_Extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExtensionsString.CompteMots("Hello tous le monde! Bienvenu en LinQ!");

            "Hello tous le monde! Bienvenu en LinQ!".CompteMots();

            string texte = "Hello tous le monde! Bienvenu en LinQ!";
            texte.CompteMots();

            Console.WriteLine("Hello tous le monde! Bienvenu en LinQ!".CompteMots());

            int[] ints = new int[] { 1, 2, 3 };
            Console.WriteLine( ints.Compteur() );

        }
    }
}