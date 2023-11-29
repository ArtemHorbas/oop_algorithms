using AlghorithmLib;

namespace AlgorithmsLib
{
    public class InsertionSort : Algorithm
    {
        public InsertionSort(Sequence sequence) : base(sequence) { }

        public override void Sort()
        {
            int i, key, j;
            for (i = 1; i < Count; i++)
            {
                key = Data[i];
                j = i - 1;

                while (j >= 0 && Data[j] > key)
                {
                    Data[j + 1] = Data[j];
                    j -= 1;
                }
                Data[j + 1] = key;
            }
        }
    }
}
