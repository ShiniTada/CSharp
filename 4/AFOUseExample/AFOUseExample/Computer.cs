using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFOUseExample
{
    class Computer
    {
        public string Date { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }

        public Computer(string date, string type, int amount)
        {
            Date = date;
            Type = type;
            Amount = amount;
        }

        public Computer()
        {
        }
    }
}
