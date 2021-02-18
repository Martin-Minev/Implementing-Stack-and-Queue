using System;
using System.Collections.Generic;

namespace Implementing_Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack myStack = new CustomStack();
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);

            myStack.ForEach(e => Console.WriteLine(e));


            //CustomList myList = new CustomList();
            //myList.Add(10);
            //myList.Add(20);

            //myList.Swap(0, 1);
            //Console.WriteLine(myList.Contains(200));
        }
    }
}
