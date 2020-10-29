using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class YieldServer
    {
        public List<int> List { get; }
        public YieldServer()
        {
            List = new List<int> { 1, 2, 3, 4, 5 };
        }

        public IEnumerable<int> All()
        {
            foreach (int i in List)
            {
                yield return i;
            }
        }
        public IEnumerable<int> Filter(int minValue)
        {
            foreach (int i in List)
            {
                if (i >= minValue)
                    yield return i;
            }
        }

        public IEnumerable<int> FilterWithStatus(int minValue, int maxValue)
        {
            int total = 0;
            foreach (int i in List)
            {
                if (i >= minValue && i <= maxValue)
                {
                    total = total + i;
                    yield return i;
                    yield return total;
                }
            }
        }
    }
}
