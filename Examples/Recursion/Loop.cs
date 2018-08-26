using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Loop
    {
        int Sum { get; set; }

       
        void Loop1(int count = 0 )//рекурсия, подсчитывающая сумму чисел от 1 до 1000, которые делятся на 3 или на 5
        {
            if (count != 1000)
            {
                if (count % 3 == 0 || count % 5 == 0)
                {
                    Sum += count;                  
                }
                Loop1(count + 1);
            }
            if(count == 1000)Console.WriteLine($"Сумма чисел: {Sum}");
        }

        void Loop2(int fromNum = 1)
        {
            int temp = 0;
            if (fromNum != 40)
            {
                temp += fromNum;
                Sum += temp;
                Loop2(fromNum + temp);
                Console.WriteLine(temp);
            }
            if (fromNum >= 40) Console.WriteLine(Sum);
        }

        public void Print()
        {
            //Loop1();
            Loop2();
        }
            
    }
}
