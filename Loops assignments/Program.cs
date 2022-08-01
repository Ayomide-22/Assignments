using System;

namespace Loops_assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter a number");
            // int n =int.Parse(Console.ReadLine());
            // for(int i=0;i<=n;i++)
            // {
            //     Console.Write(i+" ");
            // }


            // Console.WriteLine("Enter a number");
            // int n =int.Parse(Console.ReadLine());
            // Console.WriteLine("The numbers not divisible by both 3 and 7 between 1 and "+n+" are");
            // for(int i=1;i<=n;i++)
            // {
            //     if(i%3!=0&&i%7!=0)
            //     {
            //         Console.Write(i+" ");
            //     }
            // } 

            // Console.WriteLine("How many numbers do ypu want to enter");
            // int length =int.Parse(Console.ReadLine());
            // int smallest=0;
            // int largest =0;
            // for(int i=0;i<length;i++)
            // {
            //     Console.WriteLine("Enter number");
            //     int n=int.Parse(Console.ReadLine());
            //     if(i==0)
            //     {
            //         smallest = n;
            //         largest = n;
            //     }
            //     else if(n>largest)
            //     {
            //         largest=n;
            //     }
            //     else if(n<smallest)
            //     {
            //         smallest=n;
            //     }
            // }
            // Console.WriteLine("The largest number is "+largest+" and the smallest is "+smallest);



            // for(int i=0;i<4;i++)
            // {
            //     Console.WriteLine();
            //     for(int j=0;j<13;j++)
            //     {
            //         switch(i)
            //         {
            //             case 0: Console.Write("Hearts "); break;
            //             case 1: Console.Write("Diamond "); break;
            //             case 2: Console.Write("Spade "); break;
            //             case 3: Console.Write("Club "); break;
            //         }
            //         switch(j)
            //         {
            //             case 0: Console.WriteLine("A"); break;
            //             case 1: Console.WriteLine("1"); break;
            //             case 2: Console.WriteLine("2"); break;
            //             case 3: Console.WriteLine("3"); break;
            //             case 4: Console.WriteLine("4"); break;
            //             case 5: Console.WriteLine("5"); break;
            //             case 6: Console.WriteLine("6"); break;
            //             case 7: Console.WriteLine("7"); break;
            //             case 8: Console.WriteLine("8"); break;
            //             case 9: Console.WriteLine("9"); break;
            //             case 10: Console.WriteLine("J"); break;
            //             case 11: Console.WriteLine("Q"); break;
            //             case 12: Console.WriteLine("K"); break;
            //         }
            //     }
            // }


            // int num1=0;
            // int num2=1;
            // int num3=0;
            // Console.WriteLine("Enter length of sequence");
            // int length=int.Parse(Console.ReadLine());
            // Console.Write("0 1");
            // for(int i=2;i<length;i++)
            // {
            //     num3=num1+num2;
            //     Console.Write(" "+num3+" ");
            //     num1=num2;
            //     num2=num3;
            // }

            // Console.WriteLine("Enter n");
            // int n = int.Parse(Console.ReadLine());
            // int n1 = 1;
            // int k1 = 1;
            // Console.WriteLine("Enter k (less than n)");
            // int k = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     n1 *= i;
            // }
            // for (int i = 1; i <= k; i++)
            // {
            //     k1 *= i;
            // }
            // int nk = n1 / k1;
            // Console.WriteLine("n!/k! = " + nk);

            // Console.WriteLine("Enter n");
            // int n = int.Parse(Console.ReadLine());
            // int n1 = 1;
            // int k1 = 1;
            // Console.WriteLine("Enter k (less than n)");
            // int k = int.Parse(Console.ReadLine());
            // int l = n - k;
            // int l1 = 1;
            // for (int i = 1; i <= n; i++)
            // {
            //     n1 *= i;
            // }
            // for (int i = 1; i <= k; i++)
            // {
            //     k1 *= i;
            // }
            // for (int i = 1; i <= l; i++)
            // {
            //     l1 *= i;
            // }


            // int nkl = (n1*k1)/l1;
            // Console.WriteLine(nkl);

            // Console.WriteLine("Enter n");
            // int n = int.Parse(Console.ReadLine());
            // int k = n + 1;
            // int l = 2 * n;
            // int n1 = 1;
            // int k1 = 1;
            // int l1 = 1;
            // for (int i = 1; i <= n; i++)
            // {
            //     n1 *= i;
            // }
            // for (int i = 1; i <= k; i++)
            // {
            //     k1 *= i;
            // }
            // for (int i = 1; i <= l; i++)
            // {
            //     l1 *= i;
            // }

            // int c = l1 / (n1 * k1);

            // Console.WriteLine(c);



            // Console.WriteLine("Enter n (less than 20)");
            // int n = int.Parse(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     for (int j = i; j < n + i; j++)
            //     {
            //         Console.Write(" " + j);
            //     }
            //     Console.WriteLine();
            // }


            //NUMBER11
            // Console.WriteLine("Enter a number");
            // double n1 = 1;
            // int zeroes = 0;
            // double n = double.Parse(Console.ReadLine());
            // for (int i = 1; i <= n; i++)
            // {
            //     n1 *= i;
            // }
            // do
            // {
            //     n1 /= 10;
            //     zeroes++;
            // } while (n1 % 10 == 0);
            // Console.WriteLine("There are " + zeroes + " zeroes in " + n + "!");


            //NUMBER12
            // Console.WriteLine("Enter number");
            // int n=int.Parse(Console.ReadLine());
            // do
            // {
            //     int m=n%2;
            //     Console.Write(m);
            //     n=n/2;
            // }while(n!=0);

            //NUMBER13
            // Console.WriteLine("Enter binary number");
            // int bin=int.Parse(Console.ReadLine());
            // int rem=0;
            // int dec=0;
            // int basenum=1;
            // while(bin>0)
            // {
            //     rem=bin%10;
            //     dec=dec+rem*basenum;
            //     bin=bin/10;
            //     basenum=basenum*2;
            // }
            // Console.WriteLine(dec);


            //NUMBER1



            


        }
    }
}
