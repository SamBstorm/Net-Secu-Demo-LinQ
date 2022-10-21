using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LinQ_Extensions
{
    internal static class ExtensionsString
    {
        public static int CompteMots (this string texte)
        {
            return texte.Split(new char[] { ' ', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
