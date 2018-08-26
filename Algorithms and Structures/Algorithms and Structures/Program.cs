using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Structures
{
    /// <summary>
    /// Связный список
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Node n1 = new Node(12);
            Node n2 = new Node(55);
            Node n3 = new Node(100);
            
            //n1.Next = n2;
            //n2.Next = n3;
            
            list.AddInTail(n1);
            list.AddInTail(n2);
            list.AddInTail(n3);
            list.AddInTail(new Node(128));            
            list.Print();
            //int temp = list.Find(55).Value;
            //Console.WriteLine(temp);
            
            Console.WriteLine();
            list.Print();

            Console.ReadKey();
        }
    }
}
