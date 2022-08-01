using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length");
            int length =int.Parse(Console.ReadLine());
            int[] arr=new int[length];
            for(int i=0;i<length;i++)
            {
                Console.WriteLine("Enter number");
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter index of number to check");
            int a=int.Parse(Console.ReadLine());
            Neighbour(arr,a);
        }

        static void Neighbour(int[] arr,int a)
        {
            if(a==0)
            {
                if(arr[0]>arr[1])
                {
                    Console.WriteLine(arr[a]+" is greater than its neighbours");
                }
                else
                {
                    Console.WriteLine(arr[a]+" is not greater than its neighbours");
                }
            }
            else if(a>0&&a<arr.Length-1)
            {
                if(arr[a]>arr[a+1]&&arr[a]>arr[a-1])
                {
                    Console.WriteLine(arr[a]+" is greater than its neighbours");
                }
                else
                {
                    Console.WriteLine(arr[a]+" is not greater than its neighbours");
                }
            }
            else if(a==arr.Length-1)
            {
                if(arr[a]>arr[a-1])
                {
                    Console.WriteLine(arr[a]+" is greater than its neighbours");}
                }
                 else 
                {
                    Console.WriteLine(arr[a]+" is not greater than its neighbours");
                }
            }


        }
    }

