using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Departament it = new Departament() { Title = "IT" };//создание нового отдела с записью названия в поле Title

            it.Add(new Worker() { Name = "Tommy", Age = 30, Salary = 1000 });//добавление новых рабочих
            it.Add(new Worker() { Name = "Timmy", Age = 20, Salary = 1000 });
            it.Add(new Worker() { Name = "Tammy", Age = 40, Salary = 1000 });

            Console.WriteLine(it.GetInfoDepartament());//вывод информации об отделе

            var data1 = it.GetInfoWorker(1);//запись информации из метода
            var data2 = it.Workers[1];//запись информации из свойства-массива
            Console.WriteLine(data1.Info());
            Console.WriteLine(data2.Info());

            Worker[] workers = new Worker[]//добавление новых рабочих через свойство-массив
            {
                 new Worker() { Name = "Tommy", Age = 31, Salary = 1500 },
                 new Worker() { Name = "Timmy", Age = 22, Salary = 1500 },
                 new Worker() { Name = "Tammy", Age = 43, Salary = 1500 }
            };
            it.Workers = workers; //запись рабочих


            data1 = it.GetInfoWorker(1);//запись информации из метода
            data2 = it.Workers[1];//запись информации из свойства-массива
            Console.WriteLine(data1.Info());
            Console.WriteLine(data2.Info());

            it[0] = new Worker() { Name = "Timmy", Age = 34, Salary = 3500 };//запись данных в массив класса через индексатор
            it[1] = new Worker() { Name = "Tommy", Age = 32, Salary = 2500 };//запись данных в массив класса через индексатор

            data1 = it[0];//запись данных из массива класса в переменную
            data2 = it[1];//запись данных из массива класса в переменную
            Console.WriteLine(data1.Info());
            Console.WriteLine(data2.Info());

            Console.ReadLine();


        }
    }
}
