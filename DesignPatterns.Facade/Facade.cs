using BuilderDemo;
using DesingPatterns.Factory;
using DesingPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public class Facade
    {
        public VehicleFactory VehicleFactory()
        {
            return  new VehicleFactory();
        }

        public ConcreteSubject SubjectObserver()
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();

            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "X"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Y"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Z"));

            return concreteSubject;
        }

        public SandwichMaker SandwichMaker(string sandwichName)
        {
            SandwichBuilder sandwichBuilder = new SandwichFactory().CreateInstance(sandwichName);

            SandwichMaker sandwichMaker = new SandwichMaker(sandwichBuilder);

            return sandwichMaker;
        }
    }
}
