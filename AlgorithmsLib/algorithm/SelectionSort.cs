namespace AlgorithmLib
{
    public class SelectionSort : Algorithm
    {
        public SelectionSort(Sequence sequence) : base(sequence) { }

        public override void Sort()
        {
            for(int i = 0; i < Count; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < Count; j++)
                {
                    if (Data[minIndex] > Data[j])
                    {
                        minIndex = j;
                    }
                }
                int tmp = Data[minIndex];
                Data[minIndex] = Data[i];
                Data[i] = tmp;
            }
        }
    }
}
