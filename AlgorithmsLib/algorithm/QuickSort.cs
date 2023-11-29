using AlghorithmLib;
using System.Collections.Generic;

namespace AlgorithmsLib
{
    public class QuickSort : Algorithm
    {
        public QuickSort(Sequence sequence) : base(sequence) { }

        public override void Sort()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < Count; i++)
            {
                list.Add(Data[i]);
            }
             
            List<int> sorted = CalculateQuickSort(list);

            for (int i = 0; i < Count; i++) 
            {
                Data[i] = sorted[i];
            }
        }

        private List<int> CalculateQuickSort(List<int> sequence) 
        {
            if (sequence.Count <= 1)
            {
                return sequence;
            }

            int pivotIndex = sequence.Count / 2;
            List<int> less = new List<int>();
            List<int> greater = new List<int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == sequence[pivotIndex])
                {
                    continue;
                }
                else if (sequence[i] < sequence[pivotIndex])
                {
                    less.Add(sequence[i]);
                }
                else
                {
                    greater.Add(sequence[i]);
                }
            }

            List<int> res = new List<int>();
            res.AddRange(CalculateQuickSort(less));
            res.Add(sequence[pivotIndex]);
            res.AddRange(CalculateQuickSort(greater));
            return res;
        }
    }
}
