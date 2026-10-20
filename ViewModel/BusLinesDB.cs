using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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
            BusLines bl = entity as BusLines;
            if (bl != null)
            {
                string sqlStr = "UPDATE BusLines SET [Line_number]=@lineNumber, [City_id]=@cityId, [Average_daily_passangers]=@passangers, [Frequency_minutes]=@frequency, [Is_forward]=@isForward, [Start_stop]=@start, [End_stop]=@end " +
                    "WHERE ID=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@lineNumber", bl.Line_number));
                command.Parameters.Add(new OleDbParameter("@cityId", bl.City_id.Id));
                command.Parameters.Add(new OleDbParameter("@passangers", bl.Average_daily_passangers));
                command.Parameters.Add(new OleDbParameter("@frequency", bl.Frequency_minutes));
                command.Parameters.Add(new OleDbParameter("@isForward", bl.Is_forward));
                command.Parameters.Add(new OleDbParameter("@start", bl.Start_stop.Id));
                command.Parameters.Add(new OleDbParameter("@end", bl.End_stop.Id));
                command.Parameters.Add(new OleDbParameter("@id", bl.Id));
            }
        }
    }
}
