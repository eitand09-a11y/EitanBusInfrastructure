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

            Cities cityToUpdate = cList[0];
            cityToUpdate.Transliteration += "yyy";
            cdb.Update(cityToUpdate);
            int h = cdb.SaveChanges();
            Console.WriteLine($"{h} rows were updated");
            Console.WriteLine(cityToUpdate.Transliteration);

            DaysInWeekDB ddb = new();
            DaysInWeekList dList = ddb.SelectAll();
            foreach (DaysInWeek d in dList)
                Console.WriteLine(d.Day);

            DaysInWeek dayToUpdate = dList[6];
            dayToUpdate.Day += "yyyy";
            ddb.Update(dayToUpdate);
            int x = ddb.SaveChanges();
            Console.WriteLine($"{x} rows were updated");
            Console.WriteLine(dayToUpdate.Day);

            //BusStopsDB bdb = new();
            //BusStopsList bList = bdb.SelectAll();
            //foreach (BusStops b in bList)
            //    Console.WriteLine(b.Stop_name + ", " + b.Stop_number);

            ProfileDB pdb = new();
            ProfileList pList = pdb.SelectAll();
            foreach (Profile p in pList)
                Console.WriteLine(p.City);

            Profile profileToUpdate = pList[0];
            profileToUpdate.First_name += "yyyy";
            pdb.Update(profileToUpdate);
            int z = pdb.SaveChanges();
            Console.WriteLine($"{z} rows were updated");
            Console.WriteLine(profileToUpdate.First_name);

            //BusLinesDB bldb = new();
            //BusLinesList blList = bldb.SelectAll();
            //foreach (BusLines bl in blList)
            //    Console.WriteLine(bl.City_id);

            //BusLineStopsDB bsldb = new();
            //BusLineStopsList blsList = bsldb.SelectAll();
            //foreach (BusLineStops bls in blsList)
            //    Console.WriteLine(bls.Line_number);

            //RoadsDB rdb = new();
            //RoadsList rList = rdb.SelectAll();
            //foreach (Roads r in rList)
            //    Console.WriteLine(r.Profile_id.First_name);

            //CityRepresentativeDB crdb = new();
            //CityRepresentativeList crList = crdb.SelectAll();
            //foreach (CityRepresentative cr in crList)
            //    Console.WriteLine(cr.Phone_number);

            RegionsDB rsdb = new();
            RegionsList rsList = rsdb.SelectAll();
            foreach (Regions rs in rsList)
                Console.WriteLine(rs.Region_name);

            Regions regionToUpdate = rsList[0];
            regionToUpdate.Region_name += "yyyy";
            rsdb.Update(regionToUpdate);
            int y = rsdb.SaveChanges();
            Console.WriteLine($"{x} rows were updated");
            Console.WriteLine(regionToUpdate.Region_name);
        }
    }
}
