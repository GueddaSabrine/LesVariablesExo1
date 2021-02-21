using System;

namespace LesVariablesExo1
{
    class Program
    {

        /*Créer deux variables et leur attribuer comme valeurs deux nombres entiers au choix.
        Afficher les valeurs de ces nombres dans la console dans deux phrases distinctes.
        Effectuer la somme des nombres puis afficher le résultat dans la console, dans une phrase.*/

        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            int b = 5;
            Console.WriteLine(b);
            int somme = a + b;
            Console.WriteLine("le résultat est " + somme);
        }
    }
}
