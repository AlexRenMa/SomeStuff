using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TierryDZ3
{
    /// <summary>
    /// Структура в отличие от класса не может иметь наследников и перегружаться, но хранится в стэке целиком. Класс хранится в куче.
    /// Лучше на практике применять именно классы, а не структуры.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Complex x1 = new Complex(2, 3);//создание экземпляра структуры с мнимым и действительным одного числа
            Complex x2 = new Complex(4, 5);//создание экземпляра структуры с с мнимым и действительным другого числа
            Complex x3 = new Complex();//создание экземпляра структуры в который будет помещён результат расчётов с двумя предыдущими
            Complex x4 = new Complex();//создание экземпляра структуры в который будет помещён результат расчётов с двумя предыдущими
            Complex x5 = new Complex();

            x3 = Complex.Plus(x1, x2);
            x4 = Complex.Mult(x1, x2);
            x5 = Complex.Substract(x1, x2);

            Console.WriteLine($"Результат сложения: re = {x3.re}; im = {x3.im}i" );
            Console.WriteLine($"Результат умножения: re = {x4.re}; im = {x4.im}i");
            Console.WriteLine($"Результат вычитания: re = {x5.re}; im = {x5.im}i");
            Console.ReadLine();
        }

        public struct Complex//создаём структуру для работы с комплексными числами
        {
            public double re;//поле с переменной действительного числа
            public double im;//после с переменной мнимого числа
            

            public Complex(double re, double im)//создаём конструктор для более простой записи и работы с переменными re и im
            {
                this.re = re;
                this.im = im;
            }

            static public Complex Plus(Complex X1,Complex X2)//метод сложения комп.чисел
            {
                return new Complex( X1.re + X2.re, X1.im + X2.im);
            }

            static public Complex Substract(Complex X1, Complex X2)//метод вычитания комп.чисел
            {
                return new Complex(X1.re - X2.re, X1.im - X2.im);
            }

            static public Complex Mult(Complex X1, Complex X2)//метод умножения комп.чисел
            {
                return new Complex(X1.re * X2.re - X1.im * X2.im, X1.re * X2.im + X2.re * X1.im);
            }

            
        }

             
       
    }
}

    

