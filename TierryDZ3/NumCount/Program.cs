using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int x = 0;
            Console.WriteLine("Вводите целые числа:");
            do
            {
                x = TryCatch(x);
                if (x % 2 != 0 && x > 0) count += x;
            }
            while (x != 0);

            Console.WriteLine($"сумма введённых нечётных положительных чисел:{count}");
            Console.ReadKey();
        }

        static int TryCatch(int x)
        {
            try
            {
                x = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Некорректный ввод, попробуйте ещё раз:");
                x = -1;
            }
            return x;
        }
    

    }
}
