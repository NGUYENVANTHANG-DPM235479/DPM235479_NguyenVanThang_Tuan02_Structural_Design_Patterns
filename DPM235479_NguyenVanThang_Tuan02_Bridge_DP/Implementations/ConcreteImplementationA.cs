using RefactoringGuru.DesignPatterns.Bridge.Conceptual.Interfaces;

namespace RefactoringGuru.DesignPatterns.Bridge.Conceptual.Implementations
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}
