using BuilderDemo;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPatterns.Facade
{
    public class SandwichFactory
    {
        private Dictionary<String, Type> sandwiches;

        public SandwichFactory()
        {
            LoadTypesICanRun();
        }

        private void LoadTypesICanRun()
        {
            sandwiches = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = typeof(SandwichFactory).GetTypeInfo().Assembly.GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterfaces() != null)
                {
                    sandwiches.Add(type.Name.ToLower(), type);
                }
            }
        }

        public SandwichBuilder CreateInstance(string sandwichName)
        {
            Type SandwichType = GetTypeToCreate(sandwichName);

            if (SandwichType == null)
            {
                return new NullSandwich();
            }

            return Activator.CreateInstance(SandwichType) as SandwichBuilder;
        }

        private Type GetTypeToCreate(string sandwichName)
        {
            foreach (var sandwich in sandwiches)
            {
                if (sandwich.Key.Contains(sandwichName))
                {
                    return sandwiches[sandwich.Key];
                }
            }

            return null;
        }

    }
}
