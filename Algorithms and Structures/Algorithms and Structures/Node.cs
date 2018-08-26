using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Structures
{
    class Node
    {
        public int Value;//значение, хранящееся в узле
        public Node Next;//указатель на следующий узел

        public Node(int Value, Node Next = null)//конструктор для работы с узлом извне
        {
            this.Value = Value;
            this.Next = Next;
        }
    }
}
