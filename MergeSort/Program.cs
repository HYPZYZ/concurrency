﻿using System;
using System.Threading;
using Exercise;
//using Solution;

namespace Program
{
    class MergeSort
    {

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16, 3 , 100, 83, 24, 18, 33, 44, 76 };
            int[] arr2 = { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16, 3 , 100, 83, 24, 18, 33, 44, 76 };
            
            SequentialMergeSort mergeSort = new SequentialMergeSort(arr1);
            
            mergeSort.printContent("\n Before the sequential merge-sort \n");
            mergeSort.sortSeq(0, arr1.Length - 1);
            mergeSort.printContent("\n After the sequential merge-sort \n");

            ConcurrentMergeSort concurrentMergeSort = new ConcurrentMergeSort(arr2);

            concurrentMergeSort.printContent("\n Before the concurrent merge-sort \n");
            concurrentMergeSort.sortCon(0, arr1.Length - 1);
            concurrentMergeSort.printContent("\n After the concurrent merge-sort \n");
            
            // #TODO:
            // uncomment this only if the solution is available
            //Console.WriteLine("\n Now concurrent sort will be running ...\n");
            //SolutionConcurrentMergeSort concMergeSort = new SolutionConcurrentMergeSort();
            //concMergeSort.sortCon(arr);

        }
    }
}
