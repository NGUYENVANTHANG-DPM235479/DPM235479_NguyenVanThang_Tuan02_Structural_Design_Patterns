using System;
using RefactoringGuru.DesignPatterns.Decorator.Conceptual.Components;

namespace RefactoringGuru.DesignPatterns.Decorator.Conceptual.Clients
{
    public class Client
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
