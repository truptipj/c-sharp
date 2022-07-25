using System;

namespace optional_array
{
    class Program
    {
        static void Main(string[] args)
        {

            Arrayshow array = new Arrayshow();
            Array arr = array.Show();

            Arrayshow.Arr_Methods arrs = new Arrayshow.Arr_Methods();
            arrs.sortArray(arr);
            arrs.reverseArr(arr);

        }

        public class Arrayshow
        {

            public Array Show()
            {

                int[] arr = new int[4];
                int i;
                Console.WriteLine("\n=======first array==========");
                for (i = 0; i < 4; i++)

                {
                    Console.Write("Enter 4 no of int number you want to type:\t");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                
                int sum = 0;
                Console.Write("\n\nYou entered:\t");
                for (i = 0; i < 4; i++)
                {
                    Console.Write("{0}\t", arr[i]);
                    sum +=  arr[i];
                }
                Console.Write("\n\nAnd sum of all value is:\t{0}", sum);
                Console.ReadLine();


                Console.WriteLine("============another array==========\n");

                int x;
                int y;

                Console.WriteLine("\n=======second array==========");
                Console.WriteLine("\n=======second array==========");
                Console.WriteLine("\nEnter no of string you want to type: ");

                y = Convert.ToInt32(Console.ReadLine());
                string[] arr2 = new string[y];
                for (x = 0; x < y; x++)
                {
                    Console.Write("\nType any string for ex: xyz:  ");
                    //Storing value in an array
                    arr2[x] = Console.ReadLine();
                }


                Console.WriteLine("============disply array==========\n");


                for (x = 0; x < y; x++)
                {
                    Console.WriteLine("   First Array String: =>{0}", arr[x]);
                }
                return arr;


            }
            public class Arr_Methods
            {
                public void sortArray(Array arr1)
                {
                    Array.Sort(arr1);
                    // Sort method 
                    Console.WriteLine("==============sort array==============");

                    Console.WriteLine("Sorted array list:- \n");
                     
                    foreach (var val in arr1)
                    {
                        Console.WriteLine(val);
                    }
                }

                public void reverseArr(Array arr2)
                {
                    Array.Reverse(arr2);

                    // Reverse method 
                    Console.WriteLine("========Reverse Method========");
                    
                    
                    foreach (var rev in arr2)
                    {
                        Console.WriteLine(rev);

                    }
                    Console.WriteLine("===========length============");
                    Console.Write(arr2.Length);

                    
                    // Find the number of element in myarray
                    int result = arr2.GetLength(0);
                    Console.WriteLine("Total Elements: {0}", result);
                }


            }
        }

    }
}