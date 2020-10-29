using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class YieldServer
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

        public IEnumerable<int> FilterWithRetainedLocalStatus(int minValue, int maxValue)
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

        public IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }
    }
}
