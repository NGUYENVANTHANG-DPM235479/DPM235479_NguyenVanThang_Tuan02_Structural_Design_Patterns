using System;
using RefactoringGuru.DesignPatterns.Proxy.Conceptual.RealSubjects;
using RefactoringGuru.DesignPatterns.Proxy.Conceptual.Proxies;
using RefactoringGuru.DesignPatterns.Proxy.Conceptual.Clients;

namespace RefactoringGuru.DesignPatterns.Proxy.Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            
            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Proxies.Proxy proxy = new Proxies.Proxy(realSubject);
            client.ClientCode(proxy);
        }
    }
}
