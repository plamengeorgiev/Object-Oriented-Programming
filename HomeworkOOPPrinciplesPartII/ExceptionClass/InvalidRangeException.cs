using System;

namespace ExceptionClass
{
    public class InvalidRangeExeption<T> : ApplicationException
    {
        private T min;
        private T max;

        public T Min
        {
            get
            {
                return this.min;
            }
            set
            {
                this.min = value;
            }
        }
        public T Max
        {
            get
            {
                return this.max;
            }
            set
            {
                this.max = value;
            }
        }
        public InvalidRangeExeption(string msg, T min, T max)
            : base(msg)
        {
            this.Min = min;
            this.Max = max;
        }
    }
}
