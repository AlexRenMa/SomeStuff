using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassWithArray
{
    class Departament
    {
        private Worker[] workers;//приватный массив с объектами(рабочими)
        int index;//поле индекс массива
        public string Title { get; set; }//поле название департамента

        public Worker[] Workers//свойство-массив чтобы получать информацию о конкретном рабочем указывая индекс массива. 
        {
            get { return workers; } // возвращение значения вовне 
            set { workers = value; }// присвоение значения извне
        }

        public Worker this[int index]//возвращение значений через индексатор
        {
            get { return workers[index]; } // возвращение значения вовне 
            set { workers[index] = value; }// присвоение значения извне
        }

        public Departament()
        {
            index = -1;//индекс массива
            workers = new Worker[1];//новый массив с 2мя ячейками
        }

        public void Add(Worker Item)//метод добавления рабочих
        {
            index++;//индекс массива увеличивается
            if (index >= workers.Length)//если индекс превышает размеры массива - массив увеличивается в 2 раза
            {
                Array.Resize(ref workers, workers.Length * 2);
            }
            workers[index] = Item;//в индекс массива записывается рабочий
        }

        public string GetInfoDepartament()//метод получения информации о рабочих
        {
            string res = string.Empty;

            for (int i = 0; i <= index; i++)//перебор рабочих в массиве и вывод данных на экран
            {
                res += $"{workers[i].Info()} \n";//вывод данных о каждом конкретном рабочем в массиве
            }
            return res;
        }

        public Worker GetInfoWorker(int index)//метод для выдачи информации по конкретному рабочему
        {
            return workers[index];
        }
    }
   
}