using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class YieldClient
    {
        public YieldServer YieldServer { get; }
        public IEnumerable<int> All { get; }
        public IEnumerable<int> Filter { get; }
        public IEnumerable<int> FilterWithRetainedLocalStatus { get; }
        public IEnumerable<int> Power { get; }

        public YieldClient()
        {
            YieldServer = new YieldServer();
            All = YieldServer.All();
            Filter = YieldServer.Filter(3);
            FilterWithRetainedLocalStatus = YieldServer.FilterWithRetainedLocalStatus(3, 5);
            Power = YieldServer.Power(3, 4);
        }
    }
}
