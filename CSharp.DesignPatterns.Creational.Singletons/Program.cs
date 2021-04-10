using models;
using System;

namespace CSharp.DesignPatterns.Creational.Singletons
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            var result = s1 == s2 ? "singleton good": "singleton failed :(";
            // vemos que solo se creo un singleton a pesar de intentar crear otra
            Console.WriteLine(result);
        }
    }
}
