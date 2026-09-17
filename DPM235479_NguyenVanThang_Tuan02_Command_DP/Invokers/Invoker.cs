
using DPM235479_NguyenVanThang_Tuan02_Command_DP.Interfaces;
using System;
using System.Windows.Input;

namespace DPM235479_NguyenVanThang_Tuan02_Command_DP.Invokers
{
    public class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if (this._onStart != null)
            {
                this._onStart.Execute();
            }

            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if (this._onFinish != null)
            {
                this._onFinish.Execute();
            }
        }
    }
}