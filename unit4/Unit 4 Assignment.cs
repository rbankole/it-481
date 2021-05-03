using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace unit4assignment
{
    public class program
    {
        static void main(string[] args)
        {
            Main1();
            Main2();
            Main3();
        }


        public static void Main1()
        //************************************************************************************
        // given an array of integers, and a number of times to look, return the minimum value            
        //************************************************************************************            
        {
            int[] arr = new int[5] {9, 25, 11, 82, 27};
            int i, min, n;
            // size of the array
            n = 5;
            min = arr[0];
            for(i=1; i<n; i++) {
                if(arr[i]<min) {
                    min = arr[i];
                }
            }
            Console.WriteLine("**********Section 1 * *********");
            Console.WriteLine();
            Console.Write("The minimum value in array is {0}\n\n", min);
        }


        //*************************************************
        // given an array of integers, print out each value            
        //*************************************************
         static void Main2()
        {
            int[] arr = new int[5] {9, 25, 11, 82, 27};
            foreach (var item in arr) {
                Console.WriteLine("**********Section 2 * *********");
                Console.WriteLine();
                Console.WriteLine(item.ToString());
            }
        }



        //*****************************************************************************
        // given two integer search values if they are equal to the values in the array            
        //*****************************************************************************
         static void Main3()
        {
            int[] arr = new int[5] {9, 25, 11, 82, 27};
            // Using Exists() method
            Console.WriteLine("**********Section 3 * *********");
            Console.WriteLine();

            Console.WriteLine("Is 11 part of array: {0}",
            Array.Exists(arr, element => element == 11));

            Console.WriteLine("Is 15Z part of array: {0}",
            Array.Exists(arr, element => element == 15));
            
        }
        
	}
    
}