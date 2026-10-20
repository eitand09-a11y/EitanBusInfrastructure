using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EitanBusInfrastructure;
using System.Data.OleDb;

namespace ViewModel
{
    public class CitiesDB:BaseDB
    {
        public CitiesList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Cities";
            CitiesList citiesList = new CitiesList(base.Select());
            return citiesList;
        }

        public override BaseEntity NewEntity()
        {
            return new Cities();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Cities c = entity as Cities;
            c.City_name = reader["City_name"].ToString();
            c.Transliteration = reader["Transliteration"].ToString();
            c.Region = RegionsDB.SelectById((int)reader["Region"]);
            c.Population = reader["Population"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Population"]); // שם 0 אם NULL
            c.Cordinates = reader["Coordinates"].ToString();
            base.CreateModel(entity);
            return entity;
        }

        public static CitiesList list;

        public static Cities SelectById(int id)
        {
            CitiesDB db = new CitiesDB();
            list = db.SelectAll();

            Cities c = list.Find(item => item.Id == id);
            return c;
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
            Cities c = entity as Cities;
            if (c != null)
            {
                string sqlStr = "UPDATE Cities SET [City_name]=@cName, [Transliteration]=@transliteration, [Region]=@region, [Population]=@population, [Coordinates]=@cordinates" +
                    " WHERE id=@id";

                command.CommandText = sqlStr;
                command.Parameters.Add(new OleDbParameter("@City_name", c.City_name));
                command.Parameters.Add(new OleDbParameter("@transliteration", c.Transliteration));
                command.Parameters.Add(new OleDbParameter("@region", c.Region.Id));
                command.Parameters.Add(new OleDbParameter("@population", c.Population));
                command.Parameters.Add(new OleDbParameter("@cordinates", c.Cordinates));
                command.Parameters.Add(new OleDbParameter("@id", c.Id));
            }
        }
    }
}
