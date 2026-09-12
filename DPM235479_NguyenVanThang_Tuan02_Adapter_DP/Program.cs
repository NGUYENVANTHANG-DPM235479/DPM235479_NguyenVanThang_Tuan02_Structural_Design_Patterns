using System;
using RefactoringGuru.DesignPatterns.Adapter.Conceptual.Adapters;
using RefactoringGuru.DesignPatterns.Adapter.Conceptual.Interfaces;
using RefactoringGuru.DesignPatterns.Adapter.Conceptual.Models;

namespace RefactoringGuru.DesignPatterns.Adapter.Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapters.Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
