using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Complex
{
    class Complex
    {
        public double re;//переменная - действительное число
        public double im;//переменная - мнимое число


        public Complex Plus(Complex x2)// сложение комплексных чисел
        {
            Complex x3 = new Complex
            {
                re = re + x2.re,
                im = im + x2.im
            };
            return x3;
        }


        public Complex Multi(Complex x2)//умножение комплексных чисел
        {
            Complex x3 = new Complex
            {
                re = re * x2.re - im * x2.im,
                im = re * x2.im + im * x2.re
            };
            return x3;
        }

        public Complex Substract(Complex x2)//вычитание комплексных чисел
        {
            Complex x3 = new Complex
            {
                re = re - x2.re,
                im = im - x2.im
            };
            return x3;
        }
    }
}