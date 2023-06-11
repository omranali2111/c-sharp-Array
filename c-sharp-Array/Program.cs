using static System.Console;

using System;
using System.Xml.Linq;


internal class Program
{
    private static void Main(string[] args)
    {
        int[] a = { 1, 5, 7, 9, 10 };
        int sum = 0;
        for(int i=0; i<a.Length; i++)
        {
            sum = sum + a[i];

        }

        WriteLine(sum);

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


        //task2:Write a program that accepts an array of integers and finds the maximum 
        //and minimum elements in the array.
        int[] num1 = { 1, 5, 7, 9, 19 };

        WriteLine("Minimum number is " + num1.Min());
       WriteLine("Maximum number is " + num1.Max());

    }
    


}