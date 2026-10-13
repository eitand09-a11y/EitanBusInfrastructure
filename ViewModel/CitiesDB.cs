using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EitanBudInfrastructure;
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
            c.Transliteration = reader["transliteration"].ToString();
            c.Religion = (int)reader["Religion"];
            c.Population = (int)reader["Population"];
            c.Cordinates = (int)reader["Coordinates"];
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
    }
}
