using System;

namespace Посчитать_количество_и_сумму_парных_чисел_от_1_до_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a+1; i++)
            {
                int s = i;
                if (s % 2 ==0)
                {
                    k += 1;
                }
            }
            Console.Write(k);
        }
    }
}
