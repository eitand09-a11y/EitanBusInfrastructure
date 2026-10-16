using EitanBudInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class BusStopsList:List<BusStops>
    {
        public BusStopsList() { }
        public BusStopsList(IEnumerable<BusStops> list) : base(list) { }
        public BusStopsList(IEnumerable<BaseEntity> list) : base(list.Cast<BusStops>().ToList()) { }
    }
}
