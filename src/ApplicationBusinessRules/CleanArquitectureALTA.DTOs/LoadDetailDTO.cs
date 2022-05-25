using System.Text.Json.Serialization;

namespace Alta.DTOs
{
    public class LoadDetailDTO : RequestConfirmDTO
    {
        [JsonPropertyName("LOAD_DETAIL")]
        public LOAD_DETAIL LoadDetail { get; set; }
    }

    public class LOAD_DETAIL
    {
        [JsonPropertyName("CTRL_SEG")]
        public LOAD_DETAIL_CTRLSEG CtrlSeg { get; set; }

    }


    public class LOAD_DETAIL_CTRLSEG
    {
        [JsonPropertyName("TRANID")]
        public long Tranid { get; set; }

        [JsonPropertyName("TRANDT")]
        public long Trandt { get; set; }

        [JsonPropertyName("WH_ID")]
        public string WhId { get; set; }

        [JsonPropertyName("WCS_ID")]
        public string WcsId { get; set; }


        [JsonPropertyName("INV_SEG")]
        public INV_SEG InvSeg { get; set; }

    }

    public class INV_SEG
    {
        [JsonPropertyName("PRTNUM")]
        public string PRTNUM { get; set; }

        [JsonPropertyName("PRT_CLIENT_ID")]
        public string PRT_CLIENT_ID { get; set; }

        [JsonPropertyName("UNTCAS")]
        public string UNTCAS { get; set; }

        [JsonPropertyName("INVSTS")]
        public string INVSTS { get; set; }

        [JsonPropertyName("UNTQTY")]
        public string UNTQTY { get; set; }

        [JsonPropertyName("ORGCOD")]
        public string ORGCOD { get; set; }

        [JsonPropertyName("REVLVL")]
        public string REVLVL { get; set; }

        [JsonPropertyName("LOTNUM")]
        public string LOTNUM { get; set; }

        [JsonPropertyName("DSTLOC")]
        public string DSTLOC { get; set; }

        [JsonPropertyName("LODNUM")]
        public string LODNUM { get; set; }

        [JsonPropertyName("SUBNUM")]
        public string SUBNUM { get; set; }

        [JsonPropertyName("DTLNUM")]
        public string DTLNUM { get; set; }

        [JsonPropertyName("FTPCOD")]
        public string FTPCOD { get; set; }

        [JsonPropertyName("UNTPAK")]
        public string UNTPAK { get; set; }

        [JsonPropertyName("FIFDTE")]
        public long FIFDTE { get; set; }

        [JsonPropertyName("MANDTE")]
        public long MANDTE { get; set; }

        [JsonPropertyName("CATCH_QTY")]
        public string CATCH_QTY { get; set; }

        [JsonPropertyName("PHYFLG")]
        public long PHYFLG { get; set; }

        [JsonPropertyName("CNSG_FLG")]
        public long CNSG_FLG { get; set; }

        [JsonPropertyName("ASSET_TYP")]
        public string ASSET_TYP { get; set; }

        [JsonPropertyName("INV_ATTR_INT1")]
        public string INV_ATTR_INT1 { get; set; }

        [JsonPropertyName("INV_ATTR_INT2")]
        public string INV_ATTR_INT2 { get; set; }

        [JsonPropertyName("INV_ATTR_INT3")]
        public string INV_ATTR_INT3 { get; set; }

        [JsonPropertyName("INV_ATTR_INT4")]
        public string INV_ATTR_INT4 { get; set; }

        [JsonPropertyName("INV_ATTR_INT5")]
        public string INV_ATTR_INT5 { get; set; }

        [JsonPropertyName("INV_ATTR_FLT1")]
        public long INV_ATTR_FLT1 { get; set; }

        [JsonPropertyName("INV_ATTR_FLT2")]
        public long INV_ATTR_FLT2 { get; set; }

        [JsonPropertyName("INV_ATTR_FLT3")]
        public long INV_ATTR_FLT3 { get; set; }

        [JsonPropertyName("CSTMS_BOND_FLG")]
        public long CSTMS_BOND_FLG { get; set; }

        [JsonPropertyName("DTY_STMP_FLG")]
        public long DTY_STMP_FLG { get; set; }

        [JsonPropertyName("LOAD_ATTR1_FLG")]
        public long LOAD_ATTR1_FLG { get; set; }

        [JsonPropertyName("LOAD_ATTR2_FLG")]
        public long LOAD_ATTR2_FLG { get; set; }

        [JsonPropertyName("LOAD_ATTR3_FLG")]
        public long LOAD_ATTR3_FLG { get; set; }

        [JsonPropertyName("LOAD_ATTR4_FLG")]
        public long LOAD_ATTR4_FLG { get; set; }

        [JsonPropertyName("LOAD_ATTR5_FLG")]
        public long LOAD_ATTR5_FLG { get; set; }
    }
}