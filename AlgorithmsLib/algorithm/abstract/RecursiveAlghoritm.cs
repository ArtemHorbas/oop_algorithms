using System.Collections.Generic;

namespace AlgorithmLib
{
    public abstract class RecursiveAlghoritm : Algorithm
    {
        protected RecursiveAlghoritm(Sequence sequence) : base(sequence) { }

        public override void Sort()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < Count; i++)
            {
                list.Add(Data[i]);
            }

            RecursiveImplementation(list);

            for (int i = 0; i < Count; i++)
            {
                Data[i] = list[i];
            }
        }

        protected abstract void RecursiveImplementation(IList<int> sequence);
    }
}
