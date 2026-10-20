using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BusLineStopsDB:BaseDB
    {
        public BusLineStopsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM BusLineStops";
            BusLineStopsList busLineStopsList = new BusLineStopsList(base.Select());
            return busLineStopsList;
        }

        public override BaseEntity NewEntity()
        {
            return new BusLineStops();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            BusLineStops bls = entity as BusLineStops;
            bls.Line_number = BusLinesDB.SelectById((int)reader["Line_number"]);
            bls.Stop_number = BusStopsDB.SelectById((int)reader["Stop_number"]);
            bls.Stop_order = Convert.ToInt32(reader["Stop_order"].ToString());
            base.CreateModel(entity);
            return entity;
        }

        public static BusLineStopsList list;

        public static BusLineStops SelectById(int id)
        {
            BusLineStopsDB db = new BusLineStopsDB();
            list = db.SelectAll();

            BusLineStops b = list.Find(item => item.Id == id);
            return b;
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
            BusLineStops bls = entity as BusLineStops;
            if (bls != null)
            {
                string sqlStr = "UPDATE BusLineStops SET [Line_number]=@lineNumber, [Stop_number]=@stopNumber, [Stop_order]=@stopOrder " +
                    "WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@lineNumber", bls.Line_number.Id));
                command.Parameters.Add(new OleDbParameter("@stopNumber", bls.Stop_number.Id));
                command.Parameters.Add(new OleDbParameter("@stopOrder", bls.Stop_order));
                command.Parameters.Add(new OleDbParameter("@id", bls.Id));
            }
        }
    }
}
