using System;
using AlgorithmLib;

namespace AlgorithmsConsole
{
    public class Program
    {
        static void Main()
        {
            Algorithm alg = new MergeSort(new DescendingSequence(10000));
            alg.Sort();
            Console.WriteLine(alg.Data);
        }
    }
}
