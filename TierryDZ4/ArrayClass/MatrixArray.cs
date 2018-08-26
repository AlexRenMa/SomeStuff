using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class MatrixArray
    {
        int[,] Matrix { get; set; }

        public MatrixArray(int size1,int size2, int min, int max)
        {
            Random rnd = new Random();
            Matrix = new int[size1,size2];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Matrix[i,j] = rnd.Next(min, max);
                }
            }
        }

        int Sum()//метод для поиска суммы чисел матрицы
        {           
            int sum = 0;
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    sum += Matrix[i, j];
                }
            }
            return sum;   
        }

        int MinValue//свойство для поиска мин.числа
        {
            get
            {
                int min = Matrix[0, 0];
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        if (Matrix[i, j] < min) min = Matrix[i, j];
                    }
                }
                return min;
            }
        }

        int MaxValue// свойство для поиска макс.числа
        {
            get
            {
                int max = Matrix[0, 0];
                for (int i = 0; i < Matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix.GetLength(1); j++)
                    {
                        if (Matrix[i, j] > max) max = Matrix[i, j];
                    }
                }
                return max;
            }
        }

        public void IndexOfMax(ref int index0, ref int index1)//ищем индекс макс.числа, передаём по ссылкам в переменные в другом методе
        {
            int max = Matrix[0, 0];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    if (Matrix[i, j] > max) max = Matrix[i, j];
                    if (Matrix[i, j] == max)
                    {
                        index0 = i;
                        index1 = j;
                    }
                }
            }
        }





        public void Print()//метод, выводящий данные в консоль
        {
            int index0 = 0;
            int index1 = 0;
            IndexOfMax(ref index0, ref index1);
            Console.WriteLine("Данные в матрице:");
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    System.Threading.Thread.Sleep(50);
                    Console.Write($"{Matrix[i, j]} ");
                }
            }            
            Console.WriteLine($"\n\nСумма чисел матрицы: {Sum()}");
            System.Threading.Thread.Sleep(75);
            Console.WriteLine($"Минимальное число в матрице: {MinValue}");
            System.Threading.Thread.Sleep(75);
            Console.WriteLine($"Максимальное число в матрице: {MaxValue}");
            System.Threading.Thread.Sleep(75);
            Console.WriteLine($"Индекс максимального числа в матрице: {index0},{index1}");
        }



    }
}
