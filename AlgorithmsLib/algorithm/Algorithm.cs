using System.Diagnostics;

namespace AlghorithmLib
{
    abstract public class Algorithm
    {
        private long? time = null;
        private Sequence sequence;

        protected Algorithm(Sequence sequence) 
        {
            this.sequence = sequence;
        }

        public Sequence Data
        {
            get { return sequence; }
        }

        public int Count
        {
            get
            {
                return sequence.Count;
            }
        }

        public long? Time
        {
            get
            {
                if(time == null) 
                {
                    time = CalculateTime();
                }
                return time;
            }
        }

        private long CalculateTime()
        {
            Stopwatch watch = Stopwatch.StartNew();
            Sort();
            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        abstract public void Sort();
    }
}
