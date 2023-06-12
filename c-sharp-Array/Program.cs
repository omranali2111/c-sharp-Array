﻿using static System.Console;

using System;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.ComponentModel;


internal class Program
{
    private static void Main(string[] args)
    {


        //evenodd();

        //secondLargest();

        //removeDublicate();

        //towDArray();

        //sumOfElement();

        averageOfEachRow();




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
        WriteLine("second largest element in the array is "+num2);
    }
    //task5 Write a program that accepts an array of integers and removes all the 
    //duplicate elements
    // not complete 

    static void removeDublicate()
    {
        int[] num = { 1, 20, 5, 7, 9,9, 19, 22 };
      
        int Remove = 0;
        List<int> tmp = new List<int>(num);

        for (int i = 0; i < num.Length; i++)
        {
            for (int j = 0; j < num.Length; j++)
            {
                if (num[i] == num[j])
                {
                    break;

                }
              else  if (num[i] != num[j])
                {
                   Remove++;
                }
            }
            //WriteLine(num[i]);
            tmp.RemoveAt(Remove);
        }
        WriteLine(tmp);
    }


    //2D array
   static void towDArray()
    {
        //A multidimensional array is basically an array of arrays.
        int[,] numbers = new int[4,2];//4 row x 2columns
        numbers[0,0] =0;
        numbers[0,1] = 1;
        numbers[1,0] = 2;
        numbers[1,1] = 3;
       
        
        

        

        for(int row=0; row < numbers.GetLength(0); row++)

        {
            Console.WriteLine();
            for (int col=0; col < numbers.GetLength(1); col++)
            {
                Write(numbers[row,col]+" ");
            }
            //WriteLine();
        }
      
    }
    //Exercise 1: Calculate the Sum of all Elements
    //Write a program that takes a 2D array of integers as input 
    //and calculates the sum of all the elements in the 
    //array.Display the sum as the output.

    static void sumOfElement()
    {
        int[,] a = new int[4, 4] {
                                {0, 1, 2, 3} ,
                                 {4, 5, 6, 7} ,
                                 {8, 9, 10, 11} ,
                                  {12, 13, 14, 15}
                                    };

        int sum = 0;
        for (int i = 0; i < 4; i++)
        {
            //Console.WriteLine();

            for (int j = 0; j < 4; j++)
            {
                Console.Write(a[i, j]+" ");

                sum = sum + a[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine("the sum of all element is {0}",sum);
    }

//Exercise 2: Find the Average of each Row
//Write a program that takes a 2D array of integers as
//input and calculates the average value for each row.
//Display the average value of each row as the output.


    static void averageOfEachRow()
    {
        int[,] a = new int[4, 4] {
                                {0, 1, 2, 3} ,
                                 {4, 5, 6, 7} ,
                                 {8, 9, 10, 11} ,
                                  {12, 13, 14, 15}
                                    };

        float average = 0;
        float sum = 0;
       
        for (int i = 0; i < 4; i++)
        {
           
            
           
            

            for (int j = 0; j < 4; j++)
            {
                sum = sum + a[i, j];
                average = sum / 4;
                Console.Write(a[i, j] + " ");
               


            }
            Console.WriteLine("the average of row number {0} is {1}", i + 1, average);
        }
       
        

    }
}