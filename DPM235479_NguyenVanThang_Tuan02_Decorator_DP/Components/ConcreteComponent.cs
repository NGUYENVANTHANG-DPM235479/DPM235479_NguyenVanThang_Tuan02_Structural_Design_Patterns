namespace RefactoringGuru.DesignPatterns.Decorator.Conceptual.Components
{
    // Concrete Components provide default implementations of the operations.
    // There might be several variations of these classes.
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
