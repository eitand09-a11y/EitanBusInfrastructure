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
            base.CreateModel(entity);
            return entity;
        }
    }
}
