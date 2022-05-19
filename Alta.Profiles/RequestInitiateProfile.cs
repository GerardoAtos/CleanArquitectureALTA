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
    public class RequestInitiateProfile : ProfileBase
    {
        public RequestInitiateProfile()
        {
            CreateMap<RequestInitiate, RequestInitiateDTO>()
               .ReverseMap()
               .ForPath(poco => poco.TranId, opts => opts.MapFrom(dto => dto.REQUEST.CTRLSEG.TRANID))
               .ForPath(poco => poco.TranDT, opts => opts.MapFrom(dto => dto.REQUEST.CTRLSEG.TRANDT))
               .ForPath(poco => poco.WHId, opts => opts.MapFrom(dto => dto.REQUEST.CTRLSEG.WH_ID))
               .ForPath(poco => poco.WCSId, opts => opts.MapFrom(dto => dto.REQUEST.CTRLSEG.WCS_ID))
               .ForPath(poco => poco.LODNum, opts => opts.MapFrom(dto => dto.REQUEST.CTRLSEG.REQSEG.LODNUM))
               .ForPath(poco => poco.RequestContentsFlag, opts => opts.MapFrom(dto => dto.REQUEST.CTRLSEG.REQSEG.REQCONTENTSFLG))
               .ForPath(poco => poco.RequestStolocFlag, opts => opts.MapFrom(dto => dto.REQUEST.CTRLSEG.REQSEG.REQSTOLOCFLG));
        }
    }
}
