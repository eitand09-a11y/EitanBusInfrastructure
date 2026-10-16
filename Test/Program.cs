using EitanBudInfrastructure;
using EitanBusInfrastructure;
using ViewModel;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            CitiesDB cdb = new();
            CitiesList cList = cdb.SelectAll();
            foreach (Cities c in cList)
                Console.WriteLine(c.City_name + ", " + c.Region);

            DaysInWeekDB ddb = new();
            DaysInWeekList dList = ddb.SelectAll();
            foreach (DaysInWeek d in dList)
                Console.WriteLine(d.Day);

            BusStopsDB bdb = new();
            BusStopsList bList = bdb.SelectAll();
            foreach (BusStops b in bList)
                Console.WriteLine(b.Stop_name + ", " + b.Stop_number);

            ProfileDB pdb = new();
            ProfileList pList = pdb.SelectAll();
            foreach (Profile p in pList)
                Console.WriteLine(p.City);

            BusLinesDB bldb = new();
            BusLinesList blList = bldb.SelectAll();
            foreach (BusLines bl in blList)
                Console.WriteLine(bl.City_id);

            BusLineStopsDB bsldb = new();
            BusLineStopsList blsList = bsldb.SelectAll();
            foreach (BusLineStops bls in blsList)
                Console.WriteLine(bls.Line_number);

            RoadsDB rdb = new();
            RoadsList rList = rdb.SelectAll();
            foreach (Roads r in rList)
                Console.WriteLine(r.Profile_id.First_name);

            CityRepresentativeDB crdb = new();
            CityRepresentativeList crList = crdb.SelectAll();
            foreach (CityRepresentative cr in crList)
                Console.WriteLine(cr.Phone_number);
        }
    }
}
