using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a=int.Parse(Console.ReadLine());
            Reverse(a);
        }

        static void Reverse(int x)
        {
            while(x>=1)
            {
                int y=x%10;
                Console.Write(y);
                x=x/10;
            }
        }
    }
}
