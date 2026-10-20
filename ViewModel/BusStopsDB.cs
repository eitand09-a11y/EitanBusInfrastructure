using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BusStopsDB : BaseDB
    {
        public BusStopsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM BusStops";
            BusStopsList busStopsList = new BusStopsList(base.Select());
            return busStopsList;
        }

        public override BaseEntity NewEntity()
        {
            return new BusStops();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            BusStops b = entity as BusStops;
            b.Stop_name = reader["Stop_name"].ToString();
            b.Stop_number = reader["Stop_number"].ToString();
            b.Longitude = reader["Longitude"].ToString();
            b.Latitude = reader["Latitude"].ToString();
            base.CreateModel(entity);
            return entity;
        }

        public static BusStopsList list;

        public static BusStops SelectById(int id)
        {
            BusStopsDB db = new BusStopsDB();
            list = db.SelectAll();

            BusStops d = list.Find(item => item.Id == id);
            return d;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            BusStops bs = entity as BusStops;
            if (bs != null)
            {
                string sqlStr = "UPDATE BusStops SET [Stop_name]=@stopName, [Stop_number]=@stopNumber, [Longitude]=@longitude, [Lantitude]=@latitude " +
                    "WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@stopName", bs.Stop_name));
                command.Parameters.Add(new OleDbParameter("@stopNumber", bs.Stop_number));
                command.Parameters.Add(new OleDbParameter("@longitude", bs.Longitude));
                command.Parameters.Add(new OleDbParameter("@latitude", bs.Latitude));
                command.Parameters.Add(new OleDbParameter("@id", bs.Id));
            }
        }
    }
}
