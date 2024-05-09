using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            #region thinkbridge

            //var a = "2023";
            //var b = 2023;
            //if (a == b)
            //{
            //    Console.WriteLine("true");
            //}
            //if (a.Equals(b))
            //{
            //    Console.WriteLine("S");
            //}


            //string[] grades = { "Grade 1", "Grade 3", "Grade 4", "Grade 2" };

            //IEnumerable<string> gradequery = from grade in grades
            //                                 orderby grade
            //                                 select grade;

            //foreach (var g in gradequery)
            //{
            //    Console.WriteLine(g);
            //}

            ////Program p = new Program();
            ////p.PrintAverage(a, b, c, d);
            //Console.ReadLine();
            #endregion

            //Fibonacci Series: Write a program to generate the Fibonacci series up to a given number 'n'.
            #region fibonacci series

            //p.fibonacciSeries(30);
            //Console.ReadLine();
            #endregion

            //Prime Numbers: Write a program to check if a given number is prime or not.

            #region prime number
            //p.CheckPrimte(10);
            #endregion

            //Palindrome: Write a program to check if a given string is a palindrome (reads the same forwards and backwards).
            #region palindrome
            //p.CheckPalindrome("radar"); 
            #endregion

            //4. Factorial: Write a program to calculate the factorial of a given number 'n'.
            #region factorial
            //p.PrintFactorial(5);
            #endregion

            //5. Array Manipulation: Write a program to find the maximum and minimum elements in an array.
            #region array manipulatino
            //int[] intarray = { 1, 2, 3, 5, 8 };
            //p.FindMaxandMinFromArray(intarray);
            #endregion

            #region find occurance of charter in provide string
            //p.GetOccuranceOfChar('a', "radar");
            #endregion


            //find occurance of each character in given string
            #region
            //p.findOccuranceOfEachChar("durgaprasad");

            #endregion

            //print diamon as per given number input
            #region 

            //p.printDiamond(9);
            #endregion

            //Calculate simple interest 
            #region
            //double pr = 1000;
            //int i = 4;
            //int y = 2;
            //int value = p.CalculateIntrest(pr, i, y);
            //Console.WriteLine(value);
            #endregion

            //print count of prime numbers in given range

            #region
            //p.countOfPrime(1, 20);
            #endregion

            #region
            // p.ReverseWord("Hello World");
            #endregion

            #region find index of element in array


            //string[] randomStrings = {
            //"Lorem", "ipsum", "dolor", "sit", "amet", "consectetur",
            //"adipiscing", "elit", "sed", "do", "eiusmod", "tempor",
            //"incididunt", "ut", "labore", "et", "dolore", "magna", "aliqua"};

            //p.FindIndex(randomStrings, "et");

            #endregion

            #region
            int[] randomIntegers = { 14, 56, 23, 78, 92, 35, 67, 41, 14, 23 };
            p.OccuranceOfEachNumber(randomIntegers);

            #endregion

            Console.ReadLine();

        }


        #region fibonacci series
        //Fibonacci Series: Write a program to generate the Fibonacci series up to a given number 'n'.

        public void fibonacciSeries(int input)
        {
            int first = 0;
            int second = 1;
            int next = 0;

            Console.Write(first +" "+ second +" ");

            for (int i = 1; i <= input; i++)
            {
                next = first + second;
                if (next >= input)
                {
                    break;
                }
                Console.Write(next +" ");
                first = second;
                second = next;
                
            }
        }

        #endregion

        #region check if given number is prime or not
        public void CheckPrimte(int input)
        {
            int num;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{num} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number.");
            }
        }
        #endregion

        #region check palindrome
        public void CheckPalindrome(string strinput)
        {
            string reversestring = "";
           
             for (int j = strinput.Length - 1; j >= 0 ; j--)
                {
                    reversestring += strinput[j];
                }
            

            if (strinput.Equals(reversestring))
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
        #endregion


        #region factorial

        public void PrintFactorial(int num)
        {
            int output = 1;
            int inttemp = 0;

            for (int i = num; i > 0; i--)
            {
                inttemp = output * i;
                output = inttemp;
                

            }

            Console.WriteLine("Factorial of {0} is {1}", num, output);
        }

        #endregion

        #region find max and min value from given array
        public void FindMaxandMinFromArray(int [] inputarray)
        {
            int a = inputarray[0];
            int b = inputarray[0];

            for (int i = 0; i < inputarray.Length; i++)
            {
                if (a > inputarray[i])
                {
                    a = inputarray[i];
                }
                if (b < inputarray[i])
                {
                    b = inputarray[i];
                }
            }

            Console.WriteLine("minimum {0}", a);
            Console.WriteLine("maximum {0}", b);

        }

        #endregion


        #region find occurance of provided character in provided string

        public void GetOccuranceOfChar(char a, string strinput)
        {
            //Dictionary<char, int> CharList = new Dictionary<char, int>();
           
            int count = 0;


                for (int j   = 0; j < strinput.Length; j++)
                {
                    if (a == strinput[j])
                    {
                       count++;
           
                      
                    }

                    
                }
            //CharList.Add(a, charcount);
            Console.WriteLine("Count of {0} in {1} is {2}", a, strinput, count);


        }

        #endregion

        #region find occurance of each character in given string

        public void findOccuranceOfEachChar(string strinput)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            for (int i = 0; i < strinput.Length; i++)
            {
                char currentChar = strInput[i];
                if (charCounts.ContainsKey(currentChar))
                {
                    charCounts[currentChar]++;
                }
                else
                {
                    charCounts[currentChar] = 1;
                }
            }

            foreach (var item in charCounts)
            {
                Console.WriteLine($"Character: {item.Key}, Occurrence: {item.Value}");
            }
        }

        #endregion


        #region print diamond
        public void printDiamond(int num)
        {
            int i, j, count = 1;
            count = num - 1;

            for (j = 1; j <= num; j++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (i = 1; i <= 2 * j -1 ; i++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
            count = 1;
            for (j = 1; j <= num - 1; j++)
            {
                for (i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count++;
                for (i = 1; i <= 2 * (num - j) - 1; i++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region
        public int CalculateIntrest(double p, int i, int y)
        {
            int value = (Convert.ToInt32(p) * i * y) / 100;

            return value;

        }
        #endregion


        #region
        public void countOfPrime(int startnum, int endnum)
        {
            int count = 0;
            int tempcount = 0;
            //bool notprime = true;
            for (int i = startnum; i <= endnum; i++)
            {
                count = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && i != 1)
                {
                    count++;
                    tempcount = tempcount + count;
                    
                    //Console.Write("{0} ", i);

                }
                    
            }

            Console.WriteLine(tempcount);
        }
        #endregion

        #region thinkbridge
        //public void PrintAverage(int a, int b, int c, int d)
        //{
        //    int sum = a + b + c + d;
        //    int res = sum / 4 ;
        //    Console.WriteLine(sum);
        //}



        //nt a= 0;
        //    int b = 0;

        //    for (a = 0; a < 5; a++)
        //    {
        //        for (b = 0; b < 2; b++)
        //        {
        //            if (a>2)
        //            {
        //                continue;
        //            }
        //            Console.WriteLine("Thinkbridge");
        //        }
        //    }



        //Quetion Out Put Compile time error

        //var a = "th";
        //var b = 2023;
        //Console.WriteLine(a + " " + b);
        //    a = b;
        //    b = "tb";

        //    Console.WriteLine(b + "" + a);

        //Console.ReadLine();


        //Question Out put compile time error

        //var a = "th";
        //var b = 2023;

        //    if (a == b)
        //    {
        //        Console.WriteLine("Tb");
        //    }
        //    if (a.Equals(b))
        //    {
        //        Console.WriteLine("Solution");
        //    }



        //Out put 6 times provided string

        //    int i = 0;
        //    int j = 0;
        //        for (i = 0; i< 5; i++)
        //        {
        //            for (j = 0; j< 2; j++)
        //            {
        //                if (i<2)
        //                {
        //                    continue;
        //                }
        //Console.WriteLine("TB");
        //            }
        //        }



        //        //Program p = new Program();
        //        //p.PrintAverage(a, b, c, d);
        //        Console.ReadLine();



        //// Comile time error
        //int[] nums = { 1, -2, 3, 0, -4, 5 };
        //int filteredNums = from n in nums
        //                   where n > 0 && n < 6
        //                   orderby n descending
        //                   select n;

        //    foreach (int i in filteredNums)

        //        Console.WriteLine(i + "");


        //    //Program p = new Program();
        //    //p.PrintAverage(a, b, c, d);
        //    Console.ReadLine();


        //Out put will be string array as it is

        //string[] grades = { "Grade 1", "Grade 3", "Grade 4", "Grade 2" };

        //IEnumerable<string> gradequery = from grade in grades
        //                                 orderby grade
        //                                 select grade;

        //foreach (var g in gradequery)
        //{
        //    Console.WriteLine(g);
        //}

        ////Program p = new Program();
        ////p.PrintAverage(a, b, c, d);
        //Console.ReadLine();
        #endregion

        #region Reverse words in provided string

        public void ReverseWord(string input)
        {

            string[] words = input.Split(" ");

            Array.Reverse(words);

            string reversewords = string.Join(" ", words);

            Console.WriteLine(reversewords);
        }

        #endregion

        #region find index of element in given array

        //public void FindIndex(string [] inputArray, string strForIndex)
        //{
        //    int index = 0;
        //    int counter = 0;

        //    foreach (var item in inputArray)
        //    {
        //        if (strForIndex == item)
        //        {
        //            index = counter;
        //        }
        //        counter++;
        //    }

        //    Console.WriteLine("index of {0} id {1}", strForIndex, index);
        //}

        #endregion


        #region occurance of each number my solution

        public void OccuranceOfEachNumber(int [] intArray)
        {
            
            int num = 0;
            Dictionary<int, int> numCount = new Dictionary<int, int>();

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                num = intArray[i];
                if (numCount.ContainsKey(num))
                {
                    numCount[num]++;
                }
                else
                {
                    numCount[num] = 1;

                }

                
              

            }


            foreach (var item in numCount)
            {
                Console.WriteLine(item);
            }
        }

        #endregion


    }

}
