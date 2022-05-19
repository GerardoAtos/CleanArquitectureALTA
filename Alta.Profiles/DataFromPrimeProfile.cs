using Alta.DTOs;
using Alta.Entities.POCOs;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Profiles
{
    public class DataFromPrimeProfile : ProfileBase
    {
        public DataFromPrimeProfile()
        {
            CreateMap<DataFromPrime, SavePrimeDataDTO>()
                .ReverseMap();
        }
    }
}
