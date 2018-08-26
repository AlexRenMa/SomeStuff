using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchColor("Вас приветствует игра <<Удвоитель>>!\n");
            Start();
        }

        static void Start()
        {
            int value = 0;
            int choise = 0;
            bool flag = false;
            ConsoleKey pressedKey;
            do
            {
                Console.WriteLine("Если Вы хотите, чтобы число загадал робот, введите 1");
                Console.WriteLine("Если Вы хотите, задать число самостоятельно, введите 2");
                pressedKey = Console.ReadKey().Key;
                Console.Clear();
                
                switch (pressedKey)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Введите максимальное число, до которого может загадывать робот:");
                        while (!Int32.TryParse(Console.ReadLine(), out value)) Console.WriteLine("Ошибка. Введите целое число:"); choise = 1; break;

                    case ConsoleKey.D2:
                        Console.WriteLine("Введите число самостоятельно:");
                        while (!Int32.TryParse(Console.ReadLine(), out value)) Console.WriteLine("Ошибка. Введите целое число:"); choise = 2; break;
                }
                if (pressedKey == ConsoleKey.D1 || pressedKey == ConsoleKey.D2) flag = true;
            } while (!flag);


            Console.WriteLine("Теперь Ваша задача управляя роботом дойти до заданного числа за максимально короткое количество шагов!");

            DoublerGameIn(value, choise);
        }

        static void DoublerGameIn(int value, int choise)
        {
            Doubler doubler = new Doubler(value, choise);
            int stepCount = 0;
            ConsoleKey pressedKey;

            do
            {
                Console.Clear();

                SwitchColor("_________________________________________________________________________________________");
                SwitchColor($"Число, которого необходимо достичь:{doubler.GetFinish},\tЗаданное число:{doubler.GetCurrent},\t Шаг:{stepCount}");
                SwitchColor("_________________________________________________________________________________________");

                Menu();
                pressedKey = Console.ReadKey().Key;
                switch (pressedKey)
                {
                    case ConsoleKey.D1: doubler.PlusOne(); stepCount++; break;
                    case ConsoleKey.D2: doubler.MultiTwo(); stepCount++; break;
                    case ConsoleKey.D3: doubler.Reset(); stepCount++; break;
                    case ConsoleKey.D9: Exit();break;
                }
                if (doubler.GetCurrent > doubler.GetFinish)
                {
                    SwitchColor("\nВаше число стало больше необходимого, игра окончена!");
                    Exit();
                }
            } while (doubler.GetCurrent != doubler.GetFinish);

            Console.Clear();
            SwitchColor($"Поздравляем! Вы выиграли за {stepCount} шагов!");
            SwitchColor($"\n\nЕсли Вы хотите попробовать ещё раз, нажмите 1, если хотите выйти - нажмите 2");

            pressedKey = Console.ReadKey().Key;
            if (pressedKey == ConsoleKey.D1) Start();
            else if (pressedKey == ConsoleKey.D2) Exit();
        }

        static void Menu()
        {
            Console.WriteLine("Нажмите одну из клавиш для выполнения действия:\n");
            Console.WriteLine("1 -- прибавить к числу 1");
            Console.WriteLine("2 -- умножить число на 2");
            Console.WriteLine("3 -- сбросить число до 1");
            Console.WriteLine("\n9 -- выйти из игры");
        }

        static void Exit()
        {
            Console.Clear();
            SwitchColor("Выход из игры...");
            System.Threading.Thread.Sleep(4000);
            Environment.Exit(0);
        }

        static void SwitchColor(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
