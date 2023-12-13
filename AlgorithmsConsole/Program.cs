using System;
using AlgorithmLib;

namespace AlgorithmsConsole
{
    public class Program
    {
        static void Main()
        {
            Algorithm[,] algs = new Algorithm[5, 3] 
            {
                { new BubbleSort(new DescendingSequence(100)), new BubbleSort(new AscendingSequence(1000)), new BubbleSort(new RandomSequence(3000)) },
                { new SelectionSort(new AscendingSequence(100)), new SelectionSort(new DescendingSequence(1000)), new SelectionSort(new RandomSequence(3000)) },
                { new InsertionSort(new RandomSequence(100)), new InsertionSort(new AscendingSequence(1000)), new InsertionSort(new DescendingSequence(3000)) },
                { new MergeSort(new DescendingSequence(10000)), new MergeSort(new AscendingSequence(100000)), new MergeSort(new RandomSequence(1000000)) },
                { new QuickSort(new DescendingSequence(10000)), new QuickSort(new AscendingSequence(100000)), new QuickSort(new RandomSequence(1000000)) }
            };

            for (int i = 0; i < algs.GetLength(0); i++)
            {
                for (int j = 0; j < algs.GetLength(1); j++)
                {
                    Console.WriteLine($"{algs[i,j].GetType().Name} --> {algs[i, j].Count}: {algs[i, j].Time}ms");
                    if (algs[i, j].Count <= 100)
                    {
                        Console.WriteLine(algs[i, j].Data);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
