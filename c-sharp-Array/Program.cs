using static System.Console;

using System;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Data.Common;


internal class Program
{
    private static void Main(string[] args)
    {


        //evenodd();

        //secondLargest();

        //removeDublicate();

        //towDArray();

       int[,] arr= new int[4, 4] {
                                    { 0, 1, 2, 3} ,
                                 { 4, 5, 6, 7} ,
                                 { 8, 9, 10, 11} ,
                                  { 12, 13, 14, 15}
                                         };

        float total = sumOfElement(arr);
       WriteLine("the sum of all element is {0}", total);

        WriteLine("************************************");
        float[] rowAverages = averageOfEachRow(arr);

        WriteLine("Row averages:");

        for (int i = 0; i < rowAverages.Length; i++)
        {
            WriteLine("Row {0}: {1}", i + 1, rowAverages[i]);
        }
        WriteLine("************************************");
        WriteLine("enter the target number");
        int target= int.Parse(ReadLine());
        WriteLine(searchForElement(arr, target));
        (int row, int column) = searchForElement(arr, target);

        if (row != -1 && column != -1)
        {
            WriteLine("Target {0} found at position (Row: {1}, Column: {2})", target, row, column);
        }
        else
        {
            WriteLine("Target {0} not found in the array.", target);
        }


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
  
    static float sumOfElement(int[,] arr)
    {
       int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            //Console.WriteLine();

            for (int j = 0; j < arr.GetLength(1); j++)
            {
                //Console.Write(arr[i, j]+" ");

                sum = sum + arr[i, j];
            }
           // Console.WriteLine();
        }
       
        return sum;
    }
  
//Exercise 2: Find the Average of each Row
//Write a program that takes a 2D array of integers as
//input and calculates the average value for each row.
//Display the average value of each row as the output.


    static float[] averageOfEachRow(int[,] arr)
    {
       

     
        float[] average = new float[arr.GetLength(0)];

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            float sum = 0;
            for (int column= 0; column < arr.GetLength(1); column++)
            {
                sum += arr[row, column];
              
            }
            average[row] = sum / arr.GetLength(1);

        }
        return average;


    }
    // Exercise 3: Search for an Element
    //Write a program that takes a 2D array of integers as
    //input and a target number.Search for the target number
    //in the array and display its position(row and column) if found.
    //If the target number is not found, display a message indicating its absence.

    static (int,int) searchForElement(int[,] arr, int target)
    {

        for (int row = 0; row < arr.GetLength(0); row++)
        {

            for (int column = 0; column < arr.GetLength(1); column++)
            {

                if (arr[row, column] == target) 
                {
                    return (row, column);
                }



            }

        }

        return (-1, -1);


    }

}