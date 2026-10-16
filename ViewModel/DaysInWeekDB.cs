using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EitanBudInfrastructure;
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
    }
}
