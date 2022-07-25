using System;

using System.Collections.Generic;

namespace generic_list_complex
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack
            Console.WriteLine("\n============================= stack ==========================");

            Stack<int> salary = new Stack<int>();

            salary.Push(25000);
            salary.Push(35000);
            salary.Push(45000);
            salary.Push(55000);
            salary.Push(65000);

            foreach (int number in salary)
            {
                Console.WriteLine(number + "\n");
            }

            //stack pop: returns the last element and removes it from a stack

            salary.Pop();

            foreach (int number in salary)
            {
                Console.WriteLine("Pop:-" + number);
            }

            //stack contains

            Console.WriteLine("\n Contains(\"45000\") = {0} \n",
           salary.Contains(45000));

            //stack Clear

            foreach (int number in salary)
            {
                Console.WriteLine("before clear:-" + number);
            }

            Console.WriteLine("\n after clear");
            salary.Clear();

            foreach (int number in salary)
            {
                Console.WriteLine("\n after clear" + number);
            }

            //queue
            Console.WriteLine("\n================== queue ==================== \n");

            Queue<string> num = new Queue<string>();

            num.Enqueue("one");
            num.Enqueue("two");
            num.Enqueue("three");
            num.Enqueue("four");
            num.Enqueue("five");

            foreach (string numb in num)
            {
                Console.WriteLine(numb);
            }

            //queue.contains

            Console.WriteLine("\nnum.Contains(\"four\") = {0}",
            num.Contains("four"));

            //queue.clear

            foreach (string numb in num)
            {
                Console.WriteLine("before Clear:-" + numb);
            }

            Console.WriteLine("\n after clear");

            num.Clear();

            foreach (string nums in num)
            {
                Console.WriteLine("\nafter Clear:-" + nums);
            }

            //dictionary
            Console.WriteLine("\n================== dictionary ==================== \n");
            
            IDictionary<int, string> idNames = new Dictionary<int, string>();

            //adding a key/value using the Add() method

            idNames.Add(1, "Prashant"); 
            idNames.Add(2, "Shravani");
            idNames.Add(3, "Shriya");

            foreach (KeyValuePair< int, string> kvp in idNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}\n", kvp.Key, kvp.Value);
            }

            //remove
            Console.WriteLine("removed key 2\n");

            idNames.Remove(2);

            foreach (KeyValuePair<int, string> kvp in idNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}\n", kvp.Key, kvp.Value);
            }

            //clear
            Console.WriteLine("before clear\n");

            foreach (KeyValuePair<int, string> kvp in idNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}\n", kvp.Key, kvp.Value);
            }

            Console.WriteLine("after clear\n");

            idNames.Clear();

            foreach (KeyValuePair<int, string> kvp in idNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}\n", kvp.Key, kvp.Value);
            }

            // Create Employee Objects
            Console.WriteLine("\n================== Create Employee Objects ==================== \n");

            Employee emp1 = new Employee() { ID = 101, FirstName = "Shreyas", LastName = "Patil", MobileNumber = 9867676787, Location = "Pune" };
            Employee emp2 = new Employee() { ID = 102, FirstName = "Prisha", LastName = "Deshmukh", MobileNumber = 9867786787, Location = "Satara" };
            Employee emp3 = new Employee() { ID = 103, FirstName = "Tejas", LastName = "Suryavanshi", MobileNumber = 9456786534, Location = "Latur" };
            Employee emp4 = new Employee() { ID = 104, FirstName = "Suhas", LastName = "Jadhav", MobileNumber = 8698756789, Location = "Kolhapur" };

            // Create a List of Employees

            List<Employee> listEmployees = new List<Employee>();

            //Adding Employees to the collection using Add Method

            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);

            // We can retrieve the Items from a list collection by using index. 
            // The following line will retrieve the employee from the list. 
            // The List index is  0 based.

            Employee FirstEmployee = listEmployees[0]; 
            Console.WriteLine("Retrive the First Employee By Index");
            Console.WriteLine($"ID = {FirstEmployee.ID}, FirstName = {FirstEmployee.FirstName}, LastName = {FirstEmployee.LastName}, MobileNumber = {FirstEmployee.MobileNumber}, Location = {FirstEmployee.Location}");

            //Retrieving All Employees using For loop

            Console.WriteLine("\nRetrieving All Employees using For Loop");
            for (int i = 0; i < listEmployees.Count; i++)
            {
                Employee employee = listEmployees[i];
                Console.WriteLine($"ID = {employee.ID}, FirstName = {employee.FirstName}, LastName = {employee.LastName}, MobileNumber = {employee.MobileNumber}, Location = {employee.Location}");
            }

            //Retrieving All Employees using For Each loop

            Console.WriteLine("\nRetrieving All Employees using For Each Loop");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, FirstName = {employee.FirstName}, LastName = {employee.LastName}, MobileNumber = {employee.MobileNumber}, Location = {employee.Location}");
            }

            // use Contains method to check if an item exists or not in the list 
            Console.WriteLine("\nContains Method Check Employee2 Object");
            if (listEmployees.Contains(emp2))
            {
                Console.WriteLine("Employee2 Object Exists in the List");
            }
            else
            {
                Console.WriteLine("Employee2 Object Does Not Exists in the List");
            }

            // Use Exists method when you want to check if an item exists or not
            // in the list based on a condition
            Console.WriteLine("\nExists Method Name StartsWith P");
            if (listEmployees.Exists(x => x.FirstName.StartsWith("P")))
            {
                Console.WriteLine("List contains Employees whose Name Starts With P");
            }
            else
            {
                Console.WriteLine("List does not Contain Any Employee whose Name Starts With P");
            }

            //Inserting an Employee into the Index Position 1.

            listEmployees.Insert(1, emp4);

            //Retrieving the list after inserting the employee in index position 1

            Console.WriteLine("\nRetriving the List After Inserting New Employee in Index 1");

            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine($"ID = {employee.ID}, FirstName = {employee.FirstName}, LastName = {employee.LastName}, MobileNumber = {employee.MobileNumber}, Location = {employee.Location}");
            }

            //created another object
            Console.WriteLine("\ncreated another employees");
            Employee employee1 = new Employee()
            {
                ID = 106,
                FirstName = "Hemant",
                LastName = "Kulkarni",
                MobileNumber = 9156776787,
                Location = "Osmanabad"
            };
            Employee employee2 = new Employee()
            {
                ID = 107,
                FirstName = "Mrunal",
                LastName = "Sathe",
                MobileNumber = 9156769874,
                Location = "Mumbai"
            };

            Console.WriteLine("ID={0}, FirstName={1},  LastName={2}, MobileNumber={3}, Location={4}", employee1.ID, employee1.FirstName, employee1.LastName, employee1.MobileNumber, employee1.Location);
            Console.WriteLine("ID={0}, FirstName={1},  LastName={2}, MobileNumber={3}, Location={4}", employee2.ID, employee2.FirstName, employee2.LastName, employee2.MobileNumber, employee2.Location);
        }

        public class Employee
        {
            public int ID;
            public string FirstName;
            public string LastName;
            public long MobileNumber;
            public string Location;
        }

    }
}
