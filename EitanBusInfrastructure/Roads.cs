using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBudInfrastructure
{
    public class Roads:BaseEntity
    {
        private Streets start_point;
        private Streets end_point;
        private TimeOnly arrival_time;
        private DayOfWeek day;
        private Profile id_user;

        public Streets Start_point { get => start_point; set => start_point = value; }
        public Streets End_point { get => end_point; set => end_point = value; }
        public TimeOnly Arrival_time { get => arrival_time; set => arrival_time = value; }
        public DayOfWeek Day { get => day; set => day = value; }
        public Profile Id_user { get => id_user; set => id_user = value; }
    }
}
