using Alta.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    public interface IRequestInitiateRepository
    {
        public Task Insert(RequestInitiateDTO requestInitiateDTO);
    }
}
