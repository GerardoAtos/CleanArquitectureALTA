using Alta.DTOs;
using Alta.Entities.POCOs;

namespace Alta.Profiles
{
    public class HeartBeatInitiateProfile : ProfileBase
    {
        public HeartBeatInitiateProfile()
        {
            CreateMap<HeartBeatInitiate, HeartBeatInitiateDTO>().ReverseMap()
                .ForPath(poco => poco.HEARTBEAT_INITIATE.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.TRANID))
                .ForPath(poco => poco.HEARTBEAT_INITIATE.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.TRANDT))
                .ForPath(poco => poco.HEARTBEAT_INITIATE.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.WCS_ID))
                .ForPath(poco => poco.HEARTBEAT_INITIATE.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.WH_ID))
                .ForPath(poco => poco.HEARTBEAT_INITIATE.HEARTBEAT_SEG.TEXT, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.HEARTBEATSEG.TEXT));
        }
    }
}
