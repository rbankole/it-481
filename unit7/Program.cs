using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Assignment7
{
    class unit7
    {
        static void Main(string[] args)
        {
            bubbleSort();
            quicksSort();
        }
        //*********************************************************
        //****Assignment 4, Part B, Section 1 - Bubble Sort
        //*********************************************************
        static void bubbleSort()
        {
            // Normal Order
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("********** Section 1 - Bubble Sort Method **********");
            Console.WriteLine();
            string path = @"ages.txt";
            string[] age = File.ReadAllLines(path);
            int[] ages = age.Select(d => int.Parse(d)).ToArray();
            Console.Write("The unsorted list of elderly ages are: [");
            for (int i = 0; i <= ages.GetUpperBound(0); i++)
            {
                Console.Write(ages[i]);
                if (i != ages.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();

            // Asc Order
            int low = 0;
            int high = ages.Length - 1;
            sortArrayBS(ages, low, high);
            Console.Write("The elderly ages in ascending order are: [");
            for (int i = 0; i <= ages.GetUpperBound(0); i++)
            {
                Console.Write(ages[i]);
                if (i != ages.GetUpperBound(0))
                {
                    Console.Write(",");
                    
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();

            // Desc Order;
            sortArrayBS(ages, high, low);
            Console.Write("The elderly ages in descending order are: [");
            for (int i = ages.Length - 1; i >= ages.GetLowerBound(0); i--)
            {
                Console.Write(ages[i]);
                if (i != ages.GetLowerBound(0))
                {
                    Console.Write(",");                    
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();
        }
        //*********************************************************
        //****Assignment 4, Part B, Section 2 - Quick Sort
        //*********************************************************
        static void quicksSort()
        {
            // Normal Order
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("********** Section 2 - Quick Sort Method **********");
            Console.WriteLine();
            string path = @"ages.txt";
            string[] age = File.ReadAllLines(path);
            int[] ages = age.Select(d => int.Parse(d)).ToArray();
            Console.Write("The unsorted list of elderly ages are: [");
            for (int i = 0; i <= ages.GetUpperBound(0); i++)
            {
                Console.Write(ages[i]);
                if (i != ages.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();

            // Asc Order
            int low = 0;
            int high = ages.Length - 1;
            sortArrayQS(ages, low, high);
            Console.Write("The elderly ages in ascending order are: [");
            for (int i = 0; i <= ages.GetUpperBound(0); i++)
            {
                Console.Write(ages[i]);
                if (i != ages.GetUpperBound(0))
                {
                    Console.Write(",");
                    
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();

            // Desc Order;
            Console.Write("The elderly ages in descending order are: [");
            sortArrayQS(ages, high, low);
            for (int i = ages.Length - 1; i >= ages.GetLowerBound(0); i--)
            {
                Console.Write(ages[i]);
                if (i != ages.GetLowerBound(0))
                {
                    Console.Write(",");
                    
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();   
        }

        public static void sortArrayBS(int[] ages, int low, int high) // Bubble Sort Method
                {
            if (ages == null || ages.Length == 0)
                return;

            if (low >= high)
            return;
            int middle = low + (high - low) / 2; int cen = ages[middle];int i = low, j = high;
            while (i <= j)
            {
                while (ages[i] < cen)
                {
                    i++;
                }
                while (ages[j] > cen)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = ages[i];
                    ages[i] = ages[j];
                    ages[j] = temp;
                    i++;
                    j--;
                }
            }
            if (low < j)
                sortArrayBS(ages, low, j);
            if (high > i)
                sortArrayBS(ages, i, high);
        }
        public static void sortArrayQS(int[] ages, int low, int high) // Quick Sort Method
        {
            if (ages == null || ages.Length == 0)
                return;
            if (low >= high)
                return;
            // pick the pivot 
            int middle = low + (high - low) / 2;
            int pivot = ages[middle];
            // make left < pivot and right > pivot 
            int i = low, j = high;
            while (i <= j)
            {
                while (ages[i] < pivot)
                {
                    i++;
                }
                while (ages[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = ages[i];
                    ages[i] = ages[j];
                    ages[j] = temp;
                    i++;
                    j--;
                }
            }
            // recursively sort two sub parts 
            if (low < j)
                sortArrayQS(ages, low, j);
            if (high > i)
                sortArrayQS(ages, i, high);
        }
    }
}
        