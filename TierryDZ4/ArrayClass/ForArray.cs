using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayClass
{
    class ForArray
    {
        private int[] Arr { get; set; }//поле-массив со свойствами


        public ForArray(int arrSize, int start, int step)//конструктор для создания массива с заданным размером, начальным значением и шагом
        {
            if (step == 0) throw new Exception("Создание пустого массива недопустимо.");
            Arr = new int[arrSize];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = start + step * i;
            }
        }

        public ForArray(int arrSize, int start, int step,int variant = 001)//конструктор для получения массива из файла(ввести 001 в аргументах при создании экземпляра, чтобы сработал именно он)
        {
            Arr = new int[arrSize];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = start + step * i;
            }

            ArrayWriter();
            ArrayReader();
        }

        public void ArrayWriter()//запись массива в файл
        {
            StreamWriter sw = new StreamWriter(@"D:\TestFolder\Array.txt");//создание экземпляра с указанием места
            sw.WriteLine(ToString());// метод, результат которого записываем
            Console.WriteLine("данные успешно записаны, нажмите клавишу для продолжения");
            sw.Close();//закрываем райтер, чтобы не жрал место и не мешал считывать
            Console.ReadKey();
        }

        public void ArrayReader()//считывание данных из файла и запись в массив
        {
            StreamReader sr = new StreamReader(@"D:\TestFolder\Array.txt");//создание экземпляра с указанием места
            string[] str = sr.ReadLine().Split(',');//записываем в начале в строчный массив с запятой в качестве разделителя
            Arr = new int[str.Length];//указываем размер массива как размер массива строчного
            for (int i = 0; i < Arr.Length; i++)
            {
                Int32.TryParse(str[i], out Arr[i]);//трайпарсим строчные значения в целочисленные
            }
            sr.Close();//закрываем ридер 
        }






        public int Sum//Свойство, возвращающее сумму чисел массива(расчёт производится в классе, вывод на экран нужно делать методом из класса)
        {             //Снаружи к свойству обратиться нельзя
            get
            {
                int sum = 0;
                for (int i = 0; i < Arr.Length; i++)
                {
                    sum += Arr[i];
                }
                return sum;
            }
        }

        public void Inverse()//инвертирование знаков чисел массива
        {
            Multi(-1);//умножаем все числа в массиве на -1
        }

        public void Multi(int mult)//умножаем каждое число в массиве на заданное.
        {
            for (int i = 0; i < Arr.Length; i++) Arr[i] *= mult;// умножаем каждое число на заданное
        }

        public int MaxCount//свойство для подсчёта максимальных элементов массива
        {
            get
            {
                int maxNum = Arr[0], maxCount = 1; // максимальное значение = первый элемент, количество = 1
                foreach (int i in Arr) // бежим по массиву - всё сделаем за 1 пробег
                {
                    if (i == maxNum) ++maxCount; // если встречаем ещё одно такое число, увеличиваем счётчик
                    else if (i > maxNum) // если встреченное число больше максимального, то именно оно - максимальное значение
                    {
                        maxNum = i; // запоминаем новое максимальное значение
                        maxCount = 1; // скидываем счётчик до 1 (впервые встретилось)
                    } // если число меньше - игнорируем
                }

                return maxCount;
            }
        }

        public void Print()//метод для вывода результатов расчёта
        {
            
            Console.WriteLine("Значения в данном массиве:");
            for (int i = 0; i < Arr.Length; i++)
            {               
                Console.Write($"{Arr[i]} ");
                System.Threading.Thread.Sleep(50);
            }
            Console.WriteLine($"\nСумма элементов массива:{Sum} \nКоличество максимальных значений:{MaxCount}");
            Console.WriteLine();
        }

        public override string ToString()//Предопределяем метод ToString() чтобы вернуть значения ввиде строки. Предопределяется он только так.
        {
            string str = "";
            for (int i = 1; i < Arr.Length; i++)
            {
                str += Arr[i];
                if (Arr.Length > i+1) str += ",";
            }
            return str;
        }


    }
}
