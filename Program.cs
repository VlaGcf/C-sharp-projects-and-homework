using System;

namespace Вывести_на_экран_прямоугольный_треугольник
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int i = 0; 
            int j=0;
            for (i = 0; i <m+1; i++)
            {
                for (j = 0; j < i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
    }
}
