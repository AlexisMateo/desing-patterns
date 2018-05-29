using BuilderDemo;
using DesignPatterns.Facade;
using DesingPatterns.Factory;
using DesingPatterns.Observer;
using System;

namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Facade appFacade = new Facade();


            Console.WriteLine("What kind of sandwich you want?");
            string sandwichName = Console.ReadLine();

            SandwichMaker Sandwich = appFacade.SandwichMaker(sandwichName);

            Sandwich.BuildSandwich();
            Sandwich.GetSandwhich().Display();


            Console.ReadKey();
        }
    }
}