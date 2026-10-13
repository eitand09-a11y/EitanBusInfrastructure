using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EitanBudInfrastructure;
using System.Data.OleDb;

namespace ViewModel
{
    public class DayInWeekDB : BaseDB
    {
        public DaysInWeekList SelectAll()
        {
            command.CommandText = $"SELECT * FROM DaysInWeek";
            DaysInWeekList daysInWeekList = new DaysInWeekList(base.Select());
            return daysInWeekList;
        }

        public override BaseEntity NewEntity()
        {
            throw new NotImplementedException();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            DaysInWeek d = entity as DaysInWeek;
            d.Day = reader["day"].ToString();
            base.CreateModel(entity);
            return entity;
        }
    }
}
