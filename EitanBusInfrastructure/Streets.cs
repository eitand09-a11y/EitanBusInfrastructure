using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBudInfrastructure
{
    public class Streets:BaseEntity
    {
        private Cities city_symbol;
        private int street_symbol;
        private string street_name;

        public Cities City_symbol { get => city_symbol; set => city_symbol = value; }
        public int Street_symbol { get => street_symbol; set => street_symbol = value; }
        public string Street_name { get => street_name; set => street_name = value; }
    }
}
