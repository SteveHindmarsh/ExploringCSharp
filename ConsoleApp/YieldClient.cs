using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class YieldClient
    {
        public YieldServer YieldServer { get; }
        public YieldClient()
        {
            YieldServer = new YieldServer();
        }
        public void IterateList()
        {
            foreach (int item in YieldServer.List)
            {

            }
        }
    }
}
