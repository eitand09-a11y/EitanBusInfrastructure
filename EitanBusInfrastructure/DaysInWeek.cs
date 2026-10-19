using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class DaysInWeek:BaseEntity
    {
        private string day;

        public string Day { get => day; set => day = value; }
    }
}
