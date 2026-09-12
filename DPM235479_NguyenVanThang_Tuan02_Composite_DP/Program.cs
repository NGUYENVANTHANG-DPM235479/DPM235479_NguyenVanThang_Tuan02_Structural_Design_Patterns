using System;
using RefactoringGuru.DesignPatterns.Composite.Conceptual.Clients;
using RefactoringGuru.DesignPatterns.Composite.Conceptual.Components;
using RefactoringGuru.DesignPatterns.Composite.Conceptual.Composites;
using RefactoringGuru.DesignPatterns.Composite.Conceptual.Leaves;

namespace RefactoringGuru.DesignPatterns.Composite.Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            // This way the client code can support the simple leaf
            // components...
            Leaf leaf = new Leaf();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(leaf);

            // ...as well as the complex composites.
            Composites.Composite tree = new Composites.Composite();
            Composites.Composite branch1 = new Composites.Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composites.Composite branch2 = new Composites.Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Client: Now I've got a composite tree:");
            client.ClientCode(tree);

            Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            client.ClientCode2(tree, leaf);
        }
    }
}
