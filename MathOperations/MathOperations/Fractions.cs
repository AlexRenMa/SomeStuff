using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Fractions
    {
        public int nom;//числитель
        public int denom;//знаменатель
        public int full;//множитель числителя

        static int resNom;//числитель - результат операции
        static int resDenom;//знаменатель - результат операции
        static int resFull;//множитель - результат операции


        public Fractions(int denom, int nom, int full)//конструктор для инициализации данных нового объекта. Класс может иметь несколько конструкторов,принимающих различные аргументы.
        {
            this.full = full;//отмечаем, что обращение идёт именно к полям класса. 
            this.nom = nom;
            this.denom = denom;
        }

        static int NOK(int denom1, int denom2)//вычисление НОК(наименьшего общего кратного) знаменателя дробей.
        {
            int newDenom = 0;
            if (denom1 < denom2)
            {
                do
                {
                    newDenom += denom1;
                }
                while (newDenom % denom2 != 0);
                // oneDenom = newDenom;
            }
            else
            {
                do
                {
                    newDenom += denom2;
                }
                while (newDenom % denom1 != 0);
                // oneDenom += newDenom;
            }
            return newDenom;
        }

        static int NomCoef(int nom, int denom, int resDenom)//Умножение числителя на коэфициент, полученный через деление общего знаменателя на частный.
        {
            int sum = nom * (resDenom / denom);
            return sum;
        }

        static int ForFull(int full1, int full2, int nom, int denom)//вычисление множителя для объекта сложения
        {
            int full = full1 + full2;
            while (nom > denom)
            {
                if (nom > denom)
                {
                    full++;
                    nom -= denom;
                }
            }
            return full;
        }

        static int ForNom(int nom, int denom)//уменьшение числителя
        {
            while (nom > denom)
            {
                if (nom > denom)
                {
                    nom -= denom;
                }
            }
            return nom;
        }

        static int ReductionNom(int nom, int denom)//сокращение числителя  
        {
            for (int i = 10; i > 1; i--)
            {
                if (nom % i == 0 && denom % i == 0)
                {
                    nom /= i;
                    denom /= i;
                }
            }
            return nom;
        }
        static int ReductionDenom(int nom, int denom)//сокращение знаменателя
        {
            for (int i = 10; i > 1; i--)
            {
                if (nom % i == 0 && denom % i == 0)
                {
                    nom /= i;
                    denom /= i;
                }
            }
            return denom;
        }

        static int ForDivide(int num1, int num2, int full)//Умножение множителя на числитель/знаменатель для объекта деления
        {
            for (int i = 0; i < full; i++)
            {
                num1 += num2;
            }
            return num1;
        }



        public static Fractions Plus(Fractions fract1, Fractions fract2)//метод, в котором за основу берётся класс, как переменная. 
        {
            resDenom = NOK(fract1.denom, fract2.denom);// записываем результат вычисления общего знаменателя
            resNom = ForNom(NomCoef(fract1.nom, fract1.denom, resDenom) + NomCoef(fract2.nom, fract2.denom, resDenom), resDenom);//записываем результат расчёта числителей  
            resFull = ForFull(fract1.full, fract2.full, NomCoef(fract1.nom, fract1.denom, resDenom) + NomCoef(fract2.nom, fract2.denom, resDenom), resDenom);//результат расчёта множителя                  

            return new Fractions(ReductionDenom(resNom, resDenom), ReductionNom(resNom, resDenom), resFull);//Экземпляр класса с заданными параметрами. (можно было сразу с рассчётом на месте каждого аргумента). 
        }

        public static Fractions Multi(Fractions fract1, Fractions fract2)
        {
            resNom = (fract1.nom + (fract1.full * fract1.denom)) * (fract2.nom + (fract2.full * fract2.denom));//записываем результат вычисления числителя
            resDenom = fract1.denom * fract2.denom;//записываем результат вычисления знаменателя
            resFull = resNom / resDenom;//записываем множитель
            resNom = ForNom(resNom, resDenom);


            return new Fractions(ReductionDenom(resNom, resDenom), ReductionNom(resNom, resDenom), resFull);
        }

        public static Fractions Substraction(Fractions fract1, Fractions fract2)//объект для вычитания дробей
        {
            resDenom = NOK(fract1.denom, fract2.denom);
            resNom = ForNom(NomCoef(fract1.nom, fract1.denom, resDenom) - NomCoef(fract2.nom, fract2.denom, resDenom), resDenom);
            resFull = fract1.full - fract2.full;

            if (resFull > 0 && resNom <= 0)
            {
                resNom += resDenom;
                resFull -= 1;
            }

            return new Fractions(ReductionDenom(resNom, resDenom), ReductionNom(resNom, resDenom), resFull);
        }

        public static Fractions Divide(Fractions fract1, Fractions fract2)//объект для деления дробей
        {
            resNom = ForDivide(fract1.nom, fract1.denom, fract1.full) * fract2.denom;//складываем числитель 1 помноженный на множитель 1 со знаменателем 2
            resDenom = fract1.denom * ForDivide(fract2.nom, fract2.denom, fract2.full);//складываем знаменатель 1  с числителем 2 помноженным на множитель 2
            resNom = ForNom(resNom, resDenom);
            resFull = resNom / resDenom;

            return new Fractions(ReductionDenom(resNom, resDenom), ReductionNom(resNom, resDenom), resFull);
        }

    }
}
