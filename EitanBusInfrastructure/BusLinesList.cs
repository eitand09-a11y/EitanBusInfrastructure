using EitanBudInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class BusLinesList:List<BusLines>
    {
        public BusLinesList() { }
        public BusLinesList(IEnumerable<BusLines> list) : base(list) { }
        public BusLinesList(IEnumerable<BaseEntity> list) : base(list.Cast<BusLines>().ToList()) { }
    }
}
