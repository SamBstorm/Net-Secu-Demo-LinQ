using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LinQ_TypeAnonyme
{
    internal class Personne
    {
        public string RegNat { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Genre { get; set; }

        public string DireBonjour() {
            return $"Bonjour, je suis {FirstName} {LastName}!";
        }
    }
}
