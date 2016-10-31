using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите кол элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            
            Console.WriteLine("Введите диапозон чисел: ");
            Console.ForegroundColor = ConsoleColor.Red;
            double st = Convert.ToDouble(Console.ReadLine());
            double end = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double[] array = new double[n];

            double epsilon = 1000;
            Random x = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < n; i++)
            {
                array[i] = ((double)x.Next(Convert.ToInt32(st * epsilon), Convert.ToInt32(end * epsilon))) / epsilon;
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();

            double max = array[0],
                min = array[0];
            for (int i = 0; i < n; i++)
            {
               min =  Math.Min(array[i], min);
               max =  Math.Max(array[i], max);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Max {0}", max);
            Console.WriteLine("Min {0}", min);
            Console.ReadLine();

        }
    }
}
