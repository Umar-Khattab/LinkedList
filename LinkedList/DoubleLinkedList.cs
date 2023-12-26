using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class DoubleLinkedList
    {
        Node Head;
        public void Print()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write($"{p.data}  ");
                p = p.next;
            }
            Console.WriteLine();
        }
        public int Count()
        {
            int Counter = 0;
            Node p = Head;
            while (p != null)
            {
                Counter++;
                p = p.next;
            }
            return Counter;
        }
        public void CreateList (int num,int min,int max){
            Random random = new Random();
            int value;
            for(int i = 0; i < num; i++)
            {
                value = random.Next(min,max);
                InsertAtEnd(value);
            }
        }
        public string Search(int key)
        {
            Node p = Head;
            int position = 1;
            while (p != null)
            {
                if (p.data == key)
                {
                    return $"Founded at position {position}";
                }
                position++;
                p= p.next;
            }
            return "not founded";
        }
        public void InsertAtEnd (int value) {
            Node temp = new Node();
            if (Head == null)
            {
                Head = temp;
                return;
            }
            Node p = Head;
            while (p != null) { 
                p = p.next;
            }
            p.next = temp;
            temp.prev = p;
        }
        public void InsertAtFront(int value)
        {
            Node temp = new Node();
            if (Head == null)
            {
                Head = temp;
            }
            else
            {
                temp.next = Head.next;
                temp.prev = null;
                Head.next.prev = temp;
                Head.next = temp;
            }
        }
        public void InsertAfter(int value , int target)
        {
            if(Head == null) { Console.WriteLine("list is empty");return;}
            Node p = Head;
            Node temp = new Node();
            temp.data = value;
            while(p != null)
            {
                if(p.data == target)
                {
                    temp.next = p.next;
                    temp.prev = p;
                    p.next = temp;
                    p.next.prev = temp;
                    return;
                }
                p= p.next;
            }
            Console.WriteLine("target node doesn`t in list");
        }
        public void InsertBefore(int value , int target)
        {
            if (Head == null) { Console.WriteLine("list is empty"); }
            Node p = Head;
            Node temp = new Node();
            temp.data = value;
            while(p.next != null)
            {
                if(p.data == target)
                {
                    temp.next = p.next;
                    temp.prev = p;
                    p.next = temp;
                    p.next.prev = temp;
                    return;
                }
                p= p.next;
            }
            Console.WriteLine("target node doesn`t in list");
        }
        public void InsertAtPosition (int value , int Position)
        {
            if (Position == 1)
                InsertAtFront(value);
            Node p = Head;
            Node temp = new Node();
            temp.data = value;
            for(int i = 1; i < Position-1&&p!=null; i++)
                p = p.next;
            if (p == null)
                Console.WriteLine($"there are less than {Position} nodes");
            else
            {
                temp.next = p.next;
                temp.prev = p;
                p.next = temp;
                p.next.prev = temp;
            }
        }
        public void Delete(int data)
        {
            if (Head == null) { Console.WriteLine("list is empty");return; }
            if (Head.data == data)
            {
                Head = Head.next;
                Head.next.prev = null;
                return;
            }
            Node p = Head;
            while (p != null)
            {
                if(p.next.data == data)
                {
                    p.prev.next = p.next.next;
                    p.next.prev = p.prev;
                    return;
                }
                p = p.next;
            }
            Console.WriteLine("node not founded");
        }
        public void Reverse() {
            Node p1, p2;
            p1 = Head;
            p2 = p1.next;
            p1.next = null;
            p2.next = p1;
            while(p2 != null)
            {
                p2.prev = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = p2.prev;
            }
            Head = p1;
        }
    }
}
