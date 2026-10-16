using EitanBudInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class BusStops:BaseEntity
    {
        private string stop_name;
        private string stop_number;
        private string longitude;
        private string latitude;

        public string Stop_name { get => stop_name; set => stop_name = value; }
        public string Stop_number { get => stop_number; set => stop_number = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        public string Latitude { get => latitude; set => latitude = value; }
    }
}
