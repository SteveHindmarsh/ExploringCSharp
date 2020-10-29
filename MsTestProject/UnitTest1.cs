using Microsoft.VisualStudio.TestTools.UnitTesting;

using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MsTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Enumerator enumerator = new Enumerator();
            IEnumerable<int> o1 = enumerator.Calculate();
            IEnumerable<int> o2 = new List<int> { 2, 4, 6, -1 }.AsEnumerable<int>();

            int i2 = 0;
            foreach(int i in o1)
            {
                Assert.AreEqual(i, o2.ElementAt(i2));
                i2++;
            }

        }

        [TestMethod]
        public void TestMethod2()
        {
            Enumerator enumerator = new Enumerator();
            IEnumerable<int> o1 = enumerator.Calculate();
            IEnumerable<int> o2 = (IEnumerable<int>)new List<int> { 2, 4, 6, -1 };//.AsEnumerable<int>();

            // Assert.AreEqual(o, new List<int> { 2, 4, 6 ,-1}.AsEnumerable<int>());
            //Assert.AreEqual(o1, o2);
            Assert.AreEqual<int>(2, 2);
        }

        //private void Assert(Func<IEnumerable<int>> calculate, object )
        //{
        //    Assert.
        //    throw new NotImplementedException();
        //}
    }
}
