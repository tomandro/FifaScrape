using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace FifaScrape.Models
{
    class League : IComparable<League>
    {
        public String abbrName;
        public String name;
        public int id;

        public static League FromJson(JObject json)
        {
            League l = new League();
            l.abbrName = json["abbrName"].Value<String>();
            l.name = json["name"].Value<String>();
            l.id = json["id"].Value<int>();
            return l;
        }

        public JObject ToJson()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(League other)
        {
            return this.id.CompareTo(other.id);
        }
    }
}
