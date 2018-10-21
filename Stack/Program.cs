using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>(20);
            Node<int> e1 = new Node<int>(1);
            myStack.Push(e1);
            Node<int> e2 = new Node<int>(2);
            myStack.Push(e2);
            Node<int> e3 = new Node<int>(3);
            myStack.Push(e3);
            //print stack
            Console.WriteLine("myStack: " + Environment.NewLine + string.Join(Environment.NewLine, myStack.GetStack()));
            //pop
            int retVal = myStack.Pop();
            Console.WriteLine("Popped value: " + retVal);
            //print stack again
            Console.WriteLine("myStack: " + Environment.NewLine + string.Join(Environment.NewLine, myStack.GetStack()));

            //search - true
            Console.WriteLine(myStack.Search(e1.value));
            //search - false
            Console.WriteLine(myStack.Search(e3.value));

            Console.ReadLine();
        }
    }
}
