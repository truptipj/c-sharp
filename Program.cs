using System;

namespace Assignment_one
{
    class Loops
    {
        static void Main(string[] args)
        {

            //if statement

            if (20 > 10)
            {
                Console.WriteLine("20 is greater than 10");
            }

            //if else statement

            int num = 10;

            if (num > 20)
            {
                Console.WriteLine("10 is greater");
            }
            else
            {
                Console.WriteLine("20 is greater");
            }

            //if else if statement

            int a = 10;
            int b = 20;
            int c = 30;

            if (a > b && a > c)
            {
                Console.WriteLine("a is greater");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is greater");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("c is greater");
            }

            //switch statement

            string month = "three";

            switch (month)
            {
                case "one":
                    Console.WriteLine("It is Jan");
                    break;
                case "two":
                    Console.WriteLine("It is Feb");
                    break;
                case "three":
                    Console.WriteLine("It is March");
                    break;
                case "four":
                    Console.WriteLine("It is April");
                    break;
                default:
                    Console.WriteLine("Another Month");
                    break;
            }

            //while loop

            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //do while 

            int j = 0;

            do
            {
                Console.WriteLine(i);
                j++;
            }
            while (j < 5);

            //for loop

            for (int x = 0; x < 5; x += 2)
            {
                Console.WriteLine(x);
            }

            //for each loop

            string[] fruits = { "grapes", "mango", "banana" };

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //break statement

            for (int y = 0; y < 7; y++)
            {
                if (y == 4)
                {
                    break;
                }
                Console.WriteLine(y);
            }

            //continue statement

            for (int w = 0; w < 7; w++)
            {
                if (w == 4)
                {
                    continue;
                }
                Console.WriteLine(w);
            }
        }
    }
}