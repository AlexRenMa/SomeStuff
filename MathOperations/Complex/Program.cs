using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();// первое комплексное число
            complex1.re = 2;//действительное первого
            complex1.im = 3;//мнимое первого
            Complex complex2 = new Complex();// второе комплексное число
            complex2.re = 4;//действительное второго
            complex2.im = 5;//мнимое второго
            Complex Plus = new Complex();
            Complex Multi = new Complex();
            Complex Substract = new Complex();

            Plus = complex1.Plus(complex2);
            Multi = complex1.Multi(complex2);
            Substract = complex1.Substract(complex2);
            Console.WriteLine($"Результат сложения: re = {Plus.re}; im = {Plus.im}i");
            Console.WriteLine($"Результат умножения: re = {Multi.re}; im = {Multi.im}i");
            Console.WriteLine($"Результат вычитания: re = {Substract.re}; im = {Substract.im}i");
            Console.ReadKey();
        }
    }
}
