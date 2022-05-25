using Alta.DTOs;
using Alta.Entities.POCOs;

namespace Alta.Profiles
{
    public class MovementConfirmProfile : ProfileBase
    {
        public MovementConfirmProfile()
        {
            CreateMap<MovementConfirm, MovementConfirmDTO>().ReverseMap()
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.TRANID))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.TRANDT))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.WH_ID))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.WCS_ID))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.MOVE_CONF_SEG.LODNUM, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.MOVECONFSEG.LODNUM))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.MOVE_CONF_SEG.DSTLOC, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.MOVECONFSEG.DSTLOC));
        }
    }
}
