using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment4B
{
    class unit4B
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
            int[] studentGrades = { 65, 95, 75, 55, 560, 90, 98, 88, 97, 78 };
            Console.Write("The unsorted list of grades is: [");
            for (int i = 0; i <= studentGrades.GetUpperBound(0); i++)
            {
                Console.Write(studentGrades[i]);
                if (i != studentGrades.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();

            // Asc Order
            int low = 0;
            int high = studentGrades.Length - 1;
            sortArrayBS(studentGrades, low, high);
            Console.Write("The grades in ascending order are: [");
            for (int i = 0; i <= studentGrades.GetUpperBound(0); i++)
            {
                Console.Write(studentGrades[i]);
                if (i != studentGrades.GetUpperBound(0))
                {
                    Console.Write(",");
                    
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();

            // Desc Order;
            sortArrayBS(studentGrades, high, low);
            Console.Write("The grades in descending order are: [");
            for (int i = studentGrades.Length - 1; i >= studentGrades.GetLowerBound(0); i--)
            {
                Console.Write(studentGrades[i]);
                if (i != studentGrades.GetLowerBound(0))
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
            int[] studentGrades = { 65, 95, 75, 55, 560, 90, 98, 88, 97, 78 };
            Console.Write("The unsorted list of grades is: [");
            for (int i = 0; i <= studentGrades.GetUpperBound(0); i++)
            {
                Console.Write(studentGrades[i]);
                if (i != studentGrades.GetUpperBound(0))
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();

            // Asc Order
            int low = 0;
            int high = studentGrades.Length - 1;
            sortArrayQS(studentGrades, low, high);
            Console.Write("The grades in ascending order are: [");
            for (int i = 0; i <= studentGrades.GetUpperBound(0); i++)
            {
                Console.Write(studentGrades[i]);
                if (i != studentGrades.GetUpperBound(0))
                {
                    Console.Write(",");
                    
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();

            // Desc Order;
            Console.Write("The grades in descending order are: [");
            sortArrayQS(studentGrades, high, low);
            for (int i = studentGrades.Length - 1; i >= studentGrades.GetLowerBound(0); i--)
            {
                Console.Write(studentGrades[i]);
                if (i != studentGrades.GetLowerBound(0))
                {
                    Console.Write(",");
                    
                }
            }
            Console.WriteLine("]");
            Console.ReadLine();   
        }

        public static void sortArrayBS(int[] grade, int low, int high) // Bubble Sort Method
                {
            if (grade == null || grade.Length == 0)
                return;

            if (low >= high)
            return;
            int middle = low + (high - low) / 2; int cen = grade[middle];int i = low, j = high;
            while (i <= j)
            {
                while (grade[i] < cen)
                {
                    i++;
                }
                while (grade[j] > cen)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = grade[i];
                    grade[i] = grade[j];
                    grade[j] = temp;
                    i++;
                    j--;
                }
            }
            if (low < j)
                sortArrayBS(grade, low, j);
            if (high > i)
                sortArrayBS(grade, i, high);
        }
        public static void sortArrayQS(int[] grade, int low, int high) // Quick Sort Method
        {
            if (grade == null || grade.Length == 0)
                return;
            if (low >= high)
                return;
            // pick the pivot 
            int middle = low + (high - low) / 2;
            int pivot = grade[middle];
            // make left < pivot and right > pivot 
            int i = low, j = high;
            while (i <= j)
            {
                while (grade[i] < pivot)
                {
                    i++;
                }
                while (grade[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = grade[i];
                    grade[i] = grade[j];
                    grade[j] = temp;
                    i++;
                    j--;
                }
            }
            // recursively sort two sub parts 
            if (low < j)
                sortArrayQS(grade, low, j);
            if (high > i)
                sortArrayQS(grade, i, high);
        }
    }
}
        