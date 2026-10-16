using EitanBudInfrastructure;
using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BusLinesDB:BaseDB
    {
        public BusLinesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM BudLines";
            BusLinesList busLinesList = new BusLinesList(base.Select());
            return busLinesList;
        }

        public override BaseEntity NewEntity()
        {
            return new BusLines();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            BusLines b = entity as BusLines;
            b.Line_number = Convert.ToInt32(reader["Line_number"].ToString());
            b.City_id = CitiesDB.SelectById((int)reader["City_id"]);
            b.Average_daily_passangers = Convert.ToInt32(reader["Average_daily_passangers"].ToString());
            b.Frequency_minutes = Convert.ToInt32(reader["Frequency_minutes"].ToString());
            base.CreateModel(entity);
            return entity;
        }

        public static BusLinesList list;

        public static BusLines SelectById(int id)
        {
            BusLinesDB db = new BusLinesDB();
            list = db.SelectAll();

            BusLines p = list.Find(item => item.Id == id);
            return p;
        }
    }
}
