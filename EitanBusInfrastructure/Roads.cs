using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBusInfrastructure
{
    public class Roads:BaseEntity
    {
        private string start_latitude;
        private string start_longitude;
        private string end_latitude;
        private string end_longitude;
        private TimeOnly arrival_time;
        private DaysInWeek day;
        private Profile profile_id;

        public string Start_latitude { get => start_latitude; set => start_latitude = value; }
        public string Start_longitude { get => start_longitude; set => start_longitude = value; }
        public string End_latitude { get => end_latitude; set => end_latitude = value; }
        public string End_longitude { get => end_longitude; set => end_longitude = value; }
        public TimeOnly Arrival_time { get => arrival_time; set => arrival_time = value; }
        public DaysInWeek Day { get => day; set => day = value; }
        public Profile Profile_id { get => profile_id; set => profile_id = value; }
    }
}
