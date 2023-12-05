using System;
using System.Collections.Generic;

namespace AlgorithmLib
{
    public class QuickSort : RecursiveAlghoritm
    {
        public QuickSort(Sequence sequence) : base(sequence) { }

        protected override void RecursiveImplementation(IList<int> sequence)
        {
            RecursiveImplementation(sequence, 0, sequence.Count - 1);
        }

        private void RecursiveImplementation(IList<int> sequence, int lowIndex, int highIndex)
        {
            if(lowIndex >= highIndex)
            {
                return;
            }

            int pivotIndex = new Random().Next(highIndex - lowIndex) + lowIndex;
            int pivot = sequence[pivotIndex];
            Swap(sequence, pivotIndex, highIndex);

            int leftPointer = lowIndex;
            int rightPointer = highIndex;

            while (leftPointer < rightPointer)
            {
                while (sequence[leftPointer] <= pivot && leftPointer < rightPointer)
                {
                    leftPointer++;
                }

                while (sequence[rightPointer] >= pivot && leftPointer < rightPointer)
                {
                    rightPointer--;
                }

                Swap(sequence, leftPointer, rightPointer);
            }

            Swap(sequence, leftPointer, highIndex);

            RecursiveImplementation(sequence, lowIndex, leftPointer - 1);
            RecursiveImplementation(sequence, leftPointer + 1, highIndex);
        }

        private void Swap(IList<int> sequnce, int index1, int index2)
        {
            int tmp = sequnce[index1];
            sequnce[index1] = sequnce[index2];
            sequnce[index2] = tmp;
        }
    }
}
