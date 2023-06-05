using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //int a = 1;
        //Console.WriteLine(a++); // a= 1 . post increament
        //// now after the post increament is a =2
        //Console.WriteLine(++a); // a= 3 . pre increament


        //for (int i = 0; i <= 5; i++)
        //{
        //    Console.Write("*");
        //}
        //Console.WriteLine();
        //for (int i = 0; i <= 5; i++)
        //{
        //    Console.WriteLine("*    *");
        //}
        //for (int i = 0; i <= 5; i++)
        //{
        //    Console.Write("*");
        //}

        //int a = 2;

        //do { 
        //    Console.WriteLine(a);
        //    a++; 
        //} while (a <= 5);

        //while (a >1)
        //{
        //    Console.WriteLine(a);
        //    //a++;
        //    //a = a + 5;
        //}

        //Console.WriteLine("enter a number :");
        //int a = int.Parse(Console.ReadLine());

        //Console.WriteLine("enter a second number:");
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine("Odd numbers are :");

        //for (int i=a = 1; i <= b; i+=2)
        //{
        //    Console.WriteLine(i);
        //}

        //{
        //    int n;

        //    Console.WriteLine("Please enter a number : ");
        //    n = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Factorial of the number is : ");

        //    for (int i = n - 1; i > 0; i--)
        //        {
        //            n *= i;
        //        }
        //}
        //-------------------------------------------------

        //Console.WriteLine("enter a number :");
        //int a = int.Parse(Console.ReadLine());

        //Console.WriteLine("enter a second number:");
        //int b = int.Parse(Console.ReadLine());

        //Console.WriteLine("Odd/even numbers are :");

        //for (int i = a ; i <= b; i ++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.WriteLine(i + " - even");
        //    }
        //    else
        //    {
        //        Console.WriteLine(i + "- odd");
        //    }
        //}
        //        enter a number:
        //        2
        //enter a second number:
        //5
        //Odd / even numbers are :
        //2 - even
        //3 - odd
        //4 - even
        //5 - odd
        //--------------------------------------

        Console.WriteLine("enter a number of rows :");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }
}