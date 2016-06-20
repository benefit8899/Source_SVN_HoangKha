using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name: ");
            string s = Console.ReadLine();
	Console.WriteLine("Hello "+s);
            Console.Read();
        }
    }
}
