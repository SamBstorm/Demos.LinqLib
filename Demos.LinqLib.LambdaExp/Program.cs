using System;

namespace Demos.LinqLib.LambdaExp
{
    public delegate void ActionCustom();

    public delegate string FuncCustom(string name);

    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact { Nom = "Legrain", Prenom = "Samuel", Email = "samuel.legrain@bstorm.be" };

            c.Saluer();

            ActionCustom action = c.Saluer;
            action();

            ActionCustom actionAnonym = delegate () { Console.WriteLine("Test"); };
            actionAnonym();

            ActionCustom actionLambda = () => Console.WriteLine("Lambda Working!");
            actionLambda();

            FuncCustom funcAnonym = delegate (string name) { return $"Bonjour {name}"; };
            Console.WriteLine( funcAnonym("Toto") );

            FuncCustom funcLambda = name => $"Bonjour {name}";
            Console.WriteLine( funcLambda("Titi") );

            CustomWriteLine(() => "Salut je suis une fonction sans class ni variable");

            CustomWriteLine(
                () => {
                    string result = "";
                    for (int i = 0; i < 10; i++)
                    {
                        result += i;
                    }
                    return result; 
                }
            );

        }

        static void CustomWriteLine(Func<string> function)
        {
            Console.WriteLine(function());
        }
    }
}
