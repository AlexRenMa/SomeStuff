using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrueOrLies
{
    class TrueOrLies
    {
        string[] Questions { get; set; }
        string[] Answers { get; set; }

        public TrueOrLies()//записываем методы в конструкторе, которые должны срабатывать при создании экземпляра класса по-умолчанию
        { 
            Writer();
            Reader();
        }

        public void Writer()//метод для записи данных в файл
        {
            StreamWriter sw = new StreamWriter(@"Questions.info");
            sw.WriteLine("Первая фотография была сделана в 20м веке?,нет,У лошадей 3 ноги?,нет,Автомобили летают?,нет,Гидра умеет регенерировать?,да,Бокс популярнее кикбоксинга?,да,Можно ли летать без крыльев?,да,Может ли человек год находиться в космосе?,да,Америка была основана 300 лет назад ?,нет");
            sw.Close();
        }

        public void Reader()//метод для считывания данных из файла и заполнение полей-массивов
        {
            StreamReader sr = new StreamReader(@"Questions.info");
            Questions = new string[8];
            Answers = new string[8];
            string[] all = sr.ReadLine().Split(',');//считывание данных в массив с использованием запятых в качестве разделителей
            sr.Close();

            int arr1 = 0;
            int arr2 = 0;
            for (int i = 0; i < all.Length; i++)
            {               
                if (i % 2 == 0)//если чётное - записывается в вопросы
                {
                    Questions[arr1] = all[i];
                    arr1++;
                }
                if (i % 2 != 0)//если нечётное - в ответы
                {
                    Answers[arr2] = all[i];
                    arr2++;
                }
            }
        }

        public void GamePlay()//метод геймплея
        {
            Random rnd = new Random();
            int points = 0;            
            int index = 0;
            int forAnswer = 0;
            int[] forIndex = new int[5];

            for (int i = 0; i < 5; i++)//если значение уже выпадало - заменяем на другое(сверяемся с массивом записанных ранее выпадавших значений)
            {
                index = rnd.Next(8);

                for (int j = 0; j < i; j++)
                {
                    if (forIndex[j] == index)
                    {
                        index = rnd.Next(8);
                        j = 0;
                    }
                }
                forIndex[i] = index;

                Console.WriteLine(Questions[index]);
                Console.WriteLine();
                Console.WriteLine("Введите ответ:");
                Console.WriteLine("1 - Да");
                Console.WriteLine("2 - Нет");
                int answer = Int32.Parse(Console.ReadLine());


                if (Answers[index] == "да") forAnswer = 1;
                else if (Answers[index] == "нет") forAnswer = 2;

                if (forAnswer == answer)
                {
                    Console.WriteLine("ЭТО ПРАВИЛЬНЫЙ ОТВЕТ!");
                    points++;
                }
                else
                {
                    Console.WriteLine("ЭТО НЕПРАВИЛЬНЫЙ ОТВЕТ!");
                }
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
            Console.WriteLine("Игра окончена! вы заработали " + points + " баллов!");
            Console.ReadKey();
        }          

    }
}
