using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            bool loop = true;
            while(loop)
            {
                Console.WriteLine("Type start, stop or exit: ");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "start":
                        stopwatch.Start();
                        break;
                    case "stop":
                        stopwatch.Stop();
                        break;
                    default:
                        loop = false;
                        break;
                }
            }
        }
    }
}
