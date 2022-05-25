using System.Collections.Generic;

namespace Alta.Mongo.Configurations
{
    public class MongoOptions
    {
        public const string MongoSettings = "MongoSettings";
        public Dictionary<string, string> Collections { get; set; }

    }
}
