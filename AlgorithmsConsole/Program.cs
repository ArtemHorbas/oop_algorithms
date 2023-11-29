using AlghorithmLib;
using AlgorithmsLib;
using AlgorithmsLib.algorithm;
using System;

namespace AlgorithmsConsole
{
    public class Program
    {
        static void Main()
        {
            Algorithm alg = new BubbleSort(new DescendingSequence(20));
            alg.Sort();
            Console.WriteLine(alg.Data);


            alg = new SelectionSort(new DescendingSequence(20));
            alg.Sort();
            Console.WriteLine(alg.Data);

            alg = new QuickSort(new DescendingSequence(20));
            alg.Sort();
            Console.WriteLine(alg.Data);
        }
    }
}
