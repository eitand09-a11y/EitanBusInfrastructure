using EitanBudInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class BusLineStopsList:List<BusLineStops>
    {
        public BusLineStopsList() { }
        public BusLineStopsList(IEnumerable<BusLineStops> list) : base(list) { }
        public BusLineStopsList(IEnumerable<BaseEntity> list) : base(list.Cast<BusLineStops>().ToList()) { }
    }
}
