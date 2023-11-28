namespace AlghorithmLib
{
    public class AscendingSequence : Sequence
    {
        public AscendingSequence(int length) : base(length) { }

        override protected void InputSequence()
        {
            for(int i = 0; i < Count; i++)
            {
                this[i] = i;
            }
        }
    }
}
