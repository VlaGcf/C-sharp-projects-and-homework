using System;

namespace Сумма_первых_n_членов_прогрессии
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.Read());
            int start = 10;
            int shag = 5;
            int sum = start;
            for (int i = 1; i < n; ++i)
            {
                sum += start + (n) * shag;
            }
        }
    }
}
