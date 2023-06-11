using static System.Console;

using System;
using System.Xml.Linq;
using System.Security.Cryptography;


internal class Program
{
    private static void Main(string[] args)
    {


        //evenodd();

        secondLargest();




    }

    static void sumofNumbers()
    {


        int[] a = { 1, 5, 7, 9, 10 };
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum = sum + a[i];

        }

        WriteLine(sum);
    }

    static void average()
    {

        //task1 :Write a program that accepts an array of integers and calculates the average 
        //of all the elements
        int[] num = { 1, 5, 7, 9, 16 };
        // double avrg = 0.0;
        int sum1 = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum1 = sum1 + num[i];


        }

        double avrg = sum1 / num.Length;
        WriteLine(avrg);

    }

    static void maxmin()
    {
        //task2:Write a program that accepts an array of integers and finds the maximum 
        //and minimum elements in the array.
        int[] num1 = { 1, 5, 7, 9, 19 };

        WriteLine("Minimum number is " + num1.Min());
        WriteLine("Maximum number is " + num1.Max());
    }

    static void evenodd()
    {
        //task3:Write a program that accepts an array of integers and counts the number of 
        //even and odd elements
        int[] num2 = { 1, 5, 7, 9, 16 };
        int even = 0;
        int odd = 0;
        for (int i = 0; i < num2.Length; i++)
        {

            if (num2[i]% 2 == 0)
            {
                even++;
                WriteLine(num2[i]+" is even number");
            }
            else
            {
                odd++;
                WriteLine(num2[i] + " is odd number");
            }
           
        }
        WriteLine("there are " + even + " even numbers  and " + odd + " odd numbers");
    }

    //task4 Write a program that accepts an array of integers and finds the second 
    //largest element in the array

    static void secondLargest()
    {
        int[] num = { 1,20, 5, 7, 9, 19,22 };
        int num1 = int.MinValue, num2 = int.MinValue;

        for (int i = 0; i < num.Length; i++)
        {
            int s = num[i];
            if (s> num1)
            {
                num2 =num1;
                num1 = s;
            }
            else if (s> num2)
                num2= s;


        }
        WriteLine(num2);
    }

}