using System;
using System.Collections.Generic;
using DPM235479_NguyenVanThang_Tuan02_Visitor_DP.Clients;
using DPM235479_NguyenVanThang_Tuan02_Visitor_DP.Components;
using DPM235479_NguyenVanThang_Tuan02_Visitor_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Visitor_DP.Visitors;

namespace DPM235479_NguyenVanThang_Tuan02_Visitor_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>
            {
                new ConcreteComponentA(),
                new ConcreteComponentB()
            };

            Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
            var visitor1 = new ConcreteVisitor1();
            Client.ClientCode(components, visitor1);

            Console.WriteLine();

            Console.WriteLine("It allows the same client code to work with different types of visitors:");
            var visitor2 = new ConcreteVisitor2();
            Client.ClientCode(components, visitor2);

            Console.ReadLine();
        }
    }
}