using EitanBudInfrastructure;
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
                Console.WriteLine(c.City_name);
        }
    }
}
