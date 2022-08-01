using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length");
            int length=int.Parse(Console.ReadLine());
            int[] arr= new int[length];
            for(int i=0;i<length;i++)
            {
                Console.WriteLine("Enter number");
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter number to find");
            int num=int.Parse(Console.ReadLine());
            int x=NumCount(arr,num);
            Console.WriteLine(num+" occured "+x+" times");
        }

        static int NumCount(int[] arr, int num)
        {
            int counter =0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==num)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
