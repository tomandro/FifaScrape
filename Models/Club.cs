using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace FifaScrape.Models
{
    class Club :IComparable<Club>
    {
        public String name;
        public String abbrName;
        public int id;
        public static Club FromJson(JObject json)
        {
            Club c = new Club();
            c.name = json["name"].Value<String>();
            c.abbrName = json["abbrName"].Value<String>();
            c.id = json["id"].Value<int>();
            return c;
        }

        public JObject ToJson()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Club other)
        {
            return this.id.CompareTo(other.id);
        }
    }
}
