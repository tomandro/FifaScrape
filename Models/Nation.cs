using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace FifaScrape.Models
{
    class Nation : IComparable<Nation>
    {
        public String name;
        public int id;
        public String  abbrName;
        public static Nation FromJson(JObject json)
        {
            Nation n = new Nation();
            n.name = json["name"].Value<String>();
            n.abbrName = json["abbrName"].Value<String>();
            n.id = json["id"].Value<int>();
            return n;
        }

        public JObject ToJson()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Nation other)
        {
            return this.id.CompareTo(other.id);
        }
    }
}
