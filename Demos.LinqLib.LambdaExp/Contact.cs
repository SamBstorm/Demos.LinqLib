using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.LinqLib.LambdaExp
{
    class Contact
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }

        public void Saluer()
        {
            Console.WriteLine($"Bonjour, je m'appelle {Prenom} {Nom}.");
        }
    }
}
