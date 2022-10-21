using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LinQ_Extensions
{
    internal static class ExtentionsArray
    {
        public static int Compteur<T>(this T[] array)
        {
            return array.Length;
        }
    }
}
