using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo.Interfaces
{
    public interface IMongoContext
    {
        public IMongoCollection mongoCollection { get; }
        
    }
}
