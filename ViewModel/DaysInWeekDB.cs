using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EitanBusInfrastructure;
using System.Data.OleDb;

namespace ViewModel
{
    public class DaysInWeekDB : BaseDB
    {
        public DaysInWeekList SelectAll()
        {
            command.CommandText = $"SELECT * FROM DaysInWeek";
            DaysInWeekList daysInWeekList = new DaysInWeekList(base.Select());
            return daysInWeekList;
        }

        public override BaseEntity NewEntity()
        {
            return new DaysInWeek();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            DaysInWeek d = entity as DaysInWeek;
            d.Day = reader["day"].ToString();
            base.CreateModel(entity);
            return entity;
        }

        public static DaysInWeekList list;

        public static DaysInWeek SelectById(int id)
        {
            DaysInWeekDB db = new DaysInWeekDB();
            list = db.SelectAll();

            DaysInWeek d = list.Find(item => item.Id == id);
            return d;
        }

        protected override void CreateDeletedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            throw new NotImplementedException();
        }

        protected override void CreateInsertdSQL(BaseEntity entity, OleDbCommand cmd)
        {
            DaysInWeek d = entity as DaysInWeek;
            if (d != null)
            {
                string sqlStr = "INSERT INTO DaysInWeek ([day]) VALUES (@day)";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@day", d.Day));
            }
        }

        protected override void CreateUpdatedSQL(BaseEntity entity, OleDbCommand cmd)
        {
            DaysInWeek d = entity as DaysInWeek;
            if (d != null)
            {
                string sqlStr = "UPDATE DaysInWeek SET [day]=@day " +
                    "WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@day", d.Day));
                command.Parameters.Add(new OleDbParameter("@id", d.Id));
            }
        }
    }
}
