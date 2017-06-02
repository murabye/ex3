using System;
using MyLib;

namespace ex3
{
    internal class Program
    {
        private static void Main()
        {
            while (true)
            {
                var x = Ask.RealNum("Введите координату x: ");
                var y = Ask.RealNum("Введите координату у: ");
                    
                var ans = (y<=0 && y>=-2 || Math.Abs(x)>=y && y>=0) && x<=1 && x>=-1;

                Console.WriteLine("Ответ: "+ans);
                OC.Stay();
            }
        }
    }
}
