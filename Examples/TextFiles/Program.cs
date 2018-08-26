using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;// библиотека для работы с текстовыми файлами
namespace TextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\TestFolder\file.txt";//символ @ чтобы воспринимать как путь, а не escape-последовательности

            StreamReader sr = new StreamReader(path);//считывание текста из файла
            string line0;
            //while (!sr.EndOfStream)//выводим, пока не окажемся в конце файла
            //{
            //    line0 = sr.ReadLine();
            //    Console.WriteLine(line0);
            //}

            //while ((line0 = sr.ReadLine()) != null)//ещё один вариант вывода
            //{
            //    Console.WriteLine(line0);
            //}

            int[] arr = new int[0];
            int index = 0;
            while ((line0 = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line0);
                Array.Resize(ref arr, arr.Length + 1);
                arr[index++] = Convert.ToInt32(line0);
            }
            sr.Close();//закрываем ридер после того, как прочли файл, чтобы не отнимать ресурсы у системы.

            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }

            StreamWriter sw = new StreamWriter(@"D:\TestFolder\maxFile.txt",true);//Запись данных в файл(флажок true мы поставили,
            //чтобы файл не перезаписывался, а данные добавлялись в уже созданный файл с сохранённой информацией. По-умолчанию будет false)

            sw.WriteLine("Максимальное значение");//запись данных в буфер, для того, чтобы они оказались в файле, его надо закрыть
            sw.WriteLine(max);
            sw.Close();//закрываем файл
            Console.ReadLine();

        }
    }
}
