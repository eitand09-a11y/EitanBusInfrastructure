using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBudInfrastructure
{
    public class StreetsList:List<Streets>
    {
        public StreetsList() { }
        public StreetsList(IEnumerable<Streets> list) : base(list) { }
        public StreetsList(IEnumerable<BaseEntity> list) : base(list.Cast<Streets>().ToList()) { }
    }
}
