using Alta.DTOs.DtoAbstraction;
using System.Text.Json.Serialization;

namespace Alta.DTOs
{
    public class RequestInitiateDTO : DtoBase
    {
        [JsonPropertyName("REQUEST")]
        public REQUEST REQUEST { get; set; }
    }
    public class CTRLSEGRequestInitiate : CTRLSEGAbstractBase
    {

        [JsonPropertyName("REQ_SEG")]
        public REQSEG REQSEG { get; set; }
    }

    public class REQSEG
    {
        [JsonPropertyName("LODNUM")]
        public string LODNUM { get; set; }

        [JsonPropertyName("REQ_CONTENTS_FLG")]
        public string REQCONTENTSFLG { get; set; }

        [JsonPropertyName("REQ_STOLOC_FLG")]
        public string REQSTOLOCFLG { get; set; }
    }

    public class REQUEST
    {
        [JsonPropertyName("CTRL_SEG")]
        public CTRLSEGRequestInitiate CTRLSEG { get; set; }
    }
}
