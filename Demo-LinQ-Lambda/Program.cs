namespace Demo_LinQ_Lambda
{
    delegate int myDel(int x);              //=>    Func<int, int>
    delegate bool compareDel(int x, int y); //=>    Func<int,int,bool>
    delegate void sansParamDel();           //=>    Action
    delegate void complexDel(int[] array);  //=>    Action<int[]>

    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> delegate_noLambda = delegate (int x) { return x * x; };
            Func<int, int> delegate_lambda = x => x * x;

            Func<int, int, bool> plusGrandQue_noLambda = delegate (int left, int rigth) { return left > rigth; };
            Func<int, int, bool> plusGrandQue_lambda = (left, rigth) => left > rigth;

            Action direBonjour_noLambda = delegate () { Console.WriteLine("Bonjour"); };
            Action direBonjour_lambda = () => Console.WriteLine("Bonjour");

            Action<int[]> afficheTableau_noLambda = delegate (int[] ints)
            {
                foreach (int i in ints)
                {
                    Console.WriteLine(i);
                }
            };
            Action<int[]> afficheTableau_lambda = (ints) => {
                foreach (int i in ints)
                {
                    Console.WriteLine(i);
                }
            };

            Func<int[], Func<int, bool>, int[]> filtre_numero = (ints, func) =>
            {
                List<int> result = new List<int>();
                foreach (int i in ints)
                {
                    if (func(i)) result.Add(i);
                }
                return result.ToArray();
            };

            int[] test_num = new int[] { 1, 2, 3, 4, 5, 6 };

            //Utilisation de lambda dans les paramètres pertmettent un changement de comportement radical de notre fonction "filtre_numero"

            int[] test_num1 = filtre_numero(test_num, (nb) => (nb % 2) != 0);
            int[] test_num2 = filtre_numero(test_num, (nb) => nb > 2);
            int[] test_num3 = filtre_numero(test_num, (nb) => nb == 5);
            int[] test_num4 = filtre_numero(test_num, (nb) => (nb % 2) == 0);
        }
    }
}