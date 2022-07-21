using System;

using System.Collections;

namespace ArrayAndArrayList
{
    class MethodsOfArray
    {
        static void Main(string[] args)
        {


            // Creating an array  

            string[] fruits = { "Grapes", "Mango", "Banana", "Apple" };

            //access the elements of array
            Console.WriteLine("\n---access the elements of array---\n");

            Console.WriteLine(fruits[2]);

            //change an array element
            Console.WriteLine("\n---change an array element---\n");

            Console.WriteLine("\n---before change an array element---\n");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\n---after change an array element---\n");

            fruits[3] = "orange";

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //array length
            Console.WriteLine("\n---array length---\n");

            Console.WriteLine(fruits.Length);

            //loop through an array
            Console.WriteLine("\n---for loop---\n");

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            //foreach
            Console.WriteLine("\n---foreach method---\n");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //sort
            Console.WriteLine("\n---array.sort:---\n");

            Console.WriteLine("\n---before array.sort:---\n");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("\n---after array.sort:---\n");

            Array.Sort(fruits);

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //index of array
            Console.WriteLine("\n---array.indexOf:---\n");

            int[] num = { 10, 20, 30, 40, 50 };

            {
                Console.WriteLine(Array.IndexOf(num, 30));
            }

            //reverse array
            Console.WriteLine("\n---array.reverse:---\n");

            Console.WriteLine("\n---before array.reverse:---\n");

            foreach (int car in num)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("\n---after array.reverse:---\n");

            Array.Reverse(num);

            foreach (int car in num)
            {
                Console.WriteLine(car);
            }

            //clear method
            Console.WriteLine("\n---array.clear:---\n");

            Array.Clear(num);

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            //copy & copyTo 
            int[] arrSource = { 111, 222, 333, 444, 555 };
            int[] numsDest = { 10, 20, 30, 40, 50 };

            //*CopyTo(dest, index); index-start index 
            Console.WriteLine("\n---array.copyTo:---\n");

            arrSource.CopyTo(numsDest, 0);

            Console.WriteLine("Destination Array copyTo");

            foreach (int value in numsDest)
            {
                Console.WriteLine(value);
            }

            //*copy method Array.Copy(src, dest, length);
            Console.WriteLine("\n----array.copy----\n");

            Array.Copy(numsDest, arrSource, 5);
            Console.WriteLine("Destination Array");

            foreach (int value in arrSource)
            {
                Console.WriteLine(value);
            }

            //exists
            Console.WriteLine("\n---array.exists----\n");

            // Array.Exists 
            bool a = Array.Exists(arrSource, element => element == 222);
            bool b = Array.Exists(arrSource, element => element == 666);


            // Display bools.

            Console.WriteLine(a);
            Console.WriteLine(b);

            //array.empty
            Console.WriteLine("\n---array.empty:---\n");

            int[] arr1 = Array.Empty<int>();
            Console.WriteLine(arr1.Length);

            //join
            Console.WriteLine("\n-----join method-----\n");

            string arr2 = string.Join(",", fruits);
            Console.WriteLine("value of string arr2 is" + " " + arr2);

            Console.WriteLine("\n===================================array-list===================================\n");

            //Create an ArrayList

            ArrayList employeeList = new ArrayList();

            //Adding Elements in ArrayList

            employeeList.Add(1143);
            employeeList.Add("Vishakha");
            employeeList.Add("patil");
            employeeList.Add("Angular Developer");

            Console.WriteLine("\n---Accessing an ArrayList---\n");
            //Access individual item using index

            Console.WriteLine(employeeList[0]);
            Console.WriteLine(employeeList[1]);

            //Insert Elements in ArrayList
            Console.WriteLine("\n---Insert Elements in ArrayList---\n");

            employeeList[1] = "Priya";

            Console.WriteLine(employeeList[1]);


            //Check Element in ArrayList
            Console.WriteLine("\n---Check Element in ArrayList---\n");

            Console.WriteLine(employeeList.Contains("patil"));
            Console.WriteLine(employeeList.Contains(1145));

            //Remove Elements from ArrayList
            Console.WriteLine("\n---Remove Elements from ArrayList---\n");

            employeeList.RemoveAt(1); //Removes element at index 1
            employeeList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)


            foreach (var item in employeeList)
            {
                Console.WriteLine(item);
            }

            //clear
            Console.WriteLine("\n---clear Elements from ArrayList---\n");

            employeeList.Clear();
            foreach (var item in employeeList)
            {
                Console.WriteLine(item);
            }

            //another ArrayList

            ArrayList laptops = new ArrayList();
            laptops.Add("Dell");
            laptops.Add("Hp");
            laptops.Add("Asus");
            laptops.Add("Lenovo");

            //indexOf
            Console.WriteLine("\n---indexOf---\n");

            Console.WriteLine(laptops.IndexOf("Asus"));

            //capacity of ArrayList
            Console.WriteLine("\n---capacity & count ArrayList---\n");

            Console.WriteLine(laptops.Capacity);
            Console.WriteLine(laptops.Count);

            //sort
            Console.WriteLine("\n---sort Elements from ArrayList---\n");

            laptops.Sort();
            foreach (var item in laptops)
            {
                Console.WriteLine(item);
            }
        }
    }
}