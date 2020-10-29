using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Enumerator
    {
        public List<int> List { get; }
        public Enumerator()
        {
            List = new List<int> { 1, 2, 3, 4, 5 };
        }

        public IEnumerable<int> Calculate()
        {
            IEnumerator<int> enumerator = List.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if(enumerator.Current <= 3)
                    yield return Calculate(enumerator);
                else
                    yield return Move(enumerator);
            }
        }

        /// <summary>
        /// The Enumerator has its current index maintained internaly
        /// </summary>
        /// <param name="enumerator"></param>
        /// <returns></returns>
        private int Calculate(IEnumerator<int> enumerator)
        {
            return enumerator.Current * 2;
        }

        private int Move(IEnumerator<int> enumerator)
        {
            while (enumerator.MoveNext())
            {
            }

            return -1;
        }
    }
}
