using RefactoringGuru.DesignPatterns.Bridge.Conceptual.Interfaces;

namespace RefactoringGuru.DesignPatterns.Bridge.Conceptual.Abstractions
{
    // You can extend the Abstraction without changing the Implementation
    // classes.
    class ExtendedAbstraction : Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation)
        {
        }
        
        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }
}
