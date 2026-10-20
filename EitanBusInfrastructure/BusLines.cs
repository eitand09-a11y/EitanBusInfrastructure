using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class BusLines:BaseEntity
    {
        private int line_number;
        private Cities city_id;
        private int average_daily_passangers;
        private int frequency_minutes;
        private bool is_forward;
        private BusStops start_stop;
        private BusStops end_stop;

        public int Line_number { get => line_number; set => line_number = value; }
        public Cities City_id { get => city_id; set => city_id = value; }
        public int Average_daily_passangers { get => average_daily_passangers; set => average_daily_passangers = value; }
        public int Frequency_minutes { get => frequency_minutes; set => frequency_minutes = value; }
        public bool Is_forward { get => is_forward; set => is_forward = value; }
        public BusStops Start_stop { get => start_stop; set => start_stop = value; }
        public BusStops End_stop { get => end_stop; set => end_stop = value; }
    }
}
