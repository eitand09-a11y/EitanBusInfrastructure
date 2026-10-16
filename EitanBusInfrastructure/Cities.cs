using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EitanBudInfrastructure
{
    public class Cities:BaseEntity
    {
        private string city_name;
        private string transliteration;
        private int region;
        private int population;
        private string cordinates;

        public string City_name { get => city_name; set => city_name = value; }
        public string Transliteration { get => transliteration; set => transliteration = value; }
        public int Region { get => region; set => region = value; }
        public int Population { get => population; set => population = value; }
        public string Cordinates { get => cordinates; set => cordinates = value; }
    }
}
