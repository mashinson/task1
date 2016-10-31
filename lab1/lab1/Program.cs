using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 0,
                x2 = 0,
                x3 = 0,
                x4 = 0,
                x5 = 0;
            Console.WriteLine("Введите 5 чисел: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            x3 = Convert.ToDouble(Console.ReadLine());
            x4 = Convert.ToDouble(Console.ReadLine());
            x5 = Convert.ToDouble(Console.ReadLine());

            double max = x1,
                min = x1;

            // max
            if (x2 > max) max = x2;
            if (x3 > max) max = x3;
            if (x4 > max) max = x4;
            if (x5 > max) max = x5;
            Console.WriteLine("Max из пяти чисел: {0} ", max);

            // min
            if (x2 < min) min = x2;
            if (x3 < min) min = x3;
            if (x4 < min) min = x4;
            if (x5 < min) min = x5;
            Console.WriteLine("Min из пяти чисел: {0} ", min);

            Console.ReadLine();
        }
    }
}
