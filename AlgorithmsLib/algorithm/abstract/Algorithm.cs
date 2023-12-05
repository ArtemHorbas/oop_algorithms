using System.Diagnostics;

namespace AlgorithmLib
{
    public abstract class Algorithm
    {
        private double time;
        private Sequence sequence;

        protected Algorithm(Sequence sequence) 
        {
            time = 0;
            this.sequence = sequence;
        }

        public Sequence Data
        {
            get { return sequence; }
            set { sequence = value; }
        }

        public int Count
        {
            get
            {
                return sequence.Count;
            }
        }

        public double Time
        {
            get
            {
                if(time == 0) 
                {
                    time = CalculateTime();
                }
                return time;
            }
        }

        private double CalculateTime()
        {
            Stopwatch watch = Stopwatch.StartNew();
            Sort();
            watch.Stop();
            return watch.Elapsed.TotalMilliseconds;
        }

        public abstract void Sort();
    }
}
