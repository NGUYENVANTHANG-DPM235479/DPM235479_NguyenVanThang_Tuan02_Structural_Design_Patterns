using DPM235479_NguyenVanThang_Tuan02_Command_DP.Commands;
using DPM235479_NguyenVanThang_Tuan02_Command_DP.Invokers;
using DPM235479_NguyenVanThang_Tuan02_Command_DP.Receivers;
using RefactoringGuru.DesignPatterns.Command.Conceptual.Commands;

namespace DPM235479_NguyenVanThang_Tuan02_Command_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();

            // Gán lệnh SimpleCommand thực thi lúc bắt đầu
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));

            // Tạo Receiver và gán lệnh ComplexCommand thực thi lúc kết thúc
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            // Chạy Invoker
            invoker.DoSomethingImportant();
        }
    }
}
