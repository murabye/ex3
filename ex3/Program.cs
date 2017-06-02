using System;
using MyLib;

namespace ex3
{
    internal class Program
    {
        private static void Main()
        {
            var x = Ask.RealNum("Введите координату x: ");
            var y = Ask.RealNum("Введите координату у: ");

            var ans = (y<=0 && y>=-2 || x<=y && y>=0 || -x<=y && y >= 0) && x<=1 && x<=1;

            Console.WriteLine("Ответ: "+ans);
            OC.Stay();
        }
    }
}
