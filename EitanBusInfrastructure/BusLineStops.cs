using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class BusLineStops:BaseEntity
    {
        private BusLines line_number;
        private BusStops stop_number;
        private int stop_order;

        public BusLines Line_number { get => line_number; set => line_number = value; }
        public BusStops Stop_number { get => stop_number; set => stop_number = value; }
        public int Stop_order { get => stop_order; set => stop_order = value; }
    }
}
