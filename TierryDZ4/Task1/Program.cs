using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

    /// <summary>
    /// Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые
    ///    значения от –10 000 до 10 000 включительно.Написать программу, позволяющую найти и
    ///вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. В
    ///данной задаче под парой подразумевается два подряд идущих элемента массива
    /// </summary>
 
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[20];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0 && array[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"количество пар массива, делящихся на 3: {count}");

            Console.ReadLine();

        }
    }
}
