using AlghorithmLib;
using AlgorithmsLib.algorithm;
using System;

namespace AlgorithmsConsole
{
    public class Program
    {
        static void Main()
        {
            Algorithm alg = new BubbleSort(new RandomSequence(10));         
            Console.WriteLine(alg.Count);
            alg = new SelectionSort(new RandomSequence(10));
            alg.Sort();
            Console.WriteLine(alg.Data);
        }
    }
}
