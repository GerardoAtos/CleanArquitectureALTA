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
    public class HeartbeatInitiateProfile : ProfileBase
    {
        public HeartbeatInitiateProfile()
        {
            CreateMap<HeartbeatInitiate, HeartBeatInitiateDTO>()
               .ReverseMap()
               .ForPath(poco => poco.TranId, opts => opts.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.TRANID))
               .ForPath(poco => poco.TranDT, opts => opts.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.TRANDT))
               .ForPath(poco => poco.WHId, opts => opts.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.WH_ID))
               .ForPath(poco => poco.WCSId, opts => opts.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.WCS_ID))
               .ForPath(poco => poco.Text, opts => opts.MapFrom(dto => dto.HEARTBEATINITIATE.HEARTBEATSEG.TEXT));

            CreateMap<HeartBeatConfirmDTO, HeartbeatInitiate>()
                .ReverseMap()
                .ForPath(dto => dto.HeartBeatConfirm.CtrlSeg.Trandt, opts => opts.MapFrom(poco => poco.TranDT))
                .ForPath(dto => dto.HeartBeatConfirm.CtrlSeg.Tranid, opts => opts.MapFrom(poco => poco.TranId))
                .ForPath(dto => dto.HeartBeatConfirm.CtrlSeg.WcsId, opts => opts.MapFrom(poco => poco.WCSId))
                .ForPath(dto => dto.HeartBeatConfirm.CtrlSeg.HeartBeatConfirmSeg.TEXT, opts => opts.MapFrom(poco => poco.Text));
        }
    }
}
