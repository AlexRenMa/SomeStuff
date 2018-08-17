using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            int nom1 = 0;
            int denom1 = 0;
            int full1 = 0;
            int nom2 = 0;
            int denom2 = 0;
            int full2 = 0;

            Console.WriteLine("Вас приветствует программа для операций с дробями!");
           // do
            //{
                Console.WriteLine("Введите числитель(1), знаменатель(2), множитель(3) первой дроби в заданном порядке:");
                try
                {
                    nom1 = Int32.Parse(Console.ReadLine());
                    denom1 = Int32.Parse(Console.ReadLine());
                    full1 = Int32.Parse(Console.ReadLine());
                }
                catch
                { Console.WriteLine("Введены неверные данные, необходимо вводить целые числа"); }

                Console.WriteLine("Введите числитель(1), знаменатель(2), множитель(3) второй дроби в заданном порядке:");
                try
                {
                    nom2 = Int32.Parse(Console.ReadLine());
                    denom2 = Int32.Parse(Console.ReadLine());
                    full2 = Int32.Parse(Console.ReadLine());
                }
                catch
                { Console.WriteLine("Введены неверные данные, необходимо вводить целые числа"); }
          //  } while ();

            Fractions fract1 = new Fractions(denom1, nom1, full1);//знаменатель, числитель, множитель
            Fractions fract2 = new Fractions(denom2, nom2, full2);
            Fractions fractPlus = new Fractions(0, 0, 0);
            Fractions fractMulti = new Fractions(0, 0, 0);
            Fractions fractSubstraction = new Fractions(0, 0, 0);
            Fractions fractDivide = new Fractions(0, 0, 0);

            Console.WriteLine("Выберите операцию, которую хотите провести с дробями:");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление");

            string choise = Console.ReadLine();

            switch (choise)
            {
                case "1": fractPlus = Fractions.Plus(fract1, fract2);
                          Console.WriteLine($"результат сложения дробей: {fractPlus.full}({fractPlus.nom}/{fractPlus.denom})"); break;
                case "2": fractSubstraction = Fractions.Substraction(fract1, fract2);
                          Console.WriteLine($"результат вычитания дробей: {fractSubstraction.full}({fractSubstraction.nom}/{fractSubstraction.denom})"); break;
                case "3": fractMulti = Fractions.Multi(fract1, fract2);
                          Console.WriteLine($"результат умножения дробей: {fractMulti.full}({fractMulti.nom}/{fractMulti.denom})"); break;
                case "4": fractDivide = Fractions.Divide(fract1, fract2);
                          Console.WriteLine($"результат деления дробей: {fractDivide.full}({fractDivide.nom}/{fractDivide.denom})"); break;
            }

            
            Console.ReadKey();
        }
    }
}
