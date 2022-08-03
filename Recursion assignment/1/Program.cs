using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n=int.Parse(Console.ReadLine());
            Printnum(n,n);
        }
    static void Printnum(int n,int m)
    {
        if(n==0)
        {
            return;
        }
        Console.WriteLine((m-n+1)+" ");
        Printnum(n-1,m);   
    }

    }

}
