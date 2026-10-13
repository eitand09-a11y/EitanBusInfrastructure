using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBudInfrastructure
{
    public class RoadsList:List<Roads>
    {
        public RoadsList() { }
        public RoadsList(IEnumerable<Roads> list) : base(list) { }
        public RoadsList(IEnumerable<BaseEntity> list) : base(list.Cast<Roads>().ToList()) { }
    }
}
