using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RateСurrency
{
    internal class RateCurrency<T>
    {
        private List<T> rateHistory = new List<T>();
        public void ChangeRate(T newRate)
        {
            rateHistory.Add(newRate);
            Console.WriteLine($"New rate: {newRate}");
        }

        public void PrintHistory()
        {
            Console.WriteLine("Exchange Rate History:");
            foreach (var rate in rateHistory)
            {
                Console.WriteLine(rate);
            }
        }
    }
}
