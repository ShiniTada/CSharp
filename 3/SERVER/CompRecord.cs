using System;

namespace SERVER
{
    public class CompRecord
    {
        private DateTime date;
        private int compCount;

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public int CompCount
        {
            get
            {
                return compCount;
            }

            set
            {
                compCount = value;
            }
        }

        public CompRecord() { }

        public CompRecord(DateTime date, int compCount)
        {
            this.Date = date;
            this.CompCount = compCount;
        }

        public override string ToString()
        {
            return Date.ToShortDateString() + ": " + CompCount;
        }
    }
}
