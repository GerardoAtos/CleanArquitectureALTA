using Alta.DTOs;
using Alta.Entities.POCOs;

namespace Alta.Profiles
{
    public class LoadErrorProfile : ProfileBase
    {
        public LoadErrorProfile()
        {
            CreateMap<LoadError, LoadErrorDTO>().ReverseMap()
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.TRANID))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.TRANDT))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.WH_ID))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.WCS_ID))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.LOAD_ERR_SEG.LODNUM, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.LoadErrorSeg.LODNUM))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.LOAD_ERR_SEG.ERROR_CODE, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.LoadErrorSeg.ERROR_CODE));
        }
    }
}
