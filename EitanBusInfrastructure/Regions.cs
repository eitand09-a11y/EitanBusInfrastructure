using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class Regions:BaseEntity
    {
        private string region_name;

        public string Region_name { get => region_name; set => region_name = value; }
    }
}
