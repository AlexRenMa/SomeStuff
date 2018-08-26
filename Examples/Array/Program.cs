using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise;
            do
            {
                Menu();
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1": Array1(); break;
                    case "2": Array2(); break;
                    case "3": Array3(); break;
                    case "4": Array4(); break;
                    case "5": Array5(); break;
                }
            }
            while (choise != "0");
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Введите номер примера:");
            Console.WriteLine("1 - одномерный массив");
            Console.WriteLine("2 - двухмерный массив(матрица)");
            Console.WriteLine("3 - трёхмерный массив");
            Console.WriteLine("4 - массив массивов");
            Console.WriteLine("5 - работа с массивами при помощи методов");
        }
        #region одномерный массив
        static void Array1()//одномерный массив
        {
            Random rnd = new Random();// создание экземпляра генератора случайных чисел
            int n = Int32.Parse(Console.ReadLine());// переменная, задающая изначальный размер массива
            int[] array = new int[n];// создание нового массива с переменной, задающей размер
            Array.Resize(ref array, 15); // изменение размера массива, обращаемся по ссылке, через запятую задаём новый размер

            for (int i = 0; i < array.Length; i++)//заполнение массива случайными числами и вывод на экран
            {
                array[i] = rnd.Next(10);//заполнение
                Console.WriteLine($"array[{i}] = {array[i]}");//вывод
                System.Threading.Thread.Sleep(200);//дилей
            }
            Console.ReadLine();
        }
        #endregion

        #region двухмерный массив(матрица)
        static void Array2()//двухмерный массив
        {
            Random rnd = new Random();
            int[,] table = new int[4, 3];//создание матрицы 1 число - строка(по-вертикали), 2 - столбец(по-горизонтали)
            Console.WriteLine();
            Console.WriteLine($"table rank =  {table.Rank}");//мерность массива
            Console.WriteLine($"table getlength(0) =  {table.GetLength(0)}");//количество строк
            Console.WriteLine($"table getlength(1) =  {table.GetLength(1)}");//количество столбцов
            Console.WriteLine($"table length =  {table.Length}");//кол-во элементов во всём массиве
            Console.WriteLine();
            for (int i = 0; i < table.GetLength(0); i++)//заполнение и вывод двухмерного массива
            {
                for (int j = 0; j < table.GetLength(1); j++)// GetLength - индекс размерности
                {
                    table[i, j] = rnd.Next(10);
                    Console.Write($"{table[i, j]} ");
                    System.Threading.Thread.Sleep(200);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        #endregion

        #region трёхмерный массив
        static void Array3()//трёхмерный массив
        {
            int[,,] array3d = new int[3, 4, 5];
            Console.WriteLine($"array3d rank =  {array3d.Rank}");//мерность массива
            Console.WriteLine($"array3d getlength(0) =  {array3d.GetLength(0)}");//количество строк
            Console.WriteLine($"array3d getlength(1) =  {array3d.GetLength(1)}");//количество столбцов
            Console.WriteLine($"array3d getlength(2) =  {array3d.GetLength(2)}");//глубина ячеек
            Console.WriteLine($"array3d length =  {array3d.Length}");//кол-во элементов во всём массиве

            for (int i = 0; i < array3d.GetLength(0); i++)// строки
            {
                for (int j = 0; j < array3d.GetLength(1); j++)//столбцы
                {
                    for (int k = 0; k < array3d.GetLength(2); k++)//глубина 
                    {
                        Console.Write($"{array3d[i, j, k]}");
                        System.Threading.Thread.Sleep(200);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        #endregion

        #region массив массивов
        static void Array4()//массив массивов
        {
            //создаём массив массивов для данных, собранных за сутки с объекта. 24 часа, с 7 до 19 данные собираются раз в 2 минуты
            //в остальное время 2 раза в час. Для двухмерного массива потребовалось бы создавать строки одинаковой длины и это
            //отнимало бы лишнюю память, т.к. 28 из 30 ячеек бы не задействовались, а в зубчатом можно создать ровно то количество ячеек
            //в каждой строке, которое необходимо


            int[][] newTime = new int[24][];//массив массивов(зубчатый массив)

            Console.WriteLine($"newTime Length = {newTime.Length}");

            for (int i = 0; i < newTime.Length; i++)
            {
                newTime[i] = new int[i >= 7 && i < 19 ? 30 : 2];//заполняем с условиями через тернарную операцию

                //if (i >= 7 && i <= 19) newTime[i] = new int[30];// заполняем через оператора if
                //else newTime[i] = new int[2];
            }

            for (int i = 0; i < newTime.Length; i++)//пробегаемся по массиву массивов
            {
                for (int j = 0; j < newTime[i].Length; j++)//по конкретному массиву в массиве массивов
                {
                    Console.Write($"{newTime[i][j]} ");
                }
                Console.WriteLine();
            }

            foreach (int[] item in newTime)//то же самое, но уже через цикл foreach. 
            {
                foreach (int e in item)
                {
                    Console.Write($"{e} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        #endregion

        #region работа с массивами при помощи методов
        static void Array5()// применение методов для работы с массивами
        {
            int[] arr1 = new int[10];
            PrintArray(arr1);//вывод массива 1 через перегрузку
            Console.WriteLine();
            int[,] arr2 = new int[5,5];
            PrintArray(arr2);//вывод массива 2 через перегрузку
            Console.WriteLine();
            int[] arr3 = new int[4] {1,2,3,4};//предварительная инициализация массива
            Console.WriteLine(Sum(arr3));//вывод его суммы
            Console.WriteLine(Sum(new int[] { 1, 2, 3, 4, 5 }));//сразу вывод и инициализация в аргументах метода. 
            Console.WriteLine(Sum(1, 2, 3, 4, 5));// вызов и вывод без создания массива благодаря параметру метода params(!) 
            

            Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10);
            }

            PrintArray(array);

            Array.Reverse(array);//развернуть массив от конца к началу
            PrintArray(array);

            Array.Sort(array);//отсортировать массив
            PrintArray(array);

            Array.Clear(array, 0, 4);//очистить массив(от 9 до 4 индекса)

            Console.ReadLine();
        }
        #endregion

        #region методы для работы с массивами
        static void PrintArray(int[] list)//вывод массива на экран с перегрузками для разных типов массивов(ниже)
        {
            Console.WriteLine();
            foreach (int e in list)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
        }

        static void PrintArray(int[,] list)
        {
            Console.WriteLine();
            for (int i = 0; i < list.GetLength(0); i++)//строки(сверху вниз)
            {
                for (int j = 0; j < list.GetLength(1); j++)//столбцы(слева направо)
                {
                    Console.Write($"{list[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintArray(int[,,] list)
        {
            Console.WriteLine();
            for (int i = 0; i < list.GetLength(0); i++)// строки
            {
                for (int j = 0; j < list.GetLength(1); j++)//столбцы
                {
                    for (int k = 0; k < list.GetLength(2); k++)//глубина 
                    {
                        Console.Write($"{list[i, j, k]}");
                        System.Threading.Thread.Sleep(200);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void InitArray(out int[] list, int count, int minValue = 0, int maxValue = 10)//метод присваивания размера массива и значений
            //можно не указывать диапазон явно, т.к. он уже задан в аргументах, а можно указать в ручную. 
            //ссылка out чтобы присвоить значения конкретному массиву
        {
            Random r = new Random();
            Console.WriteLine();
            list = new int[count];
            for (int i = 0; i < count; i++)
            {
                list[i] = r.Next(minValue, maxValue);
            }
        }

        static int Sum(params int[] data) //подсчёт суммы значений в массиве, params - позволяет принимать ПЕРЕМЕННОЕ число аргументов
            //так же позволяет не инициализировать массив при вызове  метода в аргументах. При этом params в аргументах должен быть 
            //НА ПОСЛЕДНЕМ МЕСТЕ, потому что не известно в какой момент он будет заканчиваться. 
        {
            int res = 0;
            foreach  (int e in data)//перебираем элементы в массиве
            {
                res += e;//прибавляем в результат каждый элемент в массиве
            }
            return res;

        }
        #endregion
    }
}
