using System;

namespace Array_assingment
{
    class Program
    {
        static void Main(string[] args)
        {

        // NUMBER1
        //   int[] myArray= new int[20];
          
        //   for(int i=0;i<myArray.Length;i++)
          
        //   {
        //       myArray[i]=i*5;
        //        Console.WriteLine(myArray[i]);

        //   }


        // NUMBER 2
        // bool arrayequal = true;
        // Console.WriteLine("Enter first array length");
        // int length1=int.Parse(Console.ReadLine());
        // int[] myArray1=new int[length1];
        // for(int i=0;i<length1;i++)
        // {
        //     Console.WriteLine("Enter number in first array");
        //     myArray1[i]=int.Parse(Console.ReadLine());
        // }
        // Console.WriteLine("Enter second array length");
        // int length2=int.Parse(Console.ReadLine());
        // int[] myArray2=new int[length2];
        // for(int i=0;i<length2;i++)
        // {
        //      Console.WriteLine("Enter number in seccond array");
        //     myArray2[i]=int.Parse(Console.ReadLine());
        // }
        // if(length1 != length2)
        // {
        //     Console.WriteLine("Arrays are different in length");
        // }
        // else
        // {
        //     for(int i=0;i<myArray1.Length;i++)
        //     {
        //         if(myArray1[i]!=myArray2[i])
        //         {
        //             Console.WriteLine("Arrays are not equal");
        //             arrayequal=false;
        //             break;
        //         }
        //     }
        //     if(arrayequal)
        //     {

        //         Console.WriteLine("The arrays are equal");
        //     }
        // } 



        // NUMBER 4
        // int count1= 1;
        // int count2= 1;
        // int num= 0;
        // Console.WriteLine("Enter array length");
        // int length =int.Parse(Console.ReadLine());
        // int[] myArray= new int[length];
        // for(int i=0;i<length;i++)
        // {
        //     Console.WriteLine("Enter number");
        //     myArray[i]=int.Parse(Console.ReadLine());
        // }
        // for(int i=0;i<length-1;i++)
        // {
        //   if(myArray[i]==myArray[i+1])
        //   {
        //       count1++;
        //   }
        //   else
        //   {
        //       count1=1;
        //   }
        //   if(count1>count2)
        //   {
        //       count2=count1;
        //       num=myArray[i];
        //   }
          
        // }
        // for(int i=0;i<count2;i++)
        // {
        //     Console.WriteLine(num);
        // }
        


        // NUMBER 3
        // bool lexi=true;
        // Console.WriteLine("Enter the length of the first array");
        // int length1=int.Parse(Console.ReadLine());
        // char[] arr1=new char[length1];
        // for(int i=0;i<arr1.Length;i++)
        // {
        //     Console.WriteLine("Enter a character");
        //     arr1 [i]=char.Parse(Console.ReadLine());
        // }
        // Console.WriteLine("Enter the length of the second array");
        // int length2=int.Parse(Console.ReadLine());
        // char[] arr2=new char[length1];
        // for(int i=0;i<arr2.Length;i++)
        // {
        //     Console.WriteLine("Enter a character");
        //     arr2 [i]=char.Parse(Console.ReadLine());
        // }

        // if(length1>length2)
        // {
        //     Console.WriteLine("Second array is lexicographically first");
        // }
        // else if(length2>length1)
        // {
        //     Console.WriteLine("First array is lexicographically first");
        // }
        // else if(length2==length1)
        // {
        //     for(int i=0;i<arr1.Length;i++)
        //     {
        //     if(arr1[i]>arr2[i])
        //     {
        //         Console.WriteLine("Second array is lexicographically first");
        //         lexi=false;
        //         break;
        //     }
        //     else if(arr2[i]>arr1[i])
        //     {
        //         Console.WriteLine("First array is lexicographically first");
        //         lexi=false;
        //         break;
        //     }
        //     }
        //     if(lexi)
        //     {
        //         Console.WriteLine("Arrays are equal");
        //     }
        // }



        // NUMBER 5
        // Console.WriteLine("Enter length of array");
        // int length=int.Parse(Console.ReadLine());
        // int[] arr=new int[length];
        // int chron1=1;
        // int last=0;
        // int start=0;
        // for(int i=0;i<arr.Length;i++)
        // {
        //     Console.WriteLine("Enter number");
        //     arr[i]=int.Parse(Console.ReadLine());
        // }
        // for(int i=0;i<arr.Length-1;i++)
        // {
        //     if(arr[i]+1==arr[i+1])
        //     {
        //         chron1++;
        //         last=i+1;
        //         start=last-chron1+1;
        //     }
        //     else
        //     {
        //         chron1=1;
        //     }
        // }
        // for(int i=start;i<last+1;i++)
        // Console.WriteLine(arr[i]);




        //NUMBER8
        // Console.WriteLine("Enter Length of array");
        // int length =int.Parse(Console.ReadLine());
        // int[] arr=new int[length];
        // int asc = 0;
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     Console.WriteLine("Enter number");
        //     arr[i]=int.Parse(Console.ReadLine());
        // }
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     for (int j = i + 1; j < arr.Length; j++)
        //     {
        //        if (arr[i] > arr[j])
        //         {
        //             asc = arr[i];
        //             arr[i] = arr[j];
        //             arr[j] = asc;
        //         }

        //     }
        // }
        // Console.WriteLine("In ascending order");
        // foreach (var item in arr)
        // {
        //     Console.WriteLine(item);
        // }



        //NUMBER10
        // int count1 = 0, count2 = 1, most = 0;

        // Console.Write("Enter array length: ");
        // int length = int.Parse(Console.ReadLine());

        // int[] arr = new int[length];

        // for (int i = 0; i < length; i++)
        // {
        //     Console.Write("Enter number");
        //     arr[i] = int.Parse(Console.ReadLine());
        // }

        // Array.Sort(arr);

        // for (int i = 0; i < length - 1; i++)
        // {
        //     if (arr[i] == arr[i + 1]) count2++;
        //     else count2 = 1;
        //     if (count2 > count1)
        //     {
        //         count1 = count2;
        //         most = arr[i];
        //     }
        // }        
        // Console.WriteLine(most+" ocurred the most");



        //NUMBER11
        // Console.WriteLine("Enter array length");
        // bool addup=true;
        // int length=int.Parse(Console.ReadLine());
        // int[] arr=new int[length];
        // Console.WriteLine("Enter sum");
        // int s=int.Parse(Console.ReadLine());
        // for(int i=0;i<length;i++)
        // {
        //     Console.WriteLine("Enter number");
        //     arr[i]=int.Parse(Console.ReadLine());
        // }
        // for(int i=0;i<length;i++)
        // {
        //     if(i==0)
        //     {
        //         if(arr[i]+arr[i+1]==s)
        //         {
        //             Console.WriteLine(arr[i]+" and "+arr[i+1]+" add up to "+s);
        //             addup=false;
        //             break;
        //         }
        //     }
        //     if(i>0&&i<length-1)
        //     {
        //         if(arr[i]+arr[i+1]+arr[i-1]==s)
        //         {
        //             Console.WriteLine(arr[i-1]+" "+arr[i]+" and "+arr[i+1]+" add up to "+s);
        //             addup=false;
        //             break;
        //         }
        //     }
        //     if(i==length-1)
        //     {
        //         if(arr[i]+arr[i+1]==s)
        //         {
        //             Console.WriteLine(arr[i=1]+" and "+arr[i]+" add up to "+s);
        //             addup=false;
        //             break;
        //         }
        //     }                        
        // }
        // if(addup)
        // {
        //     Console.WriteLine("No neighbours add up to "+s);
        // }



        //NUMBER 12
            // Console.WriteLine("Enter number of rows and columns of the array");
            // int r=int.Parse(Console.ReadLine());
            // int[,] arr=new int[r,r];  

            // for(int row=0;row<r;row++)
            // {
            //     for(int col=0;col<r;col++)
            //     {
            //         Console.WriteLine("Enter value for row "+row+" column "+col);
            //         arr[row,col]=int.Parse(Console.ReadLine());
            //     }
            // }     

            // for(int row=0;row<r;row++)
            // {
            //     for(int col=0;col<r;col++)
            //     {
            //         Console.Write(arr[row,col]+" ");
            //     }
            //     Console.WriteLine();
            // }   


            //NUMBER 13
            // Console.WriteLine("Enter number of rows of the array");
            // int r=int.Parse(Console.ReadLine());
            // Console.WriteLine("Enter number of columns of the array");
            // int c=int.Parse(Console.ReadLine());            
            // int[,] arr=new int[r,c];  

            // for(int row=0;row<r;row++)
            // {
            //     for(int col=0;col<c;col++)
            //     {
            //         Console.WriteLine("Enter value for row "+row+" column "+col);
            //         arr[row,col]=int.Parse(Console.ReadLine());
            //     }
            // }     

            // for(int row=0;row<r;row++)
            // {
            //     for(int col=0;col<c;col++)
            //     {
            //         Console.Write(arr[row,col]+" ");
            //     }
            //     Console.WriteLine();
            // }             



            //NUMBER 19
            // for(double prime=2;prime<=10000000;prime++)
            // {
            //     bool primecheck=true;
            //     for(int num=2;num<prime;num++)
            //     {
            //         if(prime%num==0)
            //         {
            //             primecheck =false;
            //         }
            //     }
            //     if(primecheck)
            //     {
            //         Console.Write(prime+" ");
            //     }                
            // }

            //NUMBER23
            // Console.Write("Enter array length: ");
            // int length = int.Parse(Console.ReadLine());
            // int[] arr = new int[length];
            // for (int i = 0; i < length; i++)
            // {
            //     Console.Write("Enter number");
            //     arr[i] = int.Parse(Console.ReadLine());
            // }
            // for(int i=0;i<length;i++)
            // {
            //     for(int j=0;j<length;j++)
            //     {
            //         Console.Write(arr[i]+","+arr[j]);
            //     }
            //     Console.WriteLine();
            // }
            

            //NUMBER7

            Console.WriteLine("Enter array length");
            int sum1=0 ,sum2=0, start=0,end=0,pos1=0,pos2=0;

            int length =int.Parse(Console.ReadLine());
            int[] arr=new int[length];
            Console.WriteLine("Enter how many consecutive numbers");
            int k=int.Parse(Console.ReadLine());
            for(int i=0;i<length;i++)
            {
                for(int j=i;j<i+k;j++)
                {
                    sum1+=arr[j];
                    if(i==0)
                    {
                        pos1=j;
                        pos2=j+k-1;
                        sum2=sum1;
                        start=arr[j];
                        end=arr[j+k-1];

                    }
                    if(sum1>sum2)
                    {
                        pos1=j;
                        pos2=j+k-1;
                        sum2=sum1;
                        start=arr[j];
                        end=arr[j+k-1];
                    }    
                    sum1=0;                
                }

                if(i==length-1)
                {
                    for(int a=pos1;a<pos2+1;a++)
                    {
                        Console.Write(a+" ");
                    }
                    Console.Write("produce the largest sum which is "+sum2);
                }
            }
        }   
    }
}
