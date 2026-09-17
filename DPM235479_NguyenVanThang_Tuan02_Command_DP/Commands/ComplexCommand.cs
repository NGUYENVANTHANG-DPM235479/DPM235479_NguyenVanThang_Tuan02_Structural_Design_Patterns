using System;
using System.Windows.Input;
using DPM235479_NguyenVanThang_Tuan02_Command_DP.Receivers;


namespace RefactoringGuru.DesignPatterns.Command.Conceptual.Commands
{
    // However, some commands can delegate more complex operations to other
    // objects, called "receivers."
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        // Context data, required for launching the receiver's methods.
        private string _a;
        private string _b;

        // Complex commands can accept one or several receiver objects along
        // with any context data via the constructor.
        public ComplexCommand(Receiver receiver, string a, string b)
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        // Commands can delegate to any methods of a receiver.
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }

        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}