using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise;
            do//обновление меню и свитча
            {
                Menu();
                choise = Console.ReadLine();
                Console.Clear();
                switch (choise)
                {
                    case "1": SimpleArray(); break;
                    case "2": ReaderArray(); break;
                    case "3": ForMatrixArray(); break;

                }

            }while (choise != "0") ; 

            Console.ReadKey();
        }

        static void Menu()
        {
            Console.WriteLine("Программа для создания и операций с одномерным массивом.");
            Console.WriteLine("Введите вариант работы с массивом:");
            Console.WriteLine("1 - введение данных в консоли");
            Console.WriteLine("2 - считывание данных из файла");
            Console.WriteLine("3 - работа с матрицей");
        }

        static void SimpleArray()
        {
            ForArray array1 = new ForArray(10, 1, 3);//создаём экземпляр класса с заданными параметрами(размер массива,начальное значение,шаг)
            ForArray array2 = new ForArray(20, 2, 8);
            array1.Print();//выводим 1й массив
            array2.Multi(5);//умножаем значения во 2м массиве на 5
            array2.Print();//выводим 2й массив
            array1.Inverse();//инвертируем значения в 1м массиве
            array1.Print();//выводим 1й массив
            Console.ReadKey();
            Console.Clear();
        }

        static void ReaderArray()
        {            
            ForArray array1 = new ForArray(10, 1, 3, 001);// 001 - ключ для вызова методов с записью и считыванием
            array1.Print();
            Console.ReadKey();
            Console.Clear();
        }

        static void ForMatrixArray()
        {
            MatrixArray matrix1 = new MatrixArray(5, 5, 1, 5);//задаём размер(количество строк, длина столбцов) и диапазон значений, которыми заполнится матрица
            matrix1.Print();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
