using System;

namespace _2
{
    class Program
    {
        static int []arr;
        static int numberOfelements;
        static int numberOfiterations;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            numberOfelements=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K");
            numberOfiterations=int.Parse(Console.ReadLine());         
            arr=new int[numberOfelements];  
            NestedLoops(0); 
        }

        static void NestedLoops(int currentelement)
        {
            if(currentelement==numberOfelements)
            {
                PrintLoops();
                return;
            }
            for(int i=1;i<=numberOfiterations;i++)
            {
                arr[currentelement]=i;
                NestedLoops(currentelement+1);
            }
        }

        static void PrintLoops()
        {
            for(int j=0;j<numberOfelements;j++)
            {
                Console.Write(arr[j]+" ");
            }
            Console.WriteLine();
        }
    }
}
