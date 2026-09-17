using DPM235479_NguyenVanThang_Tuan02_Mediator_DP.Components;
using DPM235479_NguyenVanThang_Tuan02_Mediator_DP.Mediators;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();

            // Khởi tạo Mediator sẽ tự động thiết lập liên kết các Component
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();

            Console.ReadLine();
        }
    }
}
