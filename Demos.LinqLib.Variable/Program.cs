using System;
using System.Collections.Generic;

namespace Demos.LinqLib.Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> concats = new List<Contact>{
                new Contact { Nom = "Legrain", Prenom = "Samuel", Email = "samuel.legrain@bstorm.be"},
                new Contact { Nom = "Baudoux", Prenom = "Loïc", Email = "loic.baudoux@bstorm.be"},
                new Contact { Nom = "Morre", Prenom = "Thierry", Email = "thierry.morre@cognitic.be"},
                new Contact { Nom = "Person", Prenom = "Michael", Email = "michael.person@cognitic.be"},
            } ;

            var person = new { Nom = "Thomas", Prenom = "Laure" };
            var mail = new { Nom = "Thomas", Email = "laure.thomas@gmail.com" };

            Console.WriteLine($"Le nom de cette personne est  {person.Nom}");

        }
    }
}
