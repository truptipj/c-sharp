using System;

using System.Collections;

namespace HashtableStackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //create hashtable
            Hashtable employeeIdNames = new Hashtable();

            //adding a key/value using the Add() method

            employeeIdNames.Add(111, "Priyanka");
            employeeIdNames.Add(222, "Vaibhavi");
            employeeIdNames.Add(333, "Trupti");
            employeeIdNames.Add(444, "Nikita");

            Console.WriteLine("\n---adding a key/value using the Add() method---\n");
            foreach (DictionaryEntry num in employeeIdNames)
                Console.WriteLine("Key: {0}, Value: {1}", num.Key, num.Value);

            //creating another Hashtable

            var employeeDetails = new Hashtable(){
             {"Angular Developers", "Nitin, Rohit, Vedant"},
             {"React Developers", "Raj, Vishakha, Priya"},
             {"Csharp", "Mukesh, Vibha, Rahul"}
            };

            Console.WriteLine("\n---access keys & values of hashtable---\n");

            foreach (DictionaryEntry emp in employeeDetails)
                Console.WriteLine("Key: {0}, Value: {1}", emp.Key, emp.Value);

            //update value of Csharp key
            Console.WriteLine("\n---update value of Csharp key---\n");

            employeeDetails["Csharp"] = "Sneha, Reyansh, Rohan";

            foreach (DictionaryEntry dev in employeeDetails)
                Console.WriteLine("Key: {0}, Value: {1}", dev.Key, dev.Value);

            //Remove value of React Developers key
            Console.WriteLine("\n---Remove value of React Developers key---\n");
            employeeDetails.Remove("React Developers");

            foreach (DictionaryEntry dev in employeeDetails)
                Console.WriteLine("Key: {0}, Value: {1}", dev.Key, dev.Value);

            //Determine key present or not using Contains method
            Console.WriteLine("\n---Determine key present or not using Contains method---\n");

            Console.WriteLine(employeeDetails.Contains("Csharp"));

            //ContainsKey method
            Console.WriteLine("\n---ContainsKey method---\n");

            Console.WriteLine(employeeDetails.ContainsKey("Angular Developers"));

            //ContainsValue method
            Console.WriteLine("\n---ContainsValue method---\n");

            Console.WriteLine(employeeIdNames.ContainsValue("Nikita")); //true bcz exists
            Console.WriteLine(employeeIdNames.ContainsValue("Kriti")); //false bcz not exists

            //CopyTo
            Console.WriteLine("\n---CopyTo---\n");

            DictionaryEntry[] arr1 = new DictionaryEntry[employeeIdNames.Count];
            employeeIdNames.CopyTo(arr1, 0);

            foreach (DictionaryEntry dev in arr1)
                Console.WriteLine("Key: {0}, Value: {1}", dev.Key, dev.Value);

            //clear & count
            Console.WriteLine("\n---clear & count---\n");

            Console.WriteLine("\n Before Clear()' Number of items in employeeIdNames \n" + employeeIdNames.Count);

            employeeIdNames.Clear();
            Console.WriteLine("\n After Clear()' Number of items in employeeIdNames \n" + employeeIdNames.Count);

            //equals
            Console.WriteLine("\n---check if employeeIdNames is equal to employeeDetails or not---\n");

            Console.WriteLine(employeeIdNames.Equals(employeeDetails));

            Console.WriteLine("\n==================================Creating a Queue==================================\n");

            //Create and Add Elements in the Queue

            Queue<int> employeeId = new Queue<int>();
            employeeId.Enqueue(1);
            employeeId.Enqueue(2);
            employeeId.Enqueue(3);
            employeeId.Enqueue(4);

            Console.WriteLine("\n---enqueue---\n");

            foreach (var id in employeeId)
                Console.WriteLine(id);

            //Count
            Console.WriteLine("\n---Count---\n");

            Console.WriteLine(employeeId.Count);

            //peek: Element at the start of the queue
            Console.WriteLine("\n---peek---\n");

            Console.WriteLine("Element at the start of the queue is: {0}", employeeId.Peek());

            //Dequeue
            Console.WriteLine("\n---Dequeue---\n");

            employeeId.Dequeue();

            foreach (var id in employeeId)
                Console.WriteLine(id);


            //Contains
            Console.WriteLine("\n---Contains---\n");

            employeeId.Contains(3);

            Console.WriteLine(employeeId.Contains(5));
            Console.WriteLine(employeeId.Contains(2));

            Queue<int> employeeSalary = new Queue<int>();
            employeeId.Enqueue(25000);
            employeeSalary.Enqueue(22000);
            employeeSalary.Enqueue(35000);
            employeeSalary.Enqueue(40000);
            //clear
            Console.WriteLine("\n---Clear---\n");

            Console.WriteLine("\n Before Clear()' Number of items in employeeIdNames \n" + employeeId.Count);

            employeeId.Clear();

            Console.WriteLine("\n After Clear()' Number of items in employeeIdNames \n" + employeeId.Count);

            Console.WriteLine("\n==================================Creating a Stack==================================\n");

            // Creates and initializes a new Stack.

            Stack emailId = new Stack();
            emailId.Push("Priyanka@gmail.com");
            emailId.Push("Vaibhavi@gmail.com");
            emailId.Push("Trupti@gmail.com");
            emailId.Push("Nikita@gmail.com");

            // Displays the Stack.
            Console.WriteLine("\n---Displays the Stack---\n");
            foreach (var item in emailId)
                Console.Write(item + "," + "\n \n");

            //Count of the Stack.
            Console.WriteLine("\n---Count of the Stack---\n");

            Console.WriteLine(emailId.Count);

            // Views the first element in the Stack but does not remove it.
            Console.WriteLine("\n---Peek Views the first element in the Stack but does not remove it---\n");

            Console.WriteLine("Element at top is {0}", emailId.Peek());

            // Removes an element from the Stack.
            Console.WriteLine("\n---Removes an last element from the Stack using pop---\n");

            Console.WriteLine(emailId.Pop());

            //created another stack

            Stack employeeAddress = new Stack();

            employeeAddress.Push("pune");
            employeeAddress.Push("mumbai");
            employeeAddress.Push("latur");
            employeeAddress.Push("satara");
            employeeAddress.Push("nashik");
            employeeAddress.Push("kolhapur");

            //clone
            Console.WriteLine("\nStack elements...cloned\n");
            Stack address = (Stack)employeeAddress.Clone();

            foreach (string val in address)
            {
                Console.WriteLine(val);
            }

            //contains
            Console.WriteLine("\nStack elements...contains\n");

            Console.WriteLine(employeeAddress.Contains("satara")); //exist true
            Console.WriteLine(employeeAddress.Contains("Vadgaon")); //not exists false
        }
    }
}
