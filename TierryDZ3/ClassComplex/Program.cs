using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            complex1.re = 2;
            complex1.im = 3;
            Complex complex2 = new Complex();
            complex2.re = 4;
            complex2.im = 5;
            Complex x1= new Complex();
            Complex x2 = new Complex();
            Complex x3 = new Complex();

            x1 = complex1.Plus(complex2);
            x2 = complex1.Multi(complex2);
            x3 = complex1.Substract(complex2);
            Console.WriteLine($"Результат сложения: re = {x1.re}; im = {x1.im}i");
            Console.WriteLine($"Результат умножения: re = {x2.re}; im = {x2.im}i");
            Console.WriteLine($"Результат вычитания: re = {x3.re}; im = {x3.im}i");
            Console.ReadKey();
        }
   
    }

    class Complex
    {
        public double re;
        public double im;

       
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex
            {
                re = re + x2.re,
                im = im + x2.im
            };
            return x3;
        }


        public Complex Multi(Complex x2)
        {
            Complex x3 = new Complex
            {
                re = re * x2.re - im * x2.im,
                im = re * x2.im + im * x2.re
            };
            return x3;
        }

        public Complex Substract(Complex x2)
        {
            Complex x3 = new Complex
            {
                re = re - x2.re,
                im = im - x2.im
            };
            return x3;
        }

        //public Complex(double re, double im) // Можно было бы сделать при помощи конструктора в более простой форме, как в структуре.
        //{
        //    this.re = re;
        //    this.im = im;
        //}
    }


    //class Complex
    //{
    //    public double re;
    //    public double im;

    //    public void Plus(Complex x2)
    //    {
    //        re = x2.re + re;
    //        im = x2.im + im;
    //    }

    //    public void Multi(Complex x2)
    //    {
    //        re = re * x2.re - im * x2.im;
    //        im = re * x2.im + im * x2.re;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine($"re = {re}; im = {im}i");
    //    }


    //}





}

