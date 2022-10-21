using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LinQ_YieldReturn
{
    internal static class ExetensionsArray
    {
        public static int[] CompterCaracteres_sansYield (this string[] tableau) {
            int[] result = new int[tableau.Length];
            for (int i = 0; i < tableau.Length; i++)
            {
                result[i] = tableau[i].Length;
            }
            return result;
        }

        public static IEnumerable<int> CompterCaracteres_avecYield(this string[] tableau)
        {

            for (int i = 0; i < tableau.Length; i++)
            {
                yield return tableau[i].Length;
            }
        }
    }
}
