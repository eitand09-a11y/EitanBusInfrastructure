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

        public int Line_number { get => line_number; set => line_number = value; }
        public Cities City_id { get => city_id; set => city_id = value; }
        public int Average_daily_passangers { get => average_daily_passangers; set => average_daily_passangers = value; }
        public int Frequency_minutes { get => frequency_minutes; set => frequency_minutes = value; }
    }
}
