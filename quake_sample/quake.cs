using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quake_sample
{
    public class quake
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        public class Earthquake
        {
            public string domesticTsunami { get; set; }
            public string foreignTsunami { get; set; }
            public Hypocenter hypocenter { get; set; }
            public int maxScale { get; set; }
            public string time { get; set; }
        }

        public class Hypocenter
        {
            public int depth { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double magnitude { get; set; }
            public string name { get; set; }
        }

        public class Issue
        {
            public string correct { get; set; }
            public string source { get; set; }
            public string time { get; set; }
            public string type { get; set; }
        }

        public class Point
        {
            public string addr { get; set; }
            public bool isArea { get; set; }
            public string pref { get; set; }
            public int scale { get; set; }
        }

        public class Root
        {
            public int code { get; set; }
            public Earthquake earthquake { get; set; }
            public string id { get; set; }
            public Issue issue { get; set; }
            public List<Point> points { get; set; }
            public string time { get; set; }

            [JsonProperty("user-agent")]
            public string UserAgent { get; set; }
            public string ver { get; set; }
        }


    }
}
