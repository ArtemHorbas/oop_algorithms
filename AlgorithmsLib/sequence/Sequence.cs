using System.Collections.Generic;
using System.Text;

namespace AlgorithmLib
{
    public abstract class Sequence
    {
        private IList<int> sequence;

        protected Sequence(int length)
        {
            sequence = new int[length];
            InputSequence();
        }

        public int this[int index]
        {
            get { return sequence[index];  }
            set { sequence[index] = value; }
        }

        public int Count
        {
            get { return sequence.Count; }
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int el in sequence)
            {
                yield return el;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("[ ");
            foreach (int elem in sequence)
            {
                sb.Append(elem).Append(", ");
            }
            string res = sb + "";
            return res.Substring(0, res.Length - 2) + " ]";
        }

        abstract protected void InputSequence();
    }
}
