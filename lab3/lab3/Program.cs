using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Введите диапозон UniCode: ");
            int st = Convert.ToInt32(Console.ReadLine());
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введите размер таблицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (n * m < (end - st)) Console.WriteLine("Недостаточно места для вывода");
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                char ch;
                int k = st;
                while (k < end)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            ch = (char)k;
                            Console.Write("\t{0}", ch);

                            k += 1;
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
