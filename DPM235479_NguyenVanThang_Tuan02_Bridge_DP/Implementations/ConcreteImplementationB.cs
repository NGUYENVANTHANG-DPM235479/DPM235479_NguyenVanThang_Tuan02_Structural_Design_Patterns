using RefactoringGuru.DesignPatterns.Bridge.Conceptual.Interfaces;

namespace RefactoringGuru.DesignPatterns.Bridge.Conceptual.Implementations
{
    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }
}
