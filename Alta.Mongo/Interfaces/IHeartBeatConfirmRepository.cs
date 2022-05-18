using Alta.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo.Interfaces
{
    public interface IHeartBeatConfirmRepository
    {
        public Task Insert(HeartBeatConfirmDTO heartBeatConfirmDTO);
    }
}
