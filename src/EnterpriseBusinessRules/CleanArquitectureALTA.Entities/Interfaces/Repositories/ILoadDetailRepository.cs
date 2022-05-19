﻿using Alta.Entities.POCOs;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces.Repositories
{
    public interface ILoadDetailRepository
    {
        public Task Insert(LoadDetail loadDetail);
    }
}
