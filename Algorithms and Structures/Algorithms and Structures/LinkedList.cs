using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Structures
{
    class LinkedList
    {
        Node Head;
        Node Tail;

        public LinkedList(Node Head = null, Node Tail = null)//конструктор для работы со списком извне
        {
            this.Head = Head;
            this.Tail = Tail;
        }

        public void AddInTail(Node item)//добавить ещё один узел в хвост
        {
            if (Head == null)
                Head = item;
            else
            {
                Tail.Next = item;              
            }
            Tail = item;
        }

        public void Advancement(Node node)//абстрактное продвижение по списку
        {            
            node = Head;
            while (node != null)
                node = node.Next;                    
        }

        public Node Find(int val)//поиск конкретного узла по значению
        {
            Node node = Head;
            while (node != null)
            {
                if (node.Value == val) return node;
                node = node.Next;
            }
            return null;
        }

        public Node Delete(int val)
        {
            Node current = Head;
            Node previous = null;

     
                
            
        }

        public void Print()//вывод списка на экран
        {
            Node node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }        
    }
}
