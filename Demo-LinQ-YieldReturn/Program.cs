namespace Demo_LinQ_YieldReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Delphine", "Paul", "Michel", "Jeremie", "Dimitry", "Thomas", "Benjamin", "Seif'", "Yves", "Ryan", "Jean" };

            //int[] caract_per_names = names.CompterCaracteres_sansYield();
            IEnumerable<int> caract_per_names = names.CompterCaracteres_avecYield();

            foreach (int nbCaract in caract_per_names)
            {
                Console.WriteLine(nbCaract);
            }
        }
    }
}