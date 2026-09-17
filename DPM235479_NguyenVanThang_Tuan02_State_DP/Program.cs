using DPM235479_NguyenVanThang_Tuan02_State_DP.Contexts;
using DPM235479_NguyenVanThang_Tuan02_State_DP.States;

namespace DPM235479_NguyenVanThang_Tuan02_State_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            // Bắt đầu với trạng thái A
            var context = new Context(new ConcreteStateA());

            // Gửi yêu cầu 1 (Trạng thái A xử lý, sau đó tự động chuyển sang Trạng thái B)
            context.Request1();

            // Gửi yêu cầu 2 (Lúc này Trạng thái B đang nắm quyền xử lý)
            context.Request2();

            Console.ReadLine();
        }
    }
}
