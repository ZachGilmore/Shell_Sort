using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace An_Array_of_Sorts
{
    class WorkingWithArrays
    {
        private int[] testAry = new int[10];
        private int[] testSort = new int[10];

        private Random rng = new Random();

        public WorkingWithArrays()
        {
            for(int i = 0; i < testAry.Length; i++)
            {
                testAry[i] = rng.Next(1, 100);
                //Write(ary[i] + " ");      //Array print test
            }
        }

        public void insertAnInteger(int newValue, int arrayPosition)
        {
            try
            {
                Write("Enter the value you wish to insert: ");
                newValue = Convert.ToInt32(ReadLine());
                Write("Enter the index you wish to place (between 0 and 9): ");
                arrayPosition = Convert.ToInt32(ReadLine());
                WriteLine();
                WriteLine("Array with inserted value of {0}:", newValue);

                for (int i = 0; i < testAry.Length; i++)
                {
                    testAry[arrayPosition] = newValue;  //Insert specified number into specified index

                    Write(testAry[i] + " ");           //Write out new array

                }

                WriteLine("\n");
            }
            catch(Exception e)
            {
                WriteLine("\nLooks like there was a problem: {0}", e);
            }
        }

        public void sortTheArray()  //Using Shell Sort
        {
            int gap = 3;            //Interleaved section
            int temp = 0;

            for(int i = 0 + gap; i < testAry.Length; i = i + gap)   //Creating a loop based on the gap size
            {
                int j = i;
                while(j - gap >= 0 && testAry[j] < testAry[j - gap]) //While gap value is less than starting 
                {                                                    //index value
                    temp = testAry[j];                  //Assign the lower value to a temp var
                    testAry[j] = testAry[j - gap];      //Send the higher value to the gap position
                    testAry[j - gap] = temp;            //Assign the lower value to the lower index position
                    j = j - gap;                        //Subtract the gap value from j
                }
            }

            gap = gap / 2;  //Halve the gap

            for(int i = 0; i < testAry.Length; i = i + gap) //Regular insertion sort at this point
            {
                int j = i;
                while(j > 0 && testAry[j] < testAry[j - gap])   //All of this does the same thing as above on a 
                {                                               //smaller scale
                    temp = testAry[j];
                    testAry[j] = testAry[j - gap];
                    testAry[j - gap] = temp;
                    j = j - gap;
                }
            }
        }

        public void printTheArray()
        {
            WriteLine("Unsorted array:");

            for (int i = 0; i < testAry.Length; i++)
            {
                Write(testAry[i] + " ");
            }

            WriteLine();
        }

        public void printTheSortedArray()
        {
            for (int i = 0; i < testSort.Length; i++)   //Assign the sorted array to its new home :)
            {
                testSort[i] = testAry[i];
            }


            WriteLine("\nSorted array:");

            for (int i = 0; i < testSort.Length; i++)
            {
                Write(testSort[i] + " ");
            }

            WriteLine();
        }



    }
}
