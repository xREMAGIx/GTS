using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTS
{
    class Passenger
    {
        public int number { get; set; }
        public int priority { get; set; }

        public void generate(int numberOfPassenger)
        {
            number = numberOfPassenger;
            Random rnd = new Random();
            double percentage = rnd.NextDouble();
            if (percentage <= 0.1)
                priority = 1;
            else if (percentage <= (0.3 + 0.1))
                priority = 2;
            else priority = 3;
        }
    }
}
