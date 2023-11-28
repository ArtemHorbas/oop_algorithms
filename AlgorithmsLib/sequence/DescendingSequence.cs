namespace AlghorithmLib
{
    public class DescendingSequence : Sequence
    {
        public DescendingSequence(int length) : base(length) { }

        protected override void InputSequence()
        {
            for (int i = Count - 1, j = 0; i >= 0; i--, j++)
            {
                this[j] = i;
            }
        }
    }
}
