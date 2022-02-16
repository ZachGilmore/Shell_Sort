/*
Dev: Zach Gilmore
Date: 2/12/22
For: Data Structures and Algorithms
Purpose: To demonstrate array sorting
*/

using System;
using static System.Console;

namespace An_Array_of_Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingWithArrays test = new WorkingWithArrays();

            //Write(test);    //Testing the constructor to make sure is populating the ary correctly            
            test.printTheArray();
            WriteLine();
            test.insertAnInteger(0, 0);            
            test.sortTheArray();
            test.printTheSortedArray();
        }
    }
}
