using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class RegionsList : List<Regions>
    {
        public RegionsList() { }
        public RegionsList(IEnumerable<Regions> list) : base(list) { }
        public RegionsList(IEnumerable<BaseEntity> list) : base(list.Cast<Regions>().ToList()) { }
    }
}
