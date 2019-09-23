using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Assingnment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 22;
            printSelfDividingNumbers(a, b);
            int n2 = 5;
            printSeries(n2);
            int n3 = 5;
            printTriangle(n3);
            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones();
            Console.WriteLine(r4);

            int[] arr1 = { 1, 2, 5, 6, 7, 8, 9 };
            int[] arr2 = { 1, 2, 3, 4, 5 };

            /*int[] LargestCommonSubArray = getLargestCommonSubArray(arr1, arr2);
            Console.WriteLine("The Largest contiguous sub array is ");
            Console.Write("[");
            for (int i = 0; i < LargestCommonSubArray.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(LargestCommonSubArray[i]);
                }
                else
                {
                    Console.Write("," + LargestCommonSubArray[i]);
                }

            }

            Console.WriteLine("r5"); 
            
             */

        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {

              /*Function to check if n is divisible by all its digits*/


                for (int i = x; i < y + 1; i++)
                {
                    string i_s = i.ToString();
                    /*computing each digit of a number as a list*/
                    char[] digilist = i_s.ToCharArray();
                    string condition = "";

                    
                    while (i > 0)
                    {
                        /*checking if the number is divisible by each digit*/
                        for (int d = 0; d < digilist.Length; d++)
                        {
                            int digit = int.Parse(digilist[d].ToString());

                            //Checking if the digit is Zero, since any number divided by zero is infinity.
                            if (digit == 0)
                            {
                                condition = condition + "false";
                            }

                            else
                            {
                                int remainder = i % digit;
                                if (remainder != 0)
                                {
                                    condition = condition + "false";
                                }
                                else
                                {
                                    condition = condition + "true";
                                }
                            }
                        }
                        if (condition.Contains("false"))
                        {
                            //Shows us the non-self divisible numbers. 
                            Console.WriteLine(i + "   Is not a Self-Divisible Number" );
                        }
                        else
                        {
                            Console.WriteLine(i + "   Is a Self Divisble Number");
                        }
                        break;
                    }

                    Console.ReadLine();
                }
                

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }

        public static void printSeries(int n2)
        {
            try
            {
                Console.WriteLine("enter a number for printing series : ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The Series of the entered number is: ");
                //declaring a string to print all the numbers in a single line
                string toprint = "";
                // Starting loop from 1 to lessthan or equal to n.  
                for (int i = 1; i <= n2; i++)
                {
                    //starting from j= 1
                    for (int j = 1; j <= i; j++)
                    {
                        //converting i to string 
                        toprint = toprint + " " + i.ToString();
                    }
                }
                Console.WriteLine(toprint);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n3)
        {
            try
            {
                //taking the number of rows from user.
                Console.WriteLine("enter the number of rows for the triangle : ");
                //taking the input
                n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("the inverted pyramid pattern is: ");
                //
                int j = 0;
                for (int i = n3; i > 0; i--)
                {
                    for (j = n3 - i; j > 0; j--)
                    {
                        Console.Write(" ");
                    }
                    //finding the pattern of the pyramid for printing
                    for (j = (2 * i) - 1; j > 0; j--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
                Console.ReadKey();
                //Reference for Print Inverted pyramid "http://alltypecoding.blogspot.com/2015/05/how-to-printing-reverse-triangle-in-c.html"
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones()
        {
            try
            {
                //Declaring new lists and providing values
                List<int> list1 = new List<int>() { 1, 3 };
                List<int> list2 = new List<int>() { 1, 3, 3, 2, 2, 2, 2, 2 };
                int count = 0;

                foreach (int value in list1.Intersect(list2))
                {  //comparing values in both the lists and displaying the common values
                    List<int> TEST = list2.FindAll(item => item == value); ;
                    count = count + TEST.Count();
                }
                Console.WriteLine("the output is : ");
                Console.WriteLine(count);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
            return 0;
        }

       
        }

    }

