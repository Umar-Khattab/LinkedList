using LinkedList;
using System;
class Program
{
    static void Main(string[] args)
    {
        ConsoleColor current = Console.ForegroundColor;
        current = ConsoleColor.DarkGreen;
        SingleLinkedList list = new SingleLinkedList();
        while (true)
        {
            Console.WriteLine("1.Create List");
            Console.WriteLine("2.Display List");
            Console.WriteLine("3.Count");
            Console.WriteLine("4.Search");
            Console.WriteLine("5.Add to empty list / Add at beginning");
            Console.WriteLine("6.Add at end");
            Console.WriteLine("7.Add after node");
            Console.WriteLine("8.Add before node");
            Console.WriteLine("9.Add at position");
            Console.WriteLine("10.Delete");
            Console.WriteLine("11.Reverse");
            Console.WriteLine("12.Quit\n");
            Console.Write("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            int data = 0;
            int item;
            int pos;
            switch (choice)
            {
                case 1:
                    list.createList(10, 1, 100);

                    break;
                case 2:
                    list.printList();

                    break;
                case 3:
                    Console.WriteLine(list.count());

                    break;
                case 4:
                    Console.Write("Enter the element to be searched: ");

                    data = int.Parse(Console.ReadLine());
                    list.search(data);
                    break;
                case 5:
                    Console.Write("Enter the element to be inserted: ");

                    data = int.Parse(Console.ReadLine());
                    list.insertAtFront(data);
                    break;
                case 6:
                    Console.Write("Enter the element to be inserted: ");

                    data = int.Parse(Console.ReadLine());
                    list.insertAtEnd(data);
                    break;
                case 7:
                    Console.Write("Enter the element to be inserted: ");

                    data = int.Parse(Console.ReadLine());
                    Console.Write("Enter the element after which to insert: ");

                    item = int.Parse(Console.ReadLine());
                    list.insertAfter(data, item);

                    break;
                case 8:
                    Console.Write("Enter the element to be inserted: ");
                    data = int.Parse(Console.ReadLine());
                    Console.Write("Enter the element before which to insert: ");

                    item = int.Parse(Console.ReadLine());
                    list.insertBefore(data, item);
                    break;
                case 9:
                    Console.Write("Enter the element to be inserted: ");

                    data = int.Parse(Console.ReadLine());

                    Console.Write("Enter the position at which to insert: ");
                    pos = int.Parse(Console.ReadLine());
                    list.insertAtPosition(data, pos);
                    break;
                case 10:
                    Console.Write("Enter the element to be deleted: ");

                    data = int.Parse(Console.ReadLine());
                    list.deleteNode(data);
                    break;
                case 11:
                    list.reverseList();
                    break;
                case 12:
                    return;
            }
        }
    }
}