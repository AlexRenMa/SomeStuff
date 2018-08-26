using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublerGame
{
    class Doubler
    {
        int Current { get; set; }
        int Finish { get; set; }

        public Doubler(int value, int choise, int Current = 1)
        {
            this.Current = Current;

            if (choise == 1)
            {
                Random rnd = new Random();
                Finish = rnd.Next(value);
            }
            else if (choise == 2)
            {
                Finish = value;
            }
        }

        public int PlusOne()
        {
            return Current += 1;
        }

        public int MultiTwo()
        {
            return Current *= 2;
        }

        public int Reset()
        {
            return Current = 1;
        }

        public int GetCurrent
        {
            get
            {
                return Current;
            }
        }

        public int GetFinish
        {
            get
            {
                return Finish;
            }
        }
    }
}
