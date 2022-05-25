using Alta.DTOs;
using Alta.Entities.POCOs;

namespace Alta.Profiles
{
    public class HeartBeatConfirmProfile : ProfileBase
    {
        public HeartBeatConfirmProfile()
        {
            CreateMap<HeartBeatConfirm, HeartBeatConfirmDTO>().ReverseMap()
                .ForPath(poco => poco.HEARTBEAT_CONFIRM.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.HeartBeatConfirm.CtrlSeg.Tranid))
                .ForPath(poco => poco.HEARTBEAT_CONFIRM.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.HeartBeatConfirm.CtrlSeg.Trandt))
                .ForPath(poco => poco.HEARTBEAT_CONFIRM.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.HeartBeatConfirm.CtrlSeg.WcsId))
                .ForPath(poco => poco.HEARTBEAT_CONFIRM.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.HeartBeatConfirm.CtrlSeg.WhId));
        }
    }
}
