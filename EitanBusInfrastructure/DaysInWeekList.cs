using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class DaysInWeekList:List<DaysInWeek>
    {
        public DaysInWeekList() { }
        public DaysInWeekList(IEnumerable<DaysInWeek> list) : base(list) { }
        public DaysInWeekList(IEnumerable<BaseEntity> list) : base(list.Cast<DaysInWeek>().ToList()) { }
    }
}
