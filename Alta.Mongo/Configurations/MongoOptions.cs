using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo.Configurations
{
    public class MongoOptions
    {
        public const string MongoSettings = "MongoSettings";
        public Dictionary<string, string> Collections { get; set; }

    }
}
