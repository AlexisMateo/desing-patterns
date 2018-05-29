using System;
using BuilderDemo;

namespace DesignPatterns.Facade
{
    internal class NullSandwich : SandwichBuilder
    {
        public override void AddCondiments()
        {
            Console.WriteLine("This Sandwich doesnt exit to add codiments");
        }

        public override void ApplyMeatAndCheese()
        {
            Console.WriteLine("This Sandwich doesnt exit to apply meat and cheese");
        }

        public override void ApplyVegetables()
        {
            Console.WriteLine("This Sandwich doesnt exit to apply vegetables");
        }

        public override void PrepareBread()
        {
            Console.WriteLine("This Sandwich doesnt exit tp prepare bread");
        }
    }
}