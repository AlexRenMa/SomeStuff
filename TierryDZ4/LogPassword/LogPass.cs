using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogPassword
{
    class LogPass
    {
        string Login { get; set; }
        string Password { get; set; }
        string[] LogPassArr { get; set; }


        public LogPass(string Login, string Password)
        {
            
            this.Login = Login;
            this.Password = Password;
            PassCheck();
            InArray();
            Writer();
            Reader();
            Validate();

        }



        public void PassCheck()
        {
            int count1 = 0;
            int count2 = 0;
            foreach (char c in Password)
            {
                if (Char.IsUpper(c)) count1++;
                if (Char.IsDigit(c)) count2++;
            }
            if (count1 < 2) throw new Exception("В пароле должно быть не менее 2х заглавных букв и 1 цифры");
            else if (count2 < 1) throw new Exception("В пароле должно быть не менее 2х заглавных букв и 1 цифры");
        }

        void InArray()
        {
            LogPassArr = new string[2];
            LogPassArr[0] = Login;
            LogPassArr[1] = Password;
        }


        public override string ToString()
        {
            string str = LogPassArr[0] + " " + LogPassArr[1];
            return str;
        }

        public void Writer()
        {
            Console.WriteLine("Данные записываются в файл");
            string path = @"D:\TestFolder\Password.txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(ToString());
            sw.Close();
            Array.Clear(LogPassArr,0,2);
            Console.WriteLine("Данные записаны успешно");
        }

        public void Reader()
        {
            Console.WriteLine("Данные считываются из файла");
            StreamReader sr = new StreamReader(@"D:\TestFolder\Password.txt");
            string[] str = sr.ReadLine().Split(' ');
            LogPassArr = new string[str.Length];
            LogPassArr[0] = str[0];
            LogPassArr[1] = str[1];
        }

        public void Validate()
        {
            if (LogPassArr[0] == Login && LogPassArr[1] == Password) Console.WriteLine("Валидация прошла успешно! нажмите клавишу для продолжения");
            Console.ReadKey();
        }








    }
}
