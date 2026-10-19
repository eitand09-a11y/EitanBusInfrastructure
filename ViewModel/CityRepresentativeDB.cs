using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EitanBusInfrastructure;
using System.Data.OleDb;

namespace ViewModel
{
    public class CityRepresentativeDB : ProfileDB
    {
        public CityRepresentativeList SelectAll()
        {
            command.CommandText = $"SELECT        Profile.ID, Profile.first_name, Profile.last_name, Profile.phone_number, Profile.email, Profile.pass, Profile.is_active, Profile.city\r\nFROM            (CityRepresentative INNER JOIN\r\n                         Profile ON CityRepresentative.ID = Profile.ID)";
            CityRepresentativeList cityRepresentativeList = new CityRepresentativeList(base.Select());
            return cityRepresentativeList;
        }

        public override BaseEntity NewEntity()
        {
            return new CityRepresentative();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            CityRepresentative cr = entity as CityRepresentative;
            base.CreateModel(entity);
            return entity;
        }

        public static CityRepresentativeList list;

        public static CityRepresentative SelectById(int id)
        {
            CityRepresentativeDB db = new CityRepresentativeDB();
            list = db.SelectAll();

            CityRepresentative cr = list.Find(item => item.Id == id);
            return cr;
        }
    }
}
