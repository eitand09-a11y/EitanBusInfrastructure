using EitanBusInfrastructure;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class RegionsDB:BaseDB
    {
        public RegionsList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Regions";
            RegionsList regionsList = new RegionsList(base.Select());
            return regionsList;
        }

        public override BaseEntity NewEntity()
        {
            return new Regions();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Regions r = entity as Regions;
            r.Region_name = reader["Region_name"].ToString();
            base.CreateModel(entity);
            return entity;
        }

        public static RegionsList list;

        public static Regions SelectById(int id)
        {
            RegionsDB db = new RegionsDB();
            list = db.SelectAll();

            Regions d = list.Find(item => item.Id == id);
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
            Regions r = entity as Regions;
            if (r != null)
            {
                string sqlStr = "UPDATE Regions SET [region_name]=@regionName " +
                    "WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@regionName", r.Region_name));
                command.Parameters.Add(new OleDbParameter("@id", r.Id));
            }
        }
    }
}
