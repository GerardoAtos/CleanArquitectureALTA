using Alta.DTOs;
using Alta.Entities.POCOs;

namespace Alta.Profiles
{
    public class RequestInitiateProfile : ProfileBase
    {
        public RequestInitiateProfile()
        {
            CreateMap<RequestInitiate, RequestInitiateDTO>().ReverseMap()
                .ForPath(poco => poco.REQUEST.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.REQUEST.CTRLSEG.TRANID))
                .ForPath(poco => poco.REQUEST.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.REQUEST.CTRLSEG.TRANDT))
                .ForPath(poco => poco.REQUEST.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.REQUEST.CTRLSEG.WH_ID))
                .ForPath(poco => poco.REQUEST.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.REQUEST.CTRLSEG.WCS_ID))
                .ForPath(poco => poco.REQUEST.CTRL_SEG.REQ_SEG.LODNUM, options => options.MapFrom(dto => dto.REQUEST.CTRLSEG.REQSEG.LODNUM))
                .ForPath(poco => poco.REQUEST.CTRL_SEG.REQ_SEG.REQ_STOLOC_FLG, options => options.MapFrom(dto => dto.REQUEST.CTRLSEG.REQSEG.REQSTOLOCFLG))
                .ForPath(poco => poco.REQUEST.CTRL_SEG.REQ_SEG.REQ_CONTENTS_FLG, options => options.MapFrom(dto => dto.REQUEST.CTRLSEG.REQSEG.REQCONTENTSFLG));
        }
    }
}
