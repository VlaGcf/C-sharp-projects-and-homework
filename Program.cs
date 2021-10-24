using System;

namespace Вывести_таблицы_умножения_от_второй_до_шестой
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            for (i = 2; i < 7; i++)
            {
                for (j = 2; j<7; j++)
                    Console.Write(i*j);
                Console.WriteLine();
            }

        }
    }
}
