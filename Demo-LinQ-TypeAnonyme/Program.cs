namespace Demo_LinQ_TypeAnonyme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne moi = new Personne() {
                RegNat = "123456-123-12",
                LastName = "Legrain",
                FirstName = "Samuel",
                Email = "samuel.legrain@bstorm.be",
                Genre = "Male",
                Telephone = "080033800"
            };

            Console.WriteLine($"Bonjour {moi.LastName}, vous êtes un ${moi.Genre}.");

            var moi_simple = new { 
                moi.LastName,
                moi.FirstName
                //Attention: Pas possible de récupérer une méthode dans un type anonyme
                //moi.DireBonjour
            };

            var moi_administratif = new
            {
                RegistreNationnal = moi.RegNat,
                moi.Genre
            };

            Console.WriteLine($"Bonjour {moi_simple.LastName}, vous êtes un ${moi_administratif.Genre}.");

            //Attention: Une propriété d'un type anonyme est en lecture seule
            //moi_simple.LastName = "Toto";

        }
    }
}