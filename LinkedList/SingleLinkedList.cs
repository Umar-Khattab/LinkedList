using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SingleLinkedList
    {
        Node head;
        public void printList()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
            Console.WriteLine();
        }
        public void createList(int num, int min, int max)
        {
            Random random = new Random();
            int val;
            for (int i = 0; i < num; i++)
            {
                val = random.Next(min, max);
                insertAtEnd(val);
            }
        }
        public int count()
        {
            int count = 0;
            Node p = head;
            while (p != null)
            {
                count++;
                p = p.next;
            }
            return count;
        }
        public void search(int data)
        {
            Node p = head;
            int pos = 1;
            while (p != null)
            {
                if (p.data == data)
                {
                    Console.WriteLine("Item {0} found at position {1}", data, pos);
                    return;
                }
                p = p.next;
                pos++;
            }
            Console.WriteLine("Item {0} not found in list\n", data);
        }
        public void insertAtFront(int data)
        {
            Node temp = new Node();
            temp.data = data;
            temp.next = head;
            head = temp;
        }
        public void insertAtEnd(int data)
        {
            Node temp = new Node();
            temp.data = data;
            if (head == null)
            {
                head = temp;
                return;
            }
            Node p = head;
            while (p.next != null)
                p = p.next;
            p.next = temp;
            temp.next = null;
        }
        public void insertAfter(int data, int item)
        {
            Node temp = new Node();
            temp.data = data;
            Node p = head;
            while (p != null)
            {
                if (p.data == item)
                {
                    temp.next = p.next;
                    p.next = temp;
                    return;

                }
                p = p.next;
            }
            Console.WriteLine("{0} not present in the list\n", item);
        }
        public void insertBefore(int data, int item)
        {
            Node temp = new Node();
            temp.data = data;
            if (head == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            if (item == head.data)
            {
                temp.next = head;
                head = temp;
                return;
            }
            Node p = head;
            while (p != null)
            {
                if (p.next.data == item)
                {
                    temp.next = p.next;
                    p.next = temp;
                    return;

                }
                p = p.next;
            }
            Console.WriteLine("{0} not present in the list\n", item);
        }

        public void insertAtPosition(int data, int pos)
        {
            if (pos == 1)
            {
                insertAtFront(data);
                return;
            }
            Node temp = new Node();
            temp.data = data;
            Node p = head;
            for (int i = 1; i < pos - 1 && p != null; i++)
                p = p.next;
            if (p == null)
                Console.WriteLine("There are less than {} elements\n", pos);
            else
            {
                temp.next = p.next;
                p.next = temp;
            }
        }
        public void deleteNode(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.data == data) //first node
            {
                head = head.next;
                return;
            }
            Node p = head;
            while (p.next != null)
            {
                if (p.next.data == data)
                {
                    p.next = p.next.next;
                    return;
                }
                p = p.next;
            }
            Console.WriteLine("Element {0} not found", data);
        }
        public void reverseList()
        {
            Node prev, ptr, next;
            prev = null;
            ptr = head;
            while (ptr != null)
            {
                next = ptr.next;
                ptr.next = prev;
                prev = ptr;
                ptr = next;
            }
            head = prev;
        }
    }
}
