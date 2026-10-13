using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBudInfrastructure
{
    public class ProfileList:List<Profile>
    {
        public ProfileList() { }
        public ProfileList(IEnumerable<Profile> list) : base(list) { }
        public ProfileList(IEnumerable<BaseEntity> list) : base(list.Cast<Profile>().ToList()) { }
    }
}
