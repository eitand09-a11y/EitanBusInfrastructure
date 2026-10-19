using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class CityRepresentativeList:List<CityRepresentative>
    {
        public CityRepresentativeList() { }
        public CityRepresentativeList(IEnumerable<CityRepresentative> list) : base(list) { }
        public CityRepresentativeList(IEnumerable<BaseEntity> list) : base(list.Cast<CityRepresentative>().ToList()) { }
    }
}
