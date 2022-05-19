


using Alta.DTOs;
using Alta.Entities.POCOs;

namespace Alta.Profiles
{
    public class MongoProfile : ProfileBase
    {
        public MongoProfile()
        {
            CreateMap<HeartBeatInitiate, HeartBeatInitiateDTO>().ReverseMap()
                .ForPath(poco => poco.HEARTBEAT_INITIATE.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.TRANID))
                .ForPath(poco => poco.HEARTBEAT_INITIATE.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.TRANDT))
                .ForPath(poco => poco.HEARTBEAT_INITIATE.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.WCS_ID))
                .ForPath(poco => poco.HEARTBEAT_INITIATE.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.CTRLSEG.WH_ID))
                .ForPath(poco => poco.HEARTBEAT_INITIATE.HEARTBEAT_SEG.TEXT, options => options.MapFrom(dto => dto.HEARTBEATINITIATE.HEARTBEATSEG.TEXT));

            CreateMap<HeartBeatConfirm, HeartBeatConfirmDTO>().ReverseMap()
                .ForPath(poco => poco.HEARTBEAT_CONFIRM.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.HeartBeatConfirm.CtrlSeg.Tranid))
                .ForPath(poco => poco.HEARTBEAT_CONFIRM.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.HeartBeatConfirm.CtrlSeg.Trandt))
                .ForPath(poco => poco.HEARTBEAT_CONFIRM.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.HeartBeatConfirm.CtrlSeg.WcsId))
                .ForPath(poco => poco.HEARTBEAT_CONFIRM.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.HeartBeatConfirm.CtrlSeg.WhId));

            CreateMap<CreateLineInventory, CreateLineInventoryDTO>().ReverseMap()
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.TRANID))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.TRANDT))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.WCS_ID))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CTRL_SEG.WH_ID))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.WKONUM, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.WKONUM))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.WKOREV, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.WKOREV))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.PRDLIN, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.PRDLIN))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.UOMCOD, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.UOMCOD))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.PRTNUM, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.PRTNUM))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.INVSTS, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.INVSTS))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.UNTQTY, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.UNTQTY))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.LOTNUM, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.LOTNUM))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.DSTLOC, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.DSTLOC))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.LODNUM, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.LODNUM))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.ASSET_TYP, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.ASSET_TYP))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.INV_ATTR_DTE1, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.INV_ATTR_DTE2))
            .ForPath(poco => poco.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.INV_ATTR_DTE2, options => options.MapFrom(dto => dto.CREATE_LINE_INVENTORY_IN_IFD.CREATE_LINE_INVENTORY_SEG.INV_ATTR_DTE2));


















            CreateMap<LoadDetail, LoadDetailDTO>().ReverseMap()
                .ForPath(poco => poco.LOAD_DETAIL, options => options.MapFrom(dto => dto.LoadDetail));



            CreateMap<LoadError, LoadErrorDTO>().ReverseMap();
            CreateMap<MovementConfirm, MovementConfirmDTO>().ReverseMap();
            CreateMap<RequestInitiate, RequestInitiateDTO>().ReverseMap();
        }
    }
}
