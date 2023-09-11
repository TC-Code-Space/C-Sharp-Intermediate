using System.Collections.Generic;
using System.Net.Security;

namespace PsuedoStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push("hello");
            stack.Push('a');

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());     //invalid operation exception


            stack.Push(System.DateTime.Now);
            Console.WriteLine(stack.Pop());

            stack.Push(3);



            stack.Clear();
            //stack.Clear();                      //invalid operation exception 

        }
    }
}
