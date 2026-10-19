using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class RoadsDB : BaseDB
    {
        public RoadsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Roads";
            RoadsList roadsList = new RoadsList(base.Select());
            return roadsList;
        }

        public override BaseEntity NewEntity()
        {
            return new Roads();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Roads r = entity as Roads;
            r.Start_latitude = reader["Start_latitude"].ToString();
            r.Start_longitude = reader["Start_longitude"].ToString();
            r.End_latitude = reader["End_latitude"].ToString();
            r.End_longitude = reader["End_longitude"].ToString();
            r.Arrival_time = TimeOnly.Parse(reader["Arrival_time"].ToString()); // המרה לTIMEONLY
            r.Day = DaysInWeekDB.SelectById(Convert.ToInt32(reader["Day"]));
            r.Profile_id = ProfileDB.SelectById((int)reader["Profile_id"]);
            base.CreateModel(entity);
            return entity;
        }

        public static RoadsList list;

        public static Roads SelectById(int id)
        {
            RoadsDB db = new RoadsDB();
            list = db.SelectAll();

            Roads r = list.Find(item => item.Id == id);
            return r;
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
            throw new NotImplementedException();
        }
    }
}
