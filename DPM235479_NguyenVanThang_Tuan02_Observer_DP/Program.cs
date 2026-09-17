using DPM235479_NguyenVanThang_Tuan02_Observer_DP.Observers;
using DPM235479_NguyenVanThang_Tuan02_Observer_DP.Subjects;

namespace DPM235479_NguyenVanThang_Tuan02_Observer_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var subject = new Subject();

            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            // Trigger updates
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            // Detach observer B and trigger again
            subject.Detach(observerB);

            subject.SomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
