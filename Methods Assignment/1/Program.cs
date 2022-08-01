using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name=Console.ReadLine();
            PrintName(name);
        }

        static void PrintName(string a)
        {
            Console.WriteLine("Hello "+a);
        }
    }
}
