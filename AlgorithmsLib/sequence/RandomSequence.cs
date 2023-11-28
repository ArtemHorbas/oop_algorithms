using System;

namespace AlghorithmLib
{
    public class RandomSequence : Sequence
    {
        public RandomSequence(int length) : base(length) { }

        protected override void InputSequence()
        {
            Random rand = new Random();
            for(int i = 0; i < Count; i++) 
            {
                this[i] = rand.Next(100);
            }
        }
    }
}
