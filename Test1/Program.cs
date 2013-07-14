using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Long time process
            System.Threading.Thread.Sleep(2000);
            // This is an example test
            Console.WriteLine("Hello World");
        }
    }
}
