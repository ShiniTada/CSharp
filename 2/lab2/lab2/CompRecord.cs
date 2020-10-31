using System;

namespace lab2
{
    public class CompRecord
    {
        private DateTime date;
        private int compCount;

        public CompRecord() { }

        public CompRecord(DateTime date, int compCount)
        {
            this.date = date;
            this.compCount = compCount;
        }
        public DateTime Date
        {
            get => date;
            set => date = value;
        }
        

        public int CompCount
        {
            get => compCount;
            set => compCount = value;
        }

        public override string ToString()
        {
            return date.ToShortDateString() + ": " + compCount + " компьютеров";
        }
    }
}