using System;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // declaring and initializing the array
            int[] intArr = new int[5];

            string[] stringArr = new string[5];  

            Console.WriteLine("--- Integer Array Operations ----");
            intArrayOperation(intArr);

            Console.WriteLine("\n\n --- String Array Operations ----");
            stringArrayOperation(stringArr);

            Console.ReadKey();

        }

        public static void intArrayOperation(int[] intArr)
        {

            // accepting user values 
            Console.WriteLine("\n Enter Integer Array Elements: ");
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n Sorted Integer Array in Ascending Order:");
            // Sort array in ascending order.
            Array.Sort(intArr);

            // print all elements
            foreach (int value in intArr)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\n Reversed the Integer array: ");
            // reverse array
            Array.Reverse(intArr);

            // print all element of array
            foreach (int value in intArr)
            {
                Console.Write(value + " ");
            }

            // Clear Array
            Console.WriteLine("\n\n Clear 4th Elements from Inetegr Array: ");
            Array.Clear(intArr, 4, 1);

            // print all element of array
            foreach (int value in intArr)
            {
                Console.Write(value + " ");
            }
        }


        public static void stringArrayOperation(string[] stringArr) {

            // accepting user values 
            Console.WriteLine("\n Enter String Array Elements: ");
            for (int i = 0; i < stringArr.Length; i++)
            {
                stringArr[i] = Console.ReadLine();
            }

            Console.WriteLine("\nSorted String Array: ");
            // Sorting String Array
            Array.Sort(stringArr);

            // print all element of array
            foreach (string value in stringArr)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("\n\n Reversed  String Array : ");
            Array.Reverse(stringArr);

            // print all element of array
            foreach (string value in stringArr)
            {
                Console.Write(value + " ");
            }

            // Clear Array
            Console.WriteLine("\n\n Clear 2nd Element from String Array: ");
            Array.Clear(stringArr, 1, 1);

            // print all element of array
            foreach (string value in stringArr)
            {
                Console.Write(value + " ");
            }
        }
    }
}
