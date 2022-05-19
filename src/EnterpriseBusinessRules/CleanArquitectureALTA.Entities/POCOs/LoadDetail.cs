using Alta.Entities.POCOs.Abstractions;

namespace Alta.Entities.POCOs
{
    public class LoadDetail : RequestConfirm
    {
        public LOAD_DETAIL LOAD_DETAIL { get; set; }
    }

    public class LOAD_DETAIL
    {
        public LOAD_DETAIL_CTRLSEG CTRL_SEG { get; set; }
    }


    public class LOAD_DETAIL_CTRLSEG
    {
        public long TRANID { get; set; }
        public long TRANDT { get; set; }
        public string WH_ID { get; set; }
        public string WCS_ID { get; set; }

        public INV_SEG INV_SEG { get; set; }
    }

    public class INV_SEG
    {
        public string PRTNUM { get; set; }
        public string PRT_CLIENT_ID { get; set; }
        public string UNTCAS { get; set; }
        public string INVSTS { get; set; }
        public string UNTQTY { get; set; }
        public string ORGCOD { get; set; }
        public string REVLVL { get; set; }
        public string LOTNUM { get; set; }
        public string DSTLOC { get; set; }
        public string LODNUM { get; set; }
        public string SUBNUM { get; set; }
        public string DTLNUM { get; set; }
        public string FTPCOD { get; set; }
        public string UNTPAK { get; set; }
        public long FIFDTE { get; set; }
        public long MANDTE { get; set; }
        public string CATCH_QTY { get; set; }
        public long PHYFLG { get; set; }
        public long CNSG_FLG { get; set; }
        public string ASSET_TYP { get; set; }
        public string INV_ATTR_INT1 { get; set; }
        public string INV_ATTR_INT2 { get; set; }
        public string INV_ATTR_INT3 { get; set; }
        public string INV_ATTR_INT4 { get; set; }
        public string INV_ATTR_INT5 { get; set; }
        public long INV_ATTR_FLT1 { get; set; }
        public long INV_ATTR_FLT2 { get; set; }
        public long INV_ATTR_FLT3 { get; set; }
        public long CSTMS_BOND_FLG { get; set; }
        public long DTY_STMP_FLG { get; set; }
        public long LOAD_ATTR1_FLG { get; set; }
        public long LOAD_ATTR2_FLG { get; set; }
        public long LOAD_ATTR3_FLG { get; set; }
        public long LOAD_ATTR4_FLG { get; set; }
        public long LOAD_ATTR5_FLG { get; set; }
    }
}
