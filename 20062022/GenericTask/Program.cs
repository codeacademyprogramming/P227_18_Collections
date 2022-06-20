using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();
            numbers.Add(14);
            numbers.Add(24);
            numbers.Add(34);
            numbers.Add(44);
            numbers.Add(54);

            numbers[1] = 100;

            Console.WriteLine(numbers[1]);



            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("hello");
            arrayList.Add('A');
            arrayList.Insert(0, 'B');


            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            SortedList sortedList = new SortedList();
            sortedList.Add('B', 55);
            sortedList.Add('A', 25);
            sortedList.Add('F', 15);
            sortedList.Add('C', 605);
            sortedList.Add('D', "salam");


            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            Console.WriteLine("Queue\n");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());


            Console.WriteLine("List\n");

            List<int> numbersList = new List<int>();

            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(40);
            numbersList.Add(50);
            numbersList.Add(50);
            numbersList.Add(50);
            numbersList.Add(50);
            numbersList.Add(50);


            foreach (var item in numbersList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(numbersList.Capacity);
            Console.WriteLine(numbersList.Count);


            Dictionary<string, double> products = new Dictionary<string, double>();

            products.Add("Alma", 4.5);
            products.Add("Armud", 2.5);
            products.Add("Alca", 6.5);
            products.Add("Albali", 5.5);


            SortedList<string, double> keyValuePairs = new SortedList<string, double>();










        }
    }
}
