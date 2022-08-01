using System;

namespace _2
{
    class Program
    {
            static int a;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3=int.Parse(Console.ReadLine());
            GetMax(GetMax(num1,num2),num3);
            Console.WriteLine("Biggest number is "+a);
        }

        static int GetMax(int x, int y)
        {
            if(x>y)
            {
                a=x;
            }
            else
            {
                a=y;
            }
            return a;
        }
    }
}
