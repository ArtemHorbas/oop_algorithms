using System.Collections.Generic;

namespace AlgorithmLib
{
    public class MergeSort : RecursiveAlghoritm
    {
        public MergeSort(Sequence sequence) : base(sequence) { }

        override protected void RecursiveImplementation(IList<int> inputSequence)
        {
            if(inputSequence.Count <= 1)
            {
                return;
            }

            int midIndex = inputSequence.Count / 2;
            int[] leftHalf = new int[midIndex];
            int[] rightHalf = new int[inputSequence.Count - midIndex];

            for(int i = 0; i < midIndex; i++)
            {
                leftHalf[i] = inputSequence[i];
            }

            for(int i = midIndex; i < inputSequence.Count; i++)
            {
                rightHalf[i - midIndex] = inputSequence[i];
            }

            RecursiveImplementation(leftHalf);
            RecursiveImplementation(rightHalf);
            Merge(inputSequence, leftHalf, rightHalf);
        }

        private void Merge(IList<int> inputSequence, IList<int> leftHalf, IList<int> rightHalf)
        {
            int i = 0, j = 0, k = 0;
            while(i < leftHalf.Count && j < rightHalf.Count)
            {
                if (leftHalf[i] <= rightHalf[j])
                {
                    inputSequence[k] = leftHalf[i];
                    i++;
                }
                else
                {
                    inputSequence[k] = rightHalf[j];
                    j++;
                }
                k++;
            }

            while (i < leftHalf.Count)
            {
                inputSequence[k] = leftHalf[i];
                i++;
                k++;
            }

            while (j < rightHalf.Count)
            {
                inputSequence[k] = rightHalf[j];
                j++;
                k++;
            }
        }
    }
}
