using DPM235479_NguyenVanThang_Tuan02_Strategy_DP.Contexts;
using DPM235479_NguyenVanThang_Tuan02_Strategy_DP.Strategies;

namespace DPM235479_NguyenVanThang_Tuan02_Strategy_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
