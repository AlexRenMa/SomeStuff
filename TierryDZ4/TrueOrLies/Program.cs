using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrLies
{
    class Program
    {
        static void Main(string[] args)
        {
            TrueOrLies game = new TrueOrLies();
            game.GamePlay();

            Console.ReadKey();
        }
    }
}
