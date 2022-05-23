


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
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.Tranid))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.WhId))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.WcsId))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.Trandt))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.PRTNUM, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.PRTNUM))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.PRT_CLIENT_ID, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.PRT_CLIENT_ID))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.UNTCAS, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.UNTCAS))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.INVSTS, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.INVSTS))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.UNTQTY, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.UNTQTY))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.ORGCOD, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.ORGCOD))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.REVLVL, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.REVLVL))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.LOTNUM, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.LOTNUM))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.DSTLOC, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.DSTLOC))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.LODNUM, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.LODNUM))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.SUBNUM, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.SUBNUM))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.DTLNUM, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.DTLNUM))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.FTPCOD, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.FTPCOD))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.UNTPAK, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.UNTPAK))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.FIFDTE, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.FIFDTE))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.MANDTE, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.MANDTE))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.CATCH_QTY, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.CATCH_QTY))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.PHYFLG, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.PHYFLG))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.CNSG_FLG, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.CNSG_FLG))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.ASSET_TYP, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.ASSET_TYP))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.INV_ATTR_INT1, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.INV_ATTR_INT1))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.INV_ATTR_INT2, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.INV_ATTR_INT2))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.INV_ATTR_INT3, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.INV_ATTR_INT3))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.INV_ATTR_INT4, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.INV_ATTR_INT4))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.INV_ATTR_INT5, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.INV_ATTR_INT5))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.INV_ATTR_FLT1, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.INV_ATTR_FLT1))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.INV_ATTR_FLT2, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.INV_ATTR_FLT2))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.INV_ATTR_FLT3, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.INV_ATTR_FLT3))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.CSTMS_BOND_FLG, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.CSTMS_BOND_FLG))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.DTY_STMP_FLG, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.DTY_STMP_FLG))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.LOAD_ATTR1_FLG, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.LOAD_ATTR1_FLG))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.LOAD_ATTR2_FLG, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.LOAD_ATTR2_FLG))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.LOAD_ATTR3_FLG, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.LOAD_ATTR3_FLG))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.LOAD_ATTR4_FLG, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.LOAD_ATTR4_FLG))
                .ForPath(poco => poco.LOAD_DETAIL.CTRL_SEG.INV_SEG.LOAD_ATTR5_FLG, options => options.MapFrom(dto => dto.LoadDetail.CtrlSeg.InvSeg.LOAD_ATTR5_FLG));

            CreateMap<LoadError, LoadErrorDTO>().ReverseMap()
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.TRANID))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.TRANDT))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.WH_ID))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.WCS_ID))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.LOAD_ERR_SEG.LODNUM, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.LoadErrorSeg.LODNUM))
                .ForPath(poco => poco.LOAD_ERROR.CTRL_SEG.LOAD_ERR_SEG.ERROR_CODE, options => options.MapFrom(dto => dto.LoadError.CtrlSeg.LoadErrorSeg.ERROR_CODE));

            CreateMap<MovementConfirm, MovementConfirmDTO>().ReverseMap()
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.TRANID, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.TRANID))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.TRANDT, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.TRANDT))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.WH_ID, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.WH_ID))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.WCS_ID, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.WCS_ID))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.MOVE_CONF_SEG.LODNUM, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.MOVECONFSEG.LODNUM))
                .ForPath(poco => poco.MOVEMENT_CONFIRM.CTRL_SEG.MOVE_CONF_SEG.DSTLOC, options => options.MapFrom(dto => dto.MOVEMENTCONFIRM.CTRLSEG.MOVECONFSEG.DSTLOC));

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
