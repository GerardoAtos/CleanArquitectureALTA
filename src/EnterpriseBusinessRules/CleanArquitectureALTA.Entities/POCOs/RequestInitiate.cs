using Alta.Entities.POCOs.Abstractions;

namespace Alta.Entities.POCOs
{
    public class RequestInitiate : Entity
    {
        public REQUEST REQUEST { get; set; }
    }
    public class CTRLSEGRequestInitiate : AbstractCTRLSEG
    {
        public REQSEG REQ_SEG { get; set; }
    }

    public class REQSEG
    {
        public string LODNUM { get; set; }
        public string REQ_CONTENTS_FLG { get; set; }
        public string REQ_STOLOC_FLG { get; set; }
    }

    public class REQUEST
    {
        public CTRLSEGRequestInitiate CTRL_SEG { get; set; }
    }
}
