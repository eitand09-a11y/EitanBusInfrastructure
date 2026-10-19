using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EitanBusInfrastructure;
using System.Data.OleDb;

namespace ViewModel
{
    public class ProfileDB : BaseDB
    {
        public ProfileList SelectAll()
        {
            command.CommandText = $"SELECT * FROM Profile";
            ProfileList profileList = new ProfileList(base.Select());
            return profileList;
        }

        public override BaseEntity NewEntity()
        {
            return new Profile();
        }

        protected override BaseEntity CreateModel(BaseEntity entity)
        {
            Profile p = entity as Profile;
            p.First_name = reader["first_name"].ToString();
            p.Last_name = reader["last_name"].ToString();
            p.Phone_number = reader["phone_number"].ToString();
            p.Email = reader["email"].ToString();
            p.Pass = reader["pass"].ToString();
            p.Is_active = Convert.ToBoolean(reader["is_active"].ToString());
            p.City = CitiesDB.SelectById((int)reader["city"]);
            base.CreateModel(entity);
            return entity;
        }

        public static ProfileList list;

        public static Profile SelectById(int id)
        {
            ProfileDB db = new ProfileDB();
            list = db.SelectAll();

            Profile p = list.Find(item => item.Id == id);
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
            throw new NotImplementedException();
        }
    }
}
