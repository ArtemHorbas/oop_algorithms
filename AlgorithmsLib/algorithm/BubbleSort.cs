namespace AlgorithmLib
{
    public class BubbleSort : Algorithm
    { 
        public BubbleSort(Sequence sequence) : base(sequence) { }

        public override void Sort()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Count - 1; j++)
                {
                    if (Data[j] > Data[j + 1])
                    {
                        int tmp = Data[j];
                        Data[j] = Data[j + 1];
                        Data[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
