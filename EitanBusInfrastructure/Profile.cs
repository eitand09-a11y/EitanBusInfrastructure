using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBudInfrastructure
{
    public class Profile:BaseEntity
    {
        private string first_name;
        private string last_name;
        private string phone_number;
        private string email;
        private string pass;
        private bool is_active;
        private Cities city;

        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Email { get => email; set => email = value; }
        public string Pass { get => pass; set => pass = value; }
        public bool Is_active { get => is_active; set => is_active = value; }
        public Cities City { get => city; set => city = value; }
    }
}
