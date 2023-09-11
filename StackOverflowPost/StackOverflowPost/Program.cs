using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter a description: ");
            string description = Console.ReadLine();
            
            var post = new Post(title, description);
            Console.WriteLine("\n" + post.ToString());
        }
    }
}
